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
    public partial class FrmFornecedor : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmFornecedor()
        {
            InitializeComponent();


            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT * FROM FORNECEDOR WHERE ATIVO = 'S';", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvFornecedor.DataSource = ds;
                dgvFornecedor.DataMember = ds.Tables[0].TableName;
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

        private void FrmFornecedor_KeyDown(object sender, KeyEventArgs e)
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

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAddFornecedor_Click(object sender, EventArgs e)
        {
            tcFornecedores.SelectTab(tpDados);

            tsbtnAddFornecedor.Enabled = false;
            tsbtnEditFornecedor.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
            txtNomeFornecedor.Enabled = true;
            txtIe.Enabled = true;
            mtxCNPJ.Enabled = true;
            txtEndFornecedor.Enabled = true;
            txtNumEndFornecedor.Enabled = true;
            txtBairroFornecedor.Enabled = true;
            chkAtivo.Enabled = true;
            

            chkAtivo.Checked = true;

            txtIdFornecedor.Clear();
            txtNomeFornecedor.Clear();
            txtIe.Clear();
            mtxCNPJ.Clear();
            txtEndFornecedor.Clear();
            txtNumEndFornecedor.Clear();
            txtBairroFornecedor.Clear();
        }
        private void tsbtnEditFornecedor_Click(object sender, EventArgs e)
        {
            tcFornecedores.SelectTab(tpDados);

            tsbtnAddFornecedor.Enabled = false;
            tsbtnEditFornecedor.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
            txtNomeFornecedor.Enabled = true;
            txtIe.Enabled = true;
            mtxCNPJ.Enabled = true;
            txtEndFornecedor.Enabled = true;
            txtNumEndFornecedor.Enabled = true;
            txtBairroFornecedor.Enabled = true;
            chkAtivo.Enabled = true;


            chkAtivo.Checked = true;
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            char ativo;
            DateTime dtRegistro;

            if (txtNomeFornecedor.Text.Length == 0)
            {
                MessageBox.Show("Campo nome não preenchido, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return;
            }

            if (chkAtivo.Checked == true)
            {
                ativo = 'S';
            }
            else
            {
                ativo = 'N';
            }

            if (txtIdFornecedor.Text.Length == 0)
            {
                con.OpenConn();
                cmd = new MySqlCommand("INSERT INTO FORNECEDOR (NOME, IE, CNPJ, ENDERECO, numENDERECO, BAIRRO, ATIVO, DtREGISTRO)" +
                    " VALUES ('" + txtNomeFornecedor.Text + "', '" + txtIe.Text + "', @cnpj, '" + txtEndFornecedor.Text + "', '" + txtNumEndFornecedor.Text + "', " +
                    "'" + txtBairroFornecedor.Text + "', '" + ativo + "', @DtRegistro);", con.query);
            }
            else if (txtIdFornecedor.Text.Length != 0)
            {
                con.OpenConn();
                cmd = new MySqlCommand("UPDATE FORNECEDOR SET NOME = '" + txtNomeFornecedor.Text + "', IE = '" + txtIe.Text + "', CNPJ = @cnpj, " +
                    "ENDERECO = '" + txtEndFornecedor.Text + "', numENDERECO = '" + txtNumEndFornecedor.Text + "', BAIRRO = '" + txtBairroFornecedor.Text + "', " +
                    "ATIVO = '" + ativo + "' WHERE ID = " + int.Parse(txtIdFornecedor.Text) + "", con.query);
            }

            try
            {
                con.OpenConn();

                cmd.Parameters.AddWithValue("@DtRegistro", dtRegistro = DateTime.Now);
                cmd.Parameters.AddWithValue("@cnpj", mtxCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", ""));
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Dados gravado com sucesso!", "SQS System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (rdoTodos.Checked == true)
                {
                    rdoTodos_CheckedChanged(null, null);
                }
                else if (rdoAtivo.Checked == true)
                {
                    rdoAtivo_CheckedChanged(null, null);
                }
                else if (rdoInativo.Checked == true)
                {
                    rdoInativo_CheckedChanged(null, null);
                }

                tsbtnAddFornecedor.Enabled = true;
                tsbtnEditFornecedor.Enabled = true;
                tsbtnSalvar.Enabled = false;
                tsbtnCancelar.Enabled = false;
                txtNomeFornecedor.Enabled = false;
                txtIe.Enabled = false;
                mtxCNPJ.Enabled = false;
                txtEndFornecedor.Enabled = false;
                txtNumEndFornecedor.Enabled = false;
                txtBairroFornecedor.Enabled = false;
                chkAtivo.Enabled = false;

                tcFornecedores.SelectTab(tpFornecedor);
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

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            tcFornecedores.SelectTab(tpFornecedor);

            tsbtnAddFornecedor.Enabled = true;
            tsbtnEditFornecedor.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;
            txtNomeFornecedor.Enabled = false;
            txtIe.Enabled = false;
            mtxCNPJ.Enabled = false;
            txtEndFornecedor.Enabled = false;
            txtNumEndFornecedor.Enabled = false;
            txtBairroFornecedor.Enabled = false;
            chkAtivo.Enabled = false;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (rdoTodos.Checked == true)
            {
                rdoTodos_CheckedChanged(null, null);
            }
            else if (rdoAtivo.Checked == true)
            {
                rdoAtivo_CheckedChanged(null, null);
            }
            else if (rdoInativo.Checked == true)
            {
                rdoInativo_CheckedChanged(null, null);
            }
        }

        private void dgvFornecedor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string ativo;

            DataGridViewRow row = dgvFornecedor.Rows[e.RowIndex];
            txtIdFornecedor.Text = row.Cells[0].Value.ToString();
            txtNomeFornecedor.Text = row.Cells[1].Value.ToString();
            txtIe.Text = row.Cells[2].Value.ToString();
            mtxCNPJ.Text = row.Cells[3].Value.ToString();
            txtEndFornecedor.Text = row.Cells[4].Value.ToString();
            txtNumEndFornecedor.Text = row.Cells[5].Value.ToString();
            txtBairroFornecedor.Text = row.Cells[6].Value.ToString();
            ativo = row.Cells[8].Value.ToString();

            if (ativo == "S")
            {
                chkAtivo.Checked = true;
            }
            else if (ativo == "N")
            {
                chkAtivo.Checked = false;
            }
        }

        private void rdoTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT * FROM FORNECEDOR WHERE NOME LIKE'%" + txtPesquisa.Text + "%';", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvFornecedor.DataSource = ds;
                dgvFornecedor.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                con.CloseConn();

            }
        }

        private void rdoAtivo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT * FROM FORNECEDOR WHERE NOME LIKE '%" + txtPesquisa.Text + "%' AND ATIVO = 'S';", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvFornecedor.DataSource = ds;
                dgvFornecedor.DataMember = ds.Tables[0].TableName;
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

        private void rdoInativo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT * FROM FORNECEDOR WHERE NOME LIKE '%" + txtPesquisa.Text + "%' AND ATIVO = 'N';", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvFornecedor.DataSource = ds;
                dgvFornecedor.DataMember = ds.Tables[0].TableName;
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
