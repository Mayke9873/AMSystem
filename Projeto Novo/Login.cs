using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Projeto_Novo
{
    public partial class FrmLogin : Form
    {
        //Borda arredondada
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Login
            if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("Usuário não informado, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }
            else if (txtSenha.Text.Length == 0)
            {
                MessageBox.Show("Senha não informada, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
                return;
            }

            // Aqui vai o Login
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT LOGIN, SENHA FROM FUNCIONARIO WHERE LOGIN = '" + txtUsuario.Text + "' AND SENHA = '" + txtSenha.Text + "';", con.query);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    txtUsuario.Focus();
                    MessageBox.Show("Usuário ou senha inválida, por favor verifique!");
                }
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}