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
    public partial class FrmCliente : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        public FrmCliente()
        {
            InitializeComponent();

            sql = "SELECT Id, Nome, RG, CpfCnpj as 'CPF ou CNPJ' , dtnasc as Nascimento, Endereco, numendereco as Nº, Bairro, dtregistro as 'Dt Registro', Tipo, Ativo" +
                " FROM CLIENTE WHERE ativo = 'S'";

            try
            {
                con.OpenConn();
                cmd = new MySqlCommand(sql, con.query);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvCliente.DataSource = ds;
                dgvCliente.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            con.CloseConn();
        }

        private void FrmCliente_KeyDown(object sender, KeyEventArgs e)
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

        private void tsbtnAddCliente_Click(object sender, EventArgs e)
        {
            tcClientes.SelectedTab = tpDados; //muda para a tabpage especifica.
            tsbtnAddCliente.Enabled = false;
            tsbtnEditCliente.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;
            string tipoCli;
            DateTime dtRegistro;
            string data = mtxDtNasc.Text;
            string rg = mtxRG.Text;
            string cpfCnpj = mtxCpfCnpj.Text;

            //Retira mascara dos valores.
            data = data.Replace("/", "");
            rg = rg.Replace(".", "").Replace("-", "");
            cpfCnpj = cpfCnpj.Replace(".", "").Replace("-", "");

            if (txtNomeCli.Text.Length == 0)
            {
                MessageBox.Show("Campo nome não preenchido, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (rdoCliAtivo.Checked == true)
            {
                ativo = "S";
            }
            else
            {
                ativo = "N";
            }

            if (rdoFisica.Checked == true)
            {
                tipoCli = "F";
            }
            else
            {
                tipoCli = "J";
            }

            sql = "INSERT INTO CLIENTE (NOME, RG, CPFCNPJ, DTNASC, ENDERECO, NUMENDERECO, BAIRRO, DTREGISTRO, " +
                "TIPO, ATIVO) " +
                "VALUES ('" + txtNomeCli.Text + "', @rg , @cpfCnpj , @dtNasc , '" + txtEnderecoCli.Text + "','" + txtNumEndCli.Text + "'," +
                " '" + txtBairroCli.Text + "', @dtRegistro, '" + tipoCli + "', '" + ativo + "')";

            try
            {
                con.OpenConn();
                cmd = new MySqlCommand(sql, con.query);

                //Adiciona os parametros a partir das variaveis.
                cmd.Parameters.AddWithValue("@dtRegistro", dtRegistro = DateTime.Now);
                cmd.Parameters.AddWithValue("@dtNasc", DateTime.Parse(mtxDtNasc.Text));
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@cpfCnpj", cpfCnpj);


                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sql = "SELECT Id, Nome, RG, CpfCnpj as 'CPF ou CNPJ' , dtnasc as Nascimento, Endereco, numendereco as Nº, Bairro, dtregistro as 'Dt Registro', Tipo, Ativo" +
                " FROM CLIENTE WHERE ativo = 'S'";

                cmd = new MySqlCommand(sql, con.query);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvCliente.DataSource = ds;
                dgvCliente.DataMember = ds.Tables[0].TableName;

                tcClientes.SelectedTab = tpCliente;

                tsbtnAddCliente.Enabled = true;
                tsbtnEditCliente.Enabled = true;
                tsbtnSalvar.Enabled = false;
                tsbtnCancelar.Enabled = false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
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

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            tcClientes.SelectedTab = tpCliente; //muda para a tabpage indicada.

            tsbtnAddCliente.Enabled = true;
            tsbtnEditCliente.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;
        }
    }
}
