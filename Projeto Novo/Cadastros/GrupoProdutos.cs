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
    public partial class FrmGrupoProdutos : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmGrupoProdutos()
        {
            InitializeComponent();

            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT ID, DESCRICAO, ATIVO FROM GRUPO_PRODUTO WHERE ATIVO = 'S' and id > 1;", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvGrupoProd.DataSource = ds;
                dgvGrupoProd.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                con.CloseConn();
            }
        }

        private void FrmGrupoProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    tsbtnSair_Click(sender, e);
                    break;
            }
        }


        private void tsbtnAddGrupoProd_Click(object sender, EventArgs e)
        {
            tsbtnAddGrupoProd.Enabled = false;
            tsbtnEditGrupoProd.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;

            tcGrupoProdutos.SelectTab(tpDadosGrupoProd);
        }
        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;

            if (txtDescGrupoProd.Text.Length == 0)
            {
                MessageBox.Show("Descrição não preenchida. Por favor, verifique!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rdoAtivo.Checked == true)
            {
                ativo = "S";
            }
            else
            {
                ativo = "N";
            }

            try
            {
                con.OpenConn();

                cmd = new MySqlCommand("INSERT INTO GRUPO_PRODUTO (DESCRICAO, ATIVO) VALUES " +
                    "('"+ txtDescGrupoProd.Text + "', '"+ ativo +"');",con.query);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd = new MySqlCommand("SELECT ID, DESCRICAO, ATIVO FROM GRUPO_PRODUTO WHERE ATIVO = 'S' and id > 1;", con.query);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvGrupoProd.DataSource = ds;
                dgvGrupoProd.DataMember = ds.Tables[0].TableName;

                tsbtnAddGrupoProd.Enabled = true;
                tsbtnEditGrupoProd.Enabled = true;
                tsbtnSalvar.Enabled = false;
                tsbtnCancelar.Enabled = false;

                tcGrupoProdutos.SelectTab(tpGrupoProdudo);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                con.CloseConn();
            }
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            tsbtnAddGrupoProd.Enabled = true;
            tsbtnEditGrupoProd.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;

            tcGrupoProdutos.SelectTab(tpGrupoProdudo);
        }
    }
}
