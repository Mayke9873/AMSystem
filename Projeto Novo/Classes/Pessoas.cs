using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Novo
{
    internal class Pessoas
    {
        MySqlCommand cmd;
        Conexao con = new Conexao();
        FrmCliente cliente = new FrmCliente();
        FrmFornecedor fornecedor = new FrmFornecedor();
        FrmFuncionario funcionario = new FrmFuncionario();

        int id;
        string nome, rg, cpfCnpj, endereco, numEndereco, bairro, tipo, ativo;
        DateTime dtNasc, dtRegistro;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string CpfCnpj { get => cpfCnpj; set => cpfCnpj = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string NumEndereco { get => numEndereco; set => numEndereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Ativo { get => ativo; set => ativo = value; }
        public DateTime DtNasc { get => dtNasc; set => dtNasc = value; }
        public DateTime DtRegistro { get => dtRegistro; set => dtRegistro = value; }

        public void CadastraCliente ()
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("INSERT INTO CLIENTE (NOME, RG, CPFCNPJ, DTNASC, ENDERECO, NUMENDERECO, BAIRRO, DTREGISTRO, TIPO, ATIVO) VALUES " +
                    "(@NOME, @RG, @cpfCnpj, @dtNasc, @ENDERECO, @numEndereco, @BAIRRO, @dtRegistro, @TIPO, @ATIVO);",con.query);

                cmd.Parameters.AddWithValue("@NOME", nome);
                cmd.Parameters.AddWithValue("@RG", rg);
                cmd.Parameters.AddWithValue("@cpfCnpj", cpfCnpj);
                cmd.Parameters.AddWithValue("@ENDERECO", endereco);
                cmd.Parameters.AddWithValue("@numEndereco", numEndereco);
                cmd.Parameters.AddWithValue("@BAIRRO", bairro);
                cmd.Parameters.AddWithValue("@dtRegistro", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@TIPO", tipo);
                cmd.Parameters.AddWithValue("@ATIVO", ativo);

                if (DtNasc == DateTime.Parse("0001-01-01"))
                {
                    cmd.Parameters.AddWithValue("@dtNasc", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@dtNasc", DtNasc);
                }

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void EditaCliente ()
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("UPDATE CLIENTE SET NOME = @NOME, RG = @RG, CPFCNPJ = @cpfCnpj, DTNASC = @dtNasc, ENDERECO = @ENDERECO, NUMENDERECO = @numEndereco, " +
                    "BAIRRO = @BAIRRO, TIPO = @TIPO, ATIVO = @ATIVO WHERE ID = " + Id + ";", con.query);

                cmd.Parameters.AddWithValue("@NOME", nome);
                cmd.Parameters.AddWithValue("@RG", rg);
                cmd.Parameters.AddWithValue("@cpfCnpj", cpfCnpj);
                cmd.Parameters.AddWithValue("@ENDERECO", endereco);
                cmd.Parameters.AddWithValue("@numEndereco", numEndereco);
                cmd.Parameters.AddWithValue("@BAIRRO", bairro);
                cmd.Parameters.AddWithValue("@TIPO", tipo);
                cmd.Parameters.AddWithValue("@ATIVO", ativo);

                if (DtNasc == DateTime.Parse("0001-01-01"))
                {
                    cmd.Parameters.AddWithValue("@dtNasc", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@dtNasc", DtNasc);
                }

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
