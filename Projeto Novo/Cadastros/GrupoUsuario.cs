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
    public partial class FrmGrupoUsuario : Form
    {

        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmGrupoUsuario()
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
                    cmd = new MySqlCommand("SELECT ID, DESCRICAO, ATIVO FROM GRUPO_USUARIO WHERE DESCRICAO LIKE '%" + txtPesquisa.Text + "%' or ID = '" + txtPesquisa.Text + "';", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvGpUsuarios.DataSource = ds;
                    dgvGpUsuarios.DataMember = ds.Tables[0].TableName;
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
                    cmd = new MySqlCommand("SELECT ID, DESCRICAO, ATIVO FROM GRUPO_USUARIO WHERE ATIVO = 'S' AND ((DESCRICAO LIKE '%" + txtPesquisa.Text + "%') OR (ID = '" + txtPesquisa.Text + "'));", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvGpUsuarios.DataSource = ds;
                    dgvGpUsuarios.DataMember = ds.Tables[0].TableName;
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
                    cmd = new MySqlCommand("SELECT ID, DESCRICAO, ATIVO FROM GRUPO_USUARIO WHERE ATIVO = 'N' AND ((DESCRICAO LIKE '%" + txtPesquisa.Text + "%') OR (ID = '" + txtPesquisa.Text + "'));", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvGpUsuarios.DataSource = ds;
                    dgvGpUsuarios.DataMember = ds.Tables[0].TableName;
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

        private void FrmGrupoUsuario_KeyDown(object sender, KeyEventArgs e)
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

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;

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
                if (txtIdGpUsuario.Text.Length == 0)
                {
                    cmd = new MySqlCommand("INSERT INTO GRUPO_USUARIO (DESCRICAO, ATIVO) VALUES" +
                    "('" + txtDescTipoUsu.Text + "', '" + ativo + "');", con.query);
                }
                else if (txtIdGpUsuario.Text.Length != 0)
                {
                    cmd = new MySqlCommand("UPDATE GRUPO_USUARIO SET DESCRICAO = '" + txtDescTipoUsu.Text + "', ATIVO = '" + ativo + "'" +
                        " WHERE ID = '" + txtIdGpUsuario.Text + "';", con.query);
                }

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Consulta();

                txtPesquisa.Enabled = true;
                rdoTodos.Enabled = true;
                rdoAtivo.Enabled = true;
                rdoInativo.Enabled = true;
                tsbtnAddGrupoUSu.Enabled = true;
                tsbtnEditGrupoUsu.Enabled = true;
                tsbtnSalvar.Enabled = false;
                tsbtnCancelar.Enabled = false;
                txtDescTipoUsu.Enabled = false;
                chkAtivo.Enabled = false;
                dgvGpUsuarios.Enabled = true;

                tcGrupoUsuarios.SelectTab(tpGrupoUsuario);
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

        private void tsbtnAddGrupoUSu_Click(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = false;
            rdoTodos.Enabled = false;
            rdoAtivo.Enabled = false;
            rdoInativo.Enabled = false;
            tsbtnAddGrupoUSu.Enabled = false;
            tsbtnEditGrupoUsu.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
            txtDescTipoUsu.Enabled = true;
            chkAtivo.Enabled = true;
            dgvGpUsuarios.Enabled = false;

            txtIdGpUsuario.Clear();
            txtDescTipoUsu.Clear();
            chkAtivo.Checked = true;

            tcGrupoUsuarios.SelectTab(tpDadosUsu);
        }

        private void tsbtnEditGrupoUsu_Click(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = false;
            rdoTodos.Enabled = false;
            rdoAtivo.Enabled = false;
            rdoInativo.Enabled = false;
            tsbtnAddGrupoUSu.Enabled = false;
            tsbtnEditGrupoUsu.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
            txtDescTipoUsu.Enabled = true;
            chkAtivo.Enabled = true;
            dgvGpUsuarios.Enabled = false;

            // Não mudar a aba se index da tabpage <> 0
            if (tcGrupoUsuarios.SelectedIndex == 0)
            {
                tcGrupoUsuarios.SelectTab(tpDadosUsu);
            }
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = true;
            rdoTodos.Enabled = true;
            rdoAtivo.Enabled = true;
            rdoInativo.Enabled = true;
            tsbtnAddGrupoUSu.Enabled = true;
            tsbtnEditGrupoUsu.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;
            txtDescTipoUsu.Enabled = false;
            chkAtivo.Enabled = false;
            dgvGpUsuarios.Enabled = true;

            tcGrupoUsuarios.SelectTab(tpGrupoUsuario);
        }

        private void dgvGpUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string ativo;

            DataGridViewRow row = dgvGpUsuarios.Rows[e.RowIndex];
            if (row != null)
            {
                txtIdGpUsuario.Text = row.Cells[0].Value.ToString();
                txtDescTipoUsu.Text = row.Cells[1].Value.ToString();
                ativo = row.Cells[2].Value.ToString();

                if (ativo == "S") 
                {
                    chkAtivo.Checked = true;
                }
                else if(ativo == "N")
                {
                    chkAtivo.Checked = false;
                }
            }
        }
    }
}
