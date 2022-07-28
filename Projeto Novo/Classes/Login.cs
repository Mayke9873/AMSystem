using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Novo
{
    class Login
    {
        FrmLogin FrmLogin = new FrmLogin();
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public string usuario { get; set; }

        public string senha { get; set; }

        public DialogResult DialogResult { get; private set; }

        public void efetuarLogin()
        {
            // Verifica se preenchido usuario e senha.
            if (usuario.Length == 0)
            {
                MessageBox.Show("Usuário não informado, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin.txtUsuario.Focus();
                return;
            }
            else if (senha.Length == 0)
            {
                MessageBox.Show("Senha não informada, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin.txtSenha.Focus();
                return;
            }

            // Validando login
            try
            {
                con.OpenConn();

                cmd = new MySqlCommand("SELECT NOME, LOGIN, SENHA FROM FUNCIONARIO WHERE LOGIN = @LOGIN AND SENHA = @SENHA;", con.query);

                cmd.Parameters.AddWithValue("@LOGIN", usuario);
                cmd.Parameters.AddWithValue("@SENHA", senha);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválida, por favor verifique!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "AM System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CloseConn();
            }
        }
    }
}
