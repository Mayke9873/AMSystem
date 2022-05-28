using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Novo
{
    public partial class FrmConsVendas : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmConsVendas()
        {
            InitializeComponent();

            this.Consulta();
        }

        private void Consulta()
        {
            if (mtxDtInicial.MaskCompleted == false || mtxDtFinal.MaskCompleted == false)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT a.ID, a.CLIENTE, a.VALOR, a.DESCONTO, a.VALOR_TOTAL, a.DATA_VENDA, b.NOME FROM VENDA a LEFT JOIN  FUNCIONARIO b on  a.VENDEDOR = b.ID" +
                        " WHERE CLIENTE LIKE '%" + txtPesquisa.Text + "%';", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvVendas.DataSource = ds;
                    dgvVendas.DataMember = ds.Tables[0].TableName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.CloseConn();
                }
            }
            else
            {
                try
                {
                    //conversão da data no select
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT a.ID, a.CLIENTE, a.VALOR, a.DESCONTO, a.VALOR_TOTAL, a.DATA_VENDA, b.NOME FROM VENDA a LEFT JOIN  FUNCIONARIO b on  a.VENDEDOR = b.ID" +
                        " WHERE CLIENTE LIKE '%" + txtPesquisa.Text + "%' AND DATA_VENDA BETWEEN" +
                        " (SELECT date_format(str_to_date('" + mtxDtInicial.Text + "', '%d/%m/%Y'), '%Y-%m-%d'))" +
                        " AND (SELECT date_format(str_to_date('" + mtxDtFinal.Text + "', '%d/%m/%Y'), '%Y-%m-%d'));", con.query);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvVendas.DataSource = ds;
                    dgvVendas.DataMember = ds.Tables[0].TableName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.CloseConn();
                }
            }
        }

        private void FrmConsVendas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    tsbtnSair_Click(sender, e);
                    break;
            }
        }
        private void tsbtnAddVenda_Click(object sender, EventArgs e)
        {
            FrmVenda venda = new FrmVenda();
            venda.MdiParent = JanelaPai.Instance();

            if (Application.OpenForms.OfType<FrmVenda>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            venda.Show();
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }
    }
}
