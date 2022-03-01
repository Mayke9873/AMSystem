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

                cmd = new MySqlCommand("SELECT ID, DESCRICAO, UNIDADE, ESTOQUE, PCOMPRA, PLUCRO, PVENDA, GRUPO, DTREGISTRO, ATIVO FROM PRODUTO", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvProduto.DataSource = ds;
                dgvProduto.DataMember = ds.Tables[0].TableName;
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
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            tsbtnAddProduto.Enabled = true;
            tsbtnEditProduto.Enabled = true;
            tsbtnCancelar.Enabled = false;
            tsbtnSalvar.Enabled = false;

            tcProdutos.SelectTab(tpProduto);
        }

        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT DESCRICAO FROM GRUPOPRODUTO");
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;
            DateTime dtRegistro;

            if (rdoProdAtivo.Checked == true)
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

                cmd = new MySqlCommand("INSERT INTO PRODUTO (descricao, unidade, estoque, pCompra, pLucro, pVenda, grupo, dtRegistro, ativo) VALUES" +
                    "('" + txtDescricao.Text + "', '" + txtUnidade.Text + "', '" + txtEstoque.Text + "', '" + txtValCompra.Text + "', '" + txtValLucro.Text + "'," +
                    "'" + txtValVenda.Text + "', '" + cbGrupo.Text + "', @dtRegistro, @ativo)", con.query);

                cmd.Parameters.AddWithValue("@ativo", ativo);
                cmd.Parameters.AddWithValue("@dtRegistro", dtRegistro = DateTime.Now);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd = new MySqlCommand("SELECT * FROM PRODUTO", con.query);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvProduto.DataSource = ds;
                dgvProduto.DataMember = ds.Tables[0].TableName;

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
}
