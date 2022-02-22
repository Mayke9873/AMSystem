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

            sql = "SELECT id, nome, rg, cpfcnpj, dtnasc, endereco, numendereco, bairro, dtregistro, tipo, ativo" +
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
            string ativo = null;
            string tipoCli = null;
            //int ex = 0;

            if (txtNomeCli.Text.Length == 0)
            {
                MessageBox.Show("Campo nome não preenchido, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (rdoCliAtivo.Checked == true)
            {
                ativo = "S";
            }
            else if (rdoCliInativo.Checked == true)
            {
                ativo = "N";
            }
            else
            {
                ativo = "S";
            }

            if (rdoFisica.Checked == true)
            {
                tipoCli = "F";
            }
            else if (rdoJuridica.Checked == true)
            {
                tipoCli = "J";
            }
            else
            {
                tipoCli = "F";
            }

            mtxRG.Text.Replace(".", "").Replace("-", "").Trim();
            mtxCPF.Text.Replace(".", "").Replace("-", "").Trim();

            sql = "INSERT INTO CLIENTE (NOME, RG, CPFCNPJ, DTNASC, ENDERECO, NUMENDERECO, BAIRRO, DTREGISTRO, " +
                "TIPO, ATIVO) " +
                "VALUES ('" + txtNomeCli.Text + "','" + mtxRG.Text + "','" + mtxCPF + "','" + mtxDtNasc.Text + "'," +
                " '" + txtEnderecoCli.Text + "','" + txtNumEndCli.Text + "','" + txtBairroCli.Text + "', '" + DateTime.Now.ToString() + "', " +
                " '" + tipoCli + "', '" + ativo + "')";

            try
            {
                con.OpenConn();
                cmd = new MySqlCommand(sql, con.query);
                //cmd.Parameters.AddWithValue("@ex", ex);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sql = "SELECT id, nome, rg, cpfcnpj, dtnasc, endereco, numendereco, bairro, dtregistro, tipo, ativo" +
                " FROM CLIENTE WHERE ativo = 'S'";

                con.OpenConn();
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

        private void tsbtnImprimir_Click(object sender, EventArgs e)
        {
            sql = "SELECT id, nome, rg, cpfcnpj, dtnasc, endereco, numendereco, bairro, dtregistro, tipo, ativo" +
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
    }
}
