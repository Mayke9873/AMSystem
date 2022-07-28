using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Novo
{
    internal class Conta
    {
        MySqlCommand cmd;
        Conexao con = new Conexao();

        int id;
        string descricao;
        char ativo, banco;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public char Ativo { get => ativo; set => ativo = value; }
        public char Banco { get => banco; set => banco = value; }

        public void Inserir()
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("INSERT INTO CONTA (DESCRICAO, ATIVO, BANCO) " +
                "VALUES (@Descricao, @Ativo, @Banco)", con.query);

                cmd.Parameters.AddWithValue("@Descricao", Descricao);
                cmd.Parameters.AddWithValue("@Ativo", Ativo);
                cmd.Parameters.AddWithValue("@Banco", Banco);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
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

        public void Editar ()
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("UPDATE CONTA SET DESCRICAO = @Descricao, ATIVO = @Ativo, BANCO = @Banco WHERE ID = " + Id + ";", con.query);

                cmd.Parameters.AddWithValue("@Descricao", Descricao);
                cmd.Parameters.AddWithValue("@Ativo", Ativo);
                cmd.Parameters.AddWithValue("@Banco", Banco);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
