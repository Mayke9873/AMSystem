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
    public partial class FrmConsCompras : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmConsCompras()
        {
            InitializeComponent();

            this.Consulta();
        }

        private void Consulta()
        {
            con.OpenConn();

            if (mtxDtInicial.MaskCompleted && mtxDtFinal.MaskCompleted)
            {
                try
                {
                    cmd = new MySqlCommand("SELECT a.ID, a.FORNECEDOR, a.VALOR, a.DESCONTO, a.VALOR_TOTAL, a.DATA_COMPRA, b.NOME " +
                        "FROM COMPRA a LEFT JOIN FUNCIONARIO b ON a.USUARIO = b.ID WHERE EX = 0 AND DATA_COMPRA BETWEEN" +
                        $" (SELECT date_format(str_to_date('{mtxDtInicial.Text}', '%d/%m/%Y'), '%Y-%m-%d'))" +
                        $" AND (SELECT date_format(str_to_date('{mtxDtFinal.Text}', '%d/%m/%Y'), '%Y-%m-%d') AND FORNECEDOR LIKE '%{txtPesquisa.Text}%');", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvCompras.DataSource = ds;
                    dgvCompras.DataMember = ds.Tables[0].TableName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                cmd = new MySqlCommand("SELECT a.ID, a.FORNECEDOR, a.VALOR, a.DESCONTO, a.VALOR_TOTAL, a.DATA_COMPRA, b.NOME " +
                    $"FROM COMPRA a LEFT JOIN FUNCIONARIO b ON a.USUARIO = b.ID WHERE EX = 0 AND FORNECEDOR LIKE '%{txtPesquisa.Text}%';", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvCompras.DataSource = ds;
                dgvCompras.DataMember = ds.Tables[0].TableName;
            }
            con.CloseConn();
        }

        private void FrmConsCompras_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.F3:
                    tsbtnAddCompra_Click(sender, e);
                    break;

                case Keys.Escape:
                    tsbtnSair_Click(sender, e);
                    break;
            }
        }

        private void tsbtnAddCompra_Click(object sender, EventArgs e)
        {
            FrmCompra compra = new FrmCompra();
            compra.MdiParent = JanelaPai.Instance();

            if (Application.OpenForms.OfType<FrmCompra>().Count() > 0)
            {
                MessageBox.Show("Tela já está aberta, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            compra.Show();
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Consulta();
        }

        private void mtxDtFinal_Leave(object sender, EventArgs e)
        {
            Consulta();
        }

        private void tsbtnEditCompra_Click(object sender, EventArgs e)
        {
            FrmCompra compra = new FrmCompra();

            compra.Show();

            compra.txtIdCompra.Text = dgvCompras.CurrentRow.Cells[1].Value.ToString();
            //compra.txtIdFornecedor.Text = dgvCompras.CurrentRow.Cells[2].Value.ToString();
            compra.txtFornecedor.Text = dgvCompras.CurrentRow.Cells[2].Value.ToString();
            compra.txtDescontoCompra.Text = dgvCompras.CurrentRow.Cells[4].Value.ToString();
            compra.txtValorCompra.Text = dgvCompras.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
