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

            cmd = new MySqlCommand("SELECT DESCRICAO FROM GRUPO_USUARIO;", con.query);

            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbGpUsu.DisplayMember = "DESCRICAO";
            cbGpUsu.DataSource = dt;
        }

        private void Consulta()
        {
            if (rdoAtivo.Checked == true)
            {
                try
                {
                    con.OpenConn();

                    cmd = new MySqlCommand("Select * from funcionario where ativo = 'S' AND ((Id = '" + txtPesquisa.Text + "') OR (Nome like '%" + txtPesquisa.Text + "%'));", con.query);
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

                    cmd = new MySqlCommand("Select * from funcionario where ativo = 'N' AND ((Id = '" + txtPesquisa.Text + "') OR (Nome like '%" + txtPesquisa.Text + "%'));", con.query);
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

                    cmd = new MySqlCommand("Select * from funcionario; WHERE Id = '" + txtPesquisa.Text + "' OR Nome like '%" + txtPesquisa.Text + "%';", con.query);
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

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAddFuncionario_Click(object sender, EventArgs e)
        {
            tcFuncionarios.SelectTab(tpDados);

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
            rdoAtivo.Enabled = true;
            rdoInativo.Enabled = true;

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
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
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
            rdoAtivo.Enabled = false;
            rdoInativo.Enabled = false;

            tcFuncionarios.SelectTab(tpFuncionario);
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;
            int idGpUsu;
            DateTime dtRegistro;

            if (chkAtivo.Checked == true)
            {
                ativo = "S";
            }
            else
            {
                ativo = "N";
            }

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
                cmd = new MySqlCommand("INSERT INTO FUNCIONARIO (NOME, RG, CPF, DtNasc, endereco, numEndereco, bairro, DtRegistro, grupo_usu, login, senha, ativo) " +
                    "VALUES ('"+ txtNome.Text +"', @rg, @cpf, @dtNasc, '"+ txtEnd.Text+"', '"+ txtNumEnd.Text +"', '"+ txtBairro.Text +"', @dtRegistro, " +
                    "@grupo_usu, @login, @senha, '"+ ativo +"');", con.query);

                cmd.Parameters.AddWithValue("@rg", mtxRG.Text.Replace(".", "").Replace("-", ""));
                cmd.Parameters.AddWithValue("@cpf", mtxCPF.Text.Replace(".", "").Replace("-", ""));
                cmd.Parameters.AddWithValue("@grupo_usu", idGpUsu);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                cmd.Parameters.AddWithValue("@dtNasc", DateTime.Parse(mtxDtNasc.Text));
                cmd.Parameters.AddWithValue("@dtRegistro", dtRegistro = DateTime.Now);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                this.Consulta();

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
    }
}
