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

            sql = "SELECT * FROM CLIENTE ORDER BY ID ASC";

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


        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo = null;
            string tipoCli = null;
            int ex = 0;

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

            if (rdoFisica.Checked == true)
            {
                tipoCli = "F";
            }
            else if (rdoJuridica.Checked == true)
            {
                tipoCli = "J";
            }


            sql = "INSERT INTO CLIENTE (NOME, RG, CPFCNPJ, DTNASC, ENDERECO, NUMENDERECO, BAIRRO, DTREGISTRO, " +
                "TIPO, ATIVO, EX) " +
                "VALUES ('"+ txtNomeCli.Text + "','" + mtxRG.Text +"','" + mtxCPF + "','" + mtxDtNasc.Text + "','" +
                " '" + txtEnderecoCli.Text + "','" + txtNumEndCli.Text + "','" + txtBairroCli.Text + "', '@dtRegisto', " +
                " '@tipo', '@ativo', @ex)";


            cmd.Parameters.AddWithValue("@dtRegistro", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@tipo", tipoCli);
            cmd.Parameters.AddWithValue("@ativo", ativo);
            cmd.Parameters.AddWithValue("@ex", ex);


            try
            {
                con.OpenConn();
                cmd = new MySqlCommand(sql, con.query);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            }
            catch (Exception exxe)
            {
                MessageBox.Show(exxe.Message);
            }
            finally
            {
                con.CloseConn();
            }


            MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.CloseConn();
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
