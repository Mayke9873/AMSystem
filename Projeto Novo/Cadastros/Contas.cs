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

namespace Projeto_Novo.Cadastros
{
    public partial class FrmContas : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmContas()
        {
            InitializeComponent();

            this.Consulta();
        }

        private void Consulta()
        {
            if (rdoAtivo.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT Id, Descricao, Ativo, Banco FROM CONTA" +
                        " WHERE ATIVO = 'S' AND ((ID = '" + txtPesquisa.Text + "') OR (DESCRICAO LIKE '%" + txtPesquisa.Text + "%'));", con.query);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvContas.DataSource = ds;
                    dgvContas.DataMember = ds.Tables[0].TableName;
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
            else if (rdoInativo.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT Id, Descricao, Ativo, Banco FROM CONTA" +
                        " WHERE ATIVO = 'N' AND ((ID = '" + txtPesquisa.Text + "') OR (DESCRICAO LIKE '%" + txtPesquisa.Text + "%'));", con.query);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvContas.DataSource = ds;
                    dgvContas.DataMember = ds.Tables[0].TableName;
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
            else if (rdoTodos.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT Id, Descricao, Ativo, Banco FROM CONTA" +
                        " WHERE ID = '" + txtPesquisa.Text + "' OR DESCRICAO LIKE '%" + txtPesquisa.Text + "%';", con.query);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvContas.DataSource = ds;
                    dgvContas.DataMember = ds.Tables[0].TableName;
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
        private void FrmContas_KeyDown(object sender, KeyEventArgs e)
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

        private void tsbtnAddConta_Click(object sender, EventArgs e)
        {
            tcContas.SelectedTab = tpDadosConta; // Muda para a tabpage especifica

            // Habilita e desabilita botoes.
            tsbtnAddConta.Enabled = false;
            tsbtnEditConta.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            char ativo;
            string banco = null;

            if (txtDescricao.Text.Length == 0)
            {
                MessageBox.Show("Por favor, insira uma descrição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkAtivo.Checked == true)
            {
                ativo = 'S';
            }
            else
            {
                ativo = 'N';
            }

            if (chkBanco.Checked == true)
            {
                banco = "S";
            }
            else
            {
                banco = "N";
            }

            try
            {
                con.OpenConn();

                if (txtIdUsuario.Text.Length == 0)
                {
                    cmd = new MySqlCommand("INSERT INTO CONTA (DESCRICAO, ATIVO, BANCO) " +
                "VALUES ('" + txtDescricao.Text + "', '" + ativo + "', '" + banco + "')", con.query);

                }
                else if (txtIdUsuario.Text.Length != 0)
                {
                    cmd = new MySqlCommand("UPDATE CONTA SET DESCRICAO = '" + txtDescricao.Text + "', ATIVO = '" + ativo + "', " +
                    BANCO = '" + banco + "' WHERE ID = '"+txtIdUsuario.Text+"';), con.query);
                }

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Consulta();

                tsbtnAddConta.Enabled = true;
                tsbtnEditConta.Enabled = true;
                tsbtnSalvar.Enabled = false;
                tsbtnCancelar.Enabled = false;

                tcContas.SelectedTab = tpConta;
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
            tsbtnAddConta.Enabled = true;
            tsbtnEditConta.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;

            tcContas.SelectTab(tpConta);
        }
    }
}
