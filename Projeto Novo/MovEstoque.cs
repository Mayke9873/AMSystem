using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Novo
{
    internal class MovEstoque
    {
        MySqlCommand cmd;
        Conexao con = new Conexao();

        public int idProduto { get; set; }
        public decimal quantidade { get; set; }
        public int idUsuario { get;  set; }
        public int idFornecedor { get; set; }
        public char tipoMov { get; set; }

        public void movEstoque ()
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("INSERT INTO MOVESTOQUE (idProduto, quantidade, dataMov, idUsuario ,idFornecedor, tipoMov) VALUES " +
                    "(@idProduto, @quantidade, @dataMov, @idUsuario, @idFornecedor, @tipoMov);", con.query);

                cmd.Parameters.AddWithValue("@idProduto", idProduto);
                cmd.Parameters.AddWithValue("@dataMov", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@tipoMov", tipoMov);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);

                if (tipoMov == 'C')
                {
                    cmd.Parameters.AddWithValue("@idUsuario", null);
                    cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);
                }
                else if (tipoMov == 'V')
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@idFornecedor", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@idUsuario", null);
                    cmd.Parameters.AddWithValue("@idFornecedor", null);
                }

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CloseConn();
            }
        }

        public void atualizaEstoque()
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("UPDATE PRODUTO SET ESTOQUE = (select sum(quantidade) from movEstoque where idproduto = @idproduto) where id = @idproduto;", con.query);
                cmd.Parameters.AddWithValue("@idproduto", idProduto);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CloseConn();
            }
        }
    }
}
