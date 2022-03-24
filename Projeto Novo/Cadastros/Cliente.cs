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

            try
            {
                con.OpenConn();
                sql = "SELECT Id, Nome, RG, CpfCnpj, dtnasc, Endereco, numendereco, Bairro, dtregistro, Tipo, Ativo" +
                " FROM CLIENTE WHERE ativo = 'S';";

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
            finally
            {
                con.CloseConn();
            }
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

            txtNomeCli.Enabled = true;
            mtxRG.Enabled = true;
            mtxCpfCnpj.Enabled = true;
            mtxDtNasc.Enabled = true;
            txtEnderecoCli.Enabled = true;
            txtNumEndCli.Enabled = true;
            txtBairroCli.Enabled = true;
            chkAtivo.Enabled = true;
            grpTpCliente.Enabled = true;

            txtNomeCli.Clear();
            mtxRG.Clear();
            mtxCpfCnpj.Clear();
            mtxDtNasc.Clear();
            txtEnderecoCli.Clear();
            txtNumEndCli.Clear();
            txtBairroCli.Clear();
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;
            string tipoCli;
            DateTime dtRegistro;
            string rg = mtxRG.Text;
            string cpfCnpj = mtxCpfCnpj.Text;

            //retira mascara das strings
            rg = rg.Replace(".", "").Replace("-", "");
            cpfCnpj = cpfCnpj.Replace(".", "").Replace("-", "");

            if (txtNomeCli.Text.Length == 0)
            {
                MessageBox.Show("Campo nome não preenchido, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkAtivo.Checked == true)
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
                " '" + txtBairroCli.Text + "', @dtRegistro, '" + tipoCli + "', '" + ativo + "');";

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


                sql = "SELECT Id, Nome, RG, CpfCnpj, dtnasc, Endereco, numendereco, Bairro, dtregistro, Tipo, Ativo" +
                " FROM CLIENTE WHERE ativo = 'S';";
                //sql = "SELECT Id, Nome, RG, CpfCnpj as 'CPF ou CNPJ' , dtnasc as Nascimento, Endereco, numendereco as Nº, Bairro, dtregistro as 'Dt Registro', Tipo, Ativo" +
                //" FROM CLIENTE WHERE ativo = 'S';";

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

                txtNomeCli.Enabled = false;
                mtxRG.Enabled = false;
                mtxCpfCnpj.Enabled = false;
                mtxDtNasc.Enabled = false;
                txtEnderecoCli.Enabled = false;
                txtNumEndCli.Enabled = false;
                txtBairroCli.Enabled = false;
                chkAtivo.Enabled = false;
                grpTpCliente.Enabled = false;

                dgvCliente.CurrentCell = dgvCliente.Rows[dgvCliente.Rows.Count - 1].Cells[0];
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


        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            tcClientes.SelectTab(tpCliente); //muda para a tabpage indicada.

            tsbtnAddCliente.Enabled = true;
            tsbtnEditCliente.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;

            txtNomeCli.Enabled = false;
            mtxRG.Enabled = false;
            mtxCpfCnpj.Enabled = false;
            mtxDtNasc.Enabled = false;
            txtEnderecoCli.Enabled = false;
            txtNumEndCli.Enabled = false;
            txtBairroCli.Enabled = false;
            chkAtivo.Enabled = false;
            grpTpCliente.Enabled = false;
        }

        private void dgvCliente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCliente.Rows[e.RowIndex];
            txtIdCli.Text = row.Cells[0].Value.ToString();
            txtNomeCli.Text = row.Cells[1].Value.ToString();
            mtxRG.Text = row.Cells[2].Value.ToString();
            mtxCpfCnpj.Text = row.Cells[3].Value.ToString();
            mtxDtNasc.Text = row.Cells[4].Value.ToString();
            txtEnderecoCli.Text = row.Cells[5].Value.ToString();
            txtNumEndCli.Text = row.Cells[6].Value.ToString();
            txtBairroCli.Text = row.Cells[7].Value.ToString();
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
