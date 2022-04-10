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
    public partial class FrmProduto : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmProduto()
        {
            InitializeComponent();

            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT ID, DESCRICAO, UNIDADE, ESTOQUE, PCOMPRA, PLUCRO, PVENDA, GRUPO, DTREGISTRO, ATIVO FROM PRODUTO WHERE ATIVO = 'S'", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvProduto.DataSource = ds;
                dgvProduto.DataMember = ds.Tables[0].TableName;
                cmd.Dispose();

                cmd = new MySqlCommand("SELECT DESCRICAO FROM GRUPO_PRODUTO WHERE ATIVO = 'S';",con.query);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbGrupo.DisplayMember = "descricao";
                cbGrupo.DataSource = dt;
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
        
        private void Consulta()
        {
            if (rdoTodos.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT ID, DESCRICAO, UNIDADE, ESTOQUE, PCOMPRA, PLUCRO, PVENDA, GRUPO, DTREGISTRO, ATIVO FROM PRODUTO " +
                        "WHERE DESCRICAO LIKE '%" + txtPesquisa.Text + "%' OR ((ID = '0') OR (ID = '" + txtPesquisa.Text + "'));", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvProduto.DataSource = ds;
                    dgvProduto.DataMember = ds.Tables[0].TableName;
                    cmd.Dispose();
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

            else if (rdoAtivo.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT ID, DESCRICAO, UNIDADE, ESTOQUE, PCOMPRA, PLUCRO, PVENDA, GRUPO, DTREGISTRO, ATIVO FROM PRODUTO " +
                        "WHERE ATIVO = 'S' AND DESCRICAO LIKE '%" + txtPesquisa.Text + "%' OR ((ID = 0) OR (ID = '" + txtPesquisa.Text + "'));", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvProduto.DataSource = ds;
                    dgvProduto.DataMember = ds.Tables[0].TableName;
                    cmd.Dispose();
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

            else if (rdoInativo.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT ID, DESCRICAO, UNIDADE, ESTOQUE, PCOMPRA, PLUCRO, PVENDA, GRUPO, DTREGISTRO, ATIVO FROM PRODUTO " +
                        "WHERE ATIVO = 'N' AND DESCRICAO LIKE '%" + txtPesquisa.Text + "%' OR ((ID = 0) OR (ID = '" + txtPesquisa.Text + "'));", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvProduto.DataSource = ds;
                    dgvProduto.DataMember = ds.Tables[0].TableName;
                    cmd.Dispose();
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

        private void FrmProduto_KeyDown(object sender, KeyEventArgs e)
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

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAddProduto_Click(object sender, EventArgs e)
        {
            tcProdutos.SelectTab(tpDadosProd);

            tsbtnAddProduto.Enabled = false;
            tsbtnEditProduto.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;

            txtPesquisa.Enabled = false;
            txtDescricao.Enabled = true;
            txtUnidade.Enabled = true;
            txtEstoque.Enabled = true;
            txtValCompra.Enabled = true;
            txtValLucro.Enabled = true;
            txtValVenda.Enabled = true;
            cbGrupo.Enabled = true;
            chkAtivo.Enabled = true;

            txtIdProduto.Clear();
            txtDescricao.Clear();
            txtUnidade.Clear();
            txtEstoque.Clear();
            txtValCompra.Clear();
            txtValLucro.Clear();
            txtValVenda.Clear();
            cbGrupo.Text = "";
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            tcProdutos.SelectTab(tpProduto);

            tsbtnAddProduto.Enabled = true;
            tsbtnEditProduto.Enabled = true;
            tsbtnCancelar.Enabled = false;
            tsbtnSalvar.Enabled = false;

            txtPesquisa.Enabled = true;
            txtDescricao.Enabled = false;
            txtUnidade.Enabled = false;
            txtEstoque.Enabled = false;
            txtValCompra.Enabled = false;
            txtValLucro.Enabled = false;
            txtValVenda.Enabled = false;
            cbGrupo.Enabled = false;
            chkAtivo.Enabled = false;
            chkAtivo.Enabled = false;
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;
            DateTime dtRegistro;

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

                if (txtIdProduto.Text.Length == 0)
                {
                    cmd = new MySqlCommand("INSERT INTO PRODUTO (descricao, unidade, estoque, pCompra, pLucro, pVenda, grupo, dtRegistro, ativo) VALUES" +
                        "('" + txtDescricao.Text + "', '" + txtUnidade.Text + "', '" + txtEstoque.Text + "', '" + txtValCompra.Text + "', '" + txtValLucro.Text + "'," +
                        "'" + txtValVenda.Text + "', '" + cbGrupo.Text + "', @dtRegistro, @ativo);", con.query);
                }
                else if(txtIdProduto.Text.Length != 0)
                {
                    cmd = new MySqlCommand("UPDATE PRODUTO SET descricao = '" + txtDescricao.Text + "', unidade = '" + txtUnidade.Text + "', pCompra = '" + txtValCompra.Text + "', " +
                        "pLucro = '" + txtValLucro.Text + "', pVenda = '" + txtValVenda.Text + "', grupo = '" + cbGrupo.Text + "', ativo = @ativo WHERE ID = " + int.Parse(txtIdProduto.Text) + "", con.query);
                }

                cmd.Parameters.AddWithValue("@ativo", ativo);
                cmd.Parameters.AddWithValue("@dtRegistro", dtRegistro = DateTime.Now);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Consulta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.CloseConn();
            }

            tcProdutos.SelectTab(tpProduto);

            tsbtnAddProduto.Enabled = true;
            tsbtnEditProduto.Enabled = true;
            tsbtnCancelar.Enabled = false;
            tsbtnSalvar.Enabled = false;

            txtPesquisa.Enabled = true;
            txtDescricao.Enabled = false;
            txtUnidade.Enabled = false;
            txtEstoque.Enabled = false;
            txtValCompra.Enabled = false;
            txtValLucro.Enabled = false;
            txtValVenda.Enabled = false;
            cbGrupo.Enabled = false; 
        }

        private void txtValLucro_Leave(object sender, EventArgs e)
        {
            decimal compra, lucro, venda;

            if (txtValCompra.Text.Length != 0)
            {
                compra = decimal.Parse(txtValCompra.Text);
            }
            else
            {
                compra = 0;
            }

            if (txtValLucro.Text.Length != 0)
            {
                lucro = decimal.Parse(txtValLucro.Text);
            }
            else
            {
                lucro = 0;
            }

            venda = compra + (compra * (lucro / 100));

            txtValVenda.Text = venda.ToString();
        }

        private void txtValVenda_Leave(object sender, EventArgs e)
        {
            decimal compra, lucro, venda;

            if (txtValCompra.Text.Length != 0)
            {
                compra = decimal.Parse(txtValCompra.Text);
            }
            else
            {
                compra = 0;
            }

            if (txtValVenda.Text.Length != 0)
            {
                venda = decimal.Parse(txtValVenda.Text);
            }
            else
            {
                venda = 0;
            }

            lucro = (venda - compra) / compra * 100;

            txtValLucro.Text = lucro.ToString();
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void dgvProduto_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string ativo;

            DataGridViewRow row = dgvProduto.Rows[e.RowIndex];
            if (row != null)
            {
                txtIdProduto.Text = row.Cells[0].Value.ToString();
                txtDescricao.Text = row.Cells[1].Value.ToString();
                txtUnidade.Text = row.Cells[2].Value.ToString();
                txtEstoque.Text = row.Cells[3].Value.ToString();
                txtValCompra.Text = row.Cells[4].Value.ToString();
                txtValLucro.Text = row.Cells[5].Value.ToString();
                txtValVenda.Text = row.Cells[6].Value.ToString();
                cbGrupo.Text = row.Cells[7].Value.ToString();
                ativo = row.Cells[9].Value.ToString();

                if (ativo == "S")
                {
                    chkAtivo.Checked = true;
                }
                else
                {
                    chkAtivo.Checked = false;
                }
            }
        }

        private void tsbtnEditProduto_Click(object sender, EventArgs e)
        {
            tcProdutos.SelectTab(tpDadosProd);

            tsbtnAddProduto.Enabled = false;
            tsbtnEditProduto.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;

            txtPesquisa.Enabled = false;
            txtDescricao.Enabled = true;
            txtUnidade.Enabled = true;
            txtEstoque.Enabled = true;
            txtValCompra.Enabled = true;
            txtValLucro.Enabled = true;
            txtValVenda.Enabled = true;
            cbGrupo.Enabled = true;
            chkAtivo.Enabled = true;
        }
    }
}