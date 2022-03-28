using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Novo
{
    internal class Conexao
    {
        string conn = "SERVER = localhost; DATABASE = projeto_db; UID = root; PWP = ; convert zero datetime = True;";
        public MySqlConnection query = null;

        public void OpenConn()
        {
            try
            {
                query = new MySqlConnection(conn);
                query.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConn()
        {
            try
            {
                query = new MySqlConnection(conn);
                query.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
