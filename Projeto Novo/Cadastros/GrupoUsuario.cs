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

            try
            {
                con.OpenConn();

                cmd = new MySqlCommand("SELECT * FROM GRUPO_USUARIO", con.query);
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

        private void tsbtnAddGrupoUSu_Click(object sender, EventArgs e)
        {
            tsbtnAddGrupoUSu.Enabled = false;
            tsbtnEditGrupoUsu.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;

            tcGrupoUsuarios.SelectTab(tpDadosUsu);
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            tsbtnAddGrupoUSu.Enabled = true;
            tsbtnEditGrupoUsu.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;

            tcGrupoUsuarios.SelectTab(tpGrupoUsuario);
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;

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
                //salvar no banco aqui
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
