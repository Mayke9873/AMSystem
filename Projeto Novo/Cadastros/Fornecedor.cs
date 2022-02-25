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
    public partial class FrmFornecedor : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmFornecedor()
        {
            InitializeComponent();


            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT * FROM FORNECEDOR;", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvFornecedor.DataSource = ds;
                dgvFornecedor.DataMember = ds.Tables[0].TableName;
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

        private void FrmFornecedor_KeyDown(object sender, KeyEventArgs e)
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

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAddFornecedor_Click(object sender, EventArgs e)
        {
            tcFornecedores.SelectTab(tpDados);

            tsbtnAddFornecedor.Enabled = false;
            tsbtnEditFornecedor.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
        }
        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            char ativo;
            DateTime dtRegistro;
            string cnpj = mtxCNPJ.Text;

            cnpj = cnpj.Replace(".", "").Replace("-", "");

            if (txtNomeFornecedor.Text.Length == 0)
            {
                MessageBox.Show("Campo nome não preenchido, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return;
            }

            if (rdoAtivo.Checked == true)
            {
                ativo = 'S';
            }
            else
            {
                ativo = 'N';
            }

            try
            {
                con.OpenConn();

                cmd = new MySqlCommand("INSERT INTO FORNECEDOR (NOME, IE, CNPJ, ENDERECO, numENDERECO, BAIRRO, ATIVO, DtREGISTRO)" +
                    " VALUES ('" + txtNomeFornecedor.Text + "', '" + txtIe.Text + "', @cnpj, '" + txtEndFornecedor.Text + "', '" + txtNumEndFornecedor.Text + "', " +
                    "'" + txtBairroFornecedor.Text + "', '" + ativo + "', @DtRegistro);", con.query);

                cmd.Parameters.AddWithValue("@DtRegistro", dtRegistro = DateTime.Now);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Dados gravado com sucesso!", "SQS System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd = new MySqlCommand("SELECT * FROM FORNECEDOR;", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //DataSet ds

                tsbtnAddFornecedor.Enabled = true;
                tsbtnEditFornecedor.Enabled = true;
                tsbtnSalvar.Enabled = false;
                tsbtnCancelar.Enabled = false;

                tcFornecedores.SelectTab(tpFornecedor);
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

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            tcFornecedores.SelectTab(tpFornecedor);

            tsbtnAddFornecedor.Enabled = true;
            tsbtnEditFornecedor.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;
        }
    }
}
