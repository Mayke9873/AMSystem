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

            this.Consulta();
        }

        private void Consulta()
        {
            if (rdoTodos.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT ID, DESCRICAO, ATIVO FROM GRUPO_PRODUTO" +
                        " WHERE id > 1 AND ((Id = '" + txtPesquisa.Text + "') OR (DESCRICAO like '%" + txtPesquisa.Text + "%'));", con.query);
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
                return;
            }
            else if (rdoAtivo.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT ID, DESCRICAO, ATIVO FROM GRUPO_PRODUTO" +
                        " WHERE ATIVO = 'S' and id > 1 AND ((Id = '" + txtPesquisa.Text + "') OR (DESCRICAO like '%" + txtPesquisa.Text + "%'));", con.query);
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
                return;
            }
            else if (rdoInativo.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT ID, DESCRICAO, ATIVO FROM GRUPO_PRODUTO" +
                        " WHERE ATIVO = 'N' and id > 1 AND ((Id = '" + txtPesquisa.Text + "') OR (DESCRICAO like '%" + txtPesquisa.Text + "%'));", con.query);
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
                return;
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
            txtPesquisa.Enabled = false;
            rdoTodos.Enabled = false;
            rdoAtivo.Enabled = false;
            rdoInativo.Enabled = false;
            txtDescGrupoProd.Enabled = true;
            chkAtivo.Enabled = true;
            tsbtnAddGrupoProd.Enabled = false;
            tsbtnEditGrupoProd.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;

            tcGrupoProdutos.SelectTab(tpDadosGrupoProd);
        }
        private void tsbtnEditGrupoProd_Click(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = false;
            rdoTodos.Enabled = false;
            rdoAtivo.Enabled = false;
            rdoInativo.Enabled = false;
            txtDescGrupoProd.Enabled = true;
            chkAtivo.Enabled = true;
            tsbtnAddGrupoProd.Enabled = false;
            tsbtnEditGrupoProd.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;

            tcGrupoProdutos.SelectTab(tpDadosGrupoProd);
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;

            if (txtDescGrupoProd.Text.Length == 0)
            {
                MessageBox.Show("Descrição não preenchida. Por favor, verifique!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (chkAtivo.Checked == true)
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

                if (txtIdGpProduto.Text.Length == 0)
                {
                    cmd = new MySqlCommand("INSERT INTO GRUPO_PRODUTO (DESCRICAO, ATIVO) VALUES " +
                    "('" + txtDescGrupoProd.Text + "', '" + ativo + "');", con.query);
                }
                else if(txtIdGpProduto.Text.Length != 0)
                {
                    //      FAZER UPDATE
                    //cmd = new MySqlCommand("INSERT INTO GRUPO_PRODUTO (DESCRICAO, ATIVO) VALUES " +
                    //"('" + txtDescGrupoProd.Text + "', '" + ativo + "');", con.query);
                }

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Consulta();

                txtPesquisa.Enabled = true;
                rdoTodos.Enabled = true;
                rdoAtivo.Enabled = true;
                rdoInativo.Enabled = true;
                txtDescGrupoProd.Enabled = false;
                chkAtivo.Enabled = false;
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
            txtPesquisa.Enabled = true;
            rdoTodos.Enabled = true;
            rdoAtivo.Enabled = true;
            rdoInativo.Enabled = true;
            txtDescGrupoProd.Enabled = false;
            chkAtivo.Enabled = false;
            tsbtnAddGrupoProd.Enabled = true;
            tsbtnEditGrupoProd.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;

            tcGrupoProdutos.SelectTab(tpGrupoProdudo);
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void rdoTodos_CheckedChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void rdoAtivo_CheckedChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void rdoInativo_CheckedChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void dgvGrupoProd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string ativo;

            DataGridViewRow row = dgvGrupoProd.Rows[e.RowIndex];
            if (row != null)
            {
                txtIdGpProduto.Text = row.Cells[0].Value.ToString();
                txtDescGrupoProd.Text = row.Cells[1].Value.ToString();
                ativo = row.Cells[2].Value.ToString();

                if (ativo == "S")
                {
                    chkAtivo.Checked = true;
                }
                else if (ativo == "N")
                {
                    chkAtivo.Checked = false;
                }
            }
        }
    }
}
