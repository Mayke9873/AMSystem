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
    public partial class FrmFuncionario : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmFuncionario()
        {
            InitializeComponent();

            try
            {
                con.OpenConn();

                cmd = new MySqlCommand("Select * from funcionario where ativo = 'S';", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvFuncionario.DataSource = ds;
                dgvFuncionario.DataMember = ds.Tables[0].TableName;
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
        private void FrmFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: 
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(ActiveControl, !e.Shift, true, true, true);
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

        private void tsbtnAddFuncionario_Click(object sender, EventArgs e)
        {
            tcFuncionarios.SelectTab(tpDados);

            tsbtnAddFuncionario.Enabled = false;
            tsbtnEditFuncionario.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            tsbtnAddFuncionario.Enabled = true;
            tsbtnEditFuncionario.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;

            tcFuncionarios.SelectTab(tpFuncionario);
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;
            DateTime dtRegistro;
            string rg = mtxRG.Text;
            string cpf = mtxCPF.Text;

            rg = rg.Replace(".", "").Replace("-", "");
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (rdoAtivo.Checked == true)
            {
                ativo = "S";
            }
            else
            {
                ativo = "N";
            }

            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Nome não preenchido. Por favor, verifique!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("INSERT INTO FUNCIONARIO (NOME, RG, CPF, DtNasc, endereco, numEndereco, bairro, DtRegistro, ativo) VALUES " +
                    "('"+ txtNome.Text +"', @rg, @cpf, @dtNasc, '"+ txtEnd.Text+"', '"+ txtNumEnd.Text +"', '"+ txtBairro.Text +"', @dtRegistro, " +
                    "'"+ ativo +"');", con.query);

                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@dtNasc", DateTime.Parse(mtxDtNasc.Text));
                cmd.Parameters.AddWithValue("@dtRegistro", dtRegistro = DateTime.Now);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                cmd = new MySqlCommand("SELECT * FROM FUNCIONARIO WHERE ATIVO = 'S';", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvFuncionario.DataSource = ds;
                dgvFuncionario.DataMember = ds.Tables[0].TableName;

                tsbtnAddFuncionario.Enabled = true;
                tsbtnEditFuncionario.Enabled = true;
                tsbtnSalvar.Enabled = false;
                tsbtnCancelar.Enabled = false;

                tcFuncionarios.SelectTab(tpFuncionario);
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
    }
}
