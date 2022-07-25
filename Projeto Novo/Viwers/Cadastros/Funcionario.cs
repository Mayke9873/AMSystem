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
    public partial class FrmFuncionario : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmFuncionario()
        {
            InitializeComponent();

            this.Consulta();

            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT DESCRICAO FROM GRUPO_USUARIO;", con.query);

                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbGpUsu.DisplayMember = "DESCRICAO";
                cbGpUsu.DataSource = dt;
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
            if (rdoAtivo.Checked == true)
            {
                try
                {
                    con.OpenConn();

                    cmd = new MySqlCommand("SELECT a.ID, a.NOME, A.RG, a.CPF, a.DTNASC, a.ENDERECO, a.NUMENDERECO, a.BAIRRO, a.DTREGISTRO, a.ATIVO, b.DESCRICAO, a.LOGIN, a.SENHA " +
                        "FROM FUNCIONARIO a LEFT JOIN GRUPO_USUARIO b ON a.GRUPO_USU = b.ID " +
                        "WHERE a.ativo = 'S' AND ((a.Id = '" + txtPesquisa.Text + "') OR (a.Nome like '%" + txtPesquisa.Text + "%'));", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvFuncionario.DataSource = ds;
                    dgvFuncionario.DataMember = ds.Tables[0].TableName;
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

                    cmd = new MySqlCommand("SELECT a.ID, a.NOME, A.RG, a.CPF, a.DTNASC, a.ENDERECO, a.NUMENDERECO, a.BAIRRO, a.DTREGISTRO, a.ATIVO, b.DESCRICAO, a.LOGIN, a.SENHA " +
                        "FROM FUNCIONARIO a LEFT JOIN GRUPO_USUARIO b ON a.GRUPO_USU = b.ID " +
                        "WHERE a.ativo = 'N' AND ((a.Id = '" + txtPesquisa.Text + "') OR (a.Nome like '%" + txtPesquisa.Text + "%'));", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvFuncionario.DataSource = ds;
                    dgvFuncionario.DataMember = ds.Tables[0].TableName;
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
            else if (rdoTodos.Checked == true)
            {
                try
                {
                    con.OpenConn();

                    cmd = new MySqlCommand("SELECT a.ID, a.NOME, A.RG, a.CPF, a.DTNASC, a.ENDERECO, a.NUMENDERECO, a.BAIRRO, a.DTREGISTRO, a.ATIVO, b.DESCRICAO, a.LOGIN, a.SENHA " +
                        "FROM FUNCIONARIO a LEFT JOIN GRUPO_USUARIO b ON a.GRUPO_USU = b.ID " +
                        "WHERE a.Id = '" + txtPesquisa.Text + "' OR a.Nome like '%" + txtPesquisa.Text + "%';", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvFuncionario.DataSource = ds;
                    dgvFuncionario.DataMember = ds.Tables[0].TableName;
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
        private void FrmFuncionario_KeyDown(object sender, KeyEventArgs e)
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

        private void tsbtnAddFuncionario_Click(object sender, EventArgs e)
        {
            rdoAtivo.Enabled = false;
            rdoInativo.Enabled = false;
            rdoTodos.Enabled = false;
            txtPesquisa.Enabled = false;
            dgvFuncionario.Enabled = false;
            tsbtnAddFuncionario.Enabled = false;
            tsbtnEditFuncionario.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
            txtNome.Enabled = true;
            mtxRG.Enabled = true;
            mtxCPF.Enabled = true;
            mtxDtNasc.Enabled = true;
            txtEnd.Enabled = true;
            txtNumEnd.Enabled = true;
            txtBairro.Enabled = true;
            gpUsuario.Enabled = true;
            chkAtivo.Enabled = true;

            txtIdFuncionario.Clear();
            txtNome.Clear();
            mtxRG.Clear();
            mtxCPF.Clear();
            mtxDtNasc.Clear();
            txtEnd.Clear();
            txtNumEnd.Clear();
            txtBairro.Clear();
            txtSenha.Clear();
            txtLogin.Clear();

            tcFuncionarios.SelectTab(tpDados);
        }

        private void tsbtnEditFuncionario_Click(object sender, EventArgs e)
        {
            rdoAtivo.Enabled = false;
            rdoInativo.Enabled = false;
            rdoTodos.Enabled = false;
            txtPesquisa.Enabled = false;
            dgvFuncionario.Enabled = false;
            tsbtnAddFuncionario.Enabled = false;
            tsbtnEditFuncionario.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
            txtNome.Enabled = true;
            mtxRG.Enabled = true;
            mtxCPF.Enabled = true;
            mtxDtNasc.Enabled = true;
            txtEnd.Enabled = true;
            txtNumEnd.Enabled = true;
            txtBairro.Enabled = true;
            gpUsuario.Enabled = true;
            chkAtivo.Enabled = true;

            if (tcFuncionarios.SelectedIndex == 0)
            {
                tcFuncionarios.SelectTab(tpDados);
            }
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            rdoAtivo.Enabled = true;
            rdoInativo.Enabled = true;
            rdoTodos.Enabled = true;
            txtPesquisa.Enabled = true;
            dgvFuncionario.Enabled = true;
            tsbtnAddFuncionario.Enabled = true;
            tsbtnEditFuncionario.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;
            txtNome.Enabled = false;
            mtxRG.Enabled = false;
            mtxCPF.Enabled = false;
            mtxDtNasc.Enabled = false;
            txtEnd.Enabled = false;
            txtNumEnd.Enabled = false;
            txtBairro.Enabled = false;
            gpUsuario.Enabled = false;

            tcFuncionarios.SelectTab(tpFuncionario);
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;
            int idGpUsu;
            DateTime dtRegistro;

            ativo = (chkAtivo.Checked == true ? "S" : "N");

            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Nome não preenchido. Por favor, verifique!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT ID FROM GRUPO_USUARIO WHERE DESCRICAO = '" + cbGpUsu.Text + "';", con.query);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                idGpUsu = int.Parse(dr[0].ToString());
                cmd.Dispose();
                con.CloseConn();

                con.OpenConn();

                if (txtIdFuncionario.Text.Length == 0)
                {
                    cmd = new MySqlCommand("INSERT INTO FUNCIONARIO (NOME, RG, CPF, DtNasc, endereco, numEndereco, bairro, DtRegistro, grupo_usu, login, senha, ativo) " +
                    "VALUES ('" + txtNome.Text + "', @rg, @cpf, @dtNasc, '" + txtEnd.Text + "', '" + txtNumEnd.Text + "', '" + txtBairro.Text + "', @dtRegistro, " +
                    "@grupo_usu, @login, @senha, '" + ativo + "');", con.query);
                }
                else if (txtIdFuncionario.Text.Length != 0)
                {
                    cmd = new MySqlCommand("UPDATE FUNCIONARIO SET NOME = '" + txtNome.Text + "', RG = @RG, CPF = @CPF, DtNasc = @DTNASC, endereco = '" + txtEnd.Text + "', " +
                        "numEndereco = '" + txtNumEnd.Text + "', bairro = '" + txtBairro.Text + "', grupo_usu = @GRUPO_USU, login = @LOGIN, senha = @SENHA, ativo = '" + ativo + "' " +
                        "WHERE ID = '" + txtIdFuncionario.Text + "'", con.query);
                }
                

                cmd.Parameters.AddWithValue("@rg", mtxRG.Text.Replace(".", "").Replace("-", ""));
                cmd.Parameters.AddWithValue("@cpf", mtxCPF.Text.Replace(".", "").Replace("-", ""));
                cmd.Parameters.AddWithValue("@grupo_usu", idGpUsu);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                cmd.Parameters.AddWithValue("@dtNasc", DateTime.Parse(mtxDtNasc.Text));
                cmd.Parameters.AddWithValue("@dtRegistro", dtRegistro = DateTime.Now);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Consulta();

                rdoAtivo.Enabled = true;
                rdoInativo.Enabled = true;
                rdoTodos.Enabled = true;
                txtPesquisa.Enabled = true;
                dgvFuncionario.Enabled = true;
                tsbtnAddFuncionario.Enabled = true;
                tsbtnEditFuncionario.Enabled = true;
                tsbtnSalvar.Enabled = false;
                tsbtnCancelar.Enabled = false;
                txtNome.Enabled = false;
                mtxRG.Enabled = false;
                mtxCPF.Enabled = false;
                mtxDtNasc.Enabled = false;
                txtEnd.Enabled = false;
                txtNumEnd.Enabled = false;
                txtBairro.Enabled = false;
                gpUsuario.Enabled = false;

                tcFuncionarios.SelectTab(tpFuncionario);
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

        private void dgvFuncionario_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string ativo;

            DataGridViewRow row = dgvFuncionario.Rows[e.RowIndex];
            if (row != null)
            {
                txtIdFuncionario.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                mtxRG.Text = row.Cells[2].Value.ToString();
                mtxCPF.Text = row.Cells[3].Value.ToString();
                mtxDtNasc.Text = row.Cells[4].Value.ToString();
                txtEnd.Text = row.Cells[5].Value.ToString();
                txtNumEnd.Text = row.Cells[6].Value.ToString();
                txtBairro.Text = row.Cells[7].Value.ToString();
                ativo = row.Cells[9].Value.ToString();
                cbGpUsu.Text = row.Cells[10].Value.ToString();
                txtLogin.Text = row.Cells[11].Value.ToString();
                txtSenha.Text = row.Cells[12].Value.ToString();

                chkAtivo.Checked = (ativo == "S" ? true : false);
            }
        }
    }
}
