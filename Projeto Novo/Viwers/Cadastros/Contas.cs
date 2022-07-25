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
            // Muda para a tabpage Dados 
            if (tcContas.SelectedIndex == 0)
            {
                tcContas.SelectedTab = tpDadosConta;
            }

            // Habilita e desabilita botoes e filtros.
            tsbtnAddConta.Enabled = false;
            tsbtnEditConta.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
            txtPesquisa.Enabled = false;
            dgvContas.Enabled = false;
            rdoTodos.Enabled = false;
            rdoAtivo.Enabled = false;
            rdoInativo.Enabled = false;
            txtDescricao.Enabled = true;
            chkAtivo.Enabled = true;
            chkBanco.Enabled = true;

            txtIdConta.Clear();
            txtDescricao.Clear();
            chkAtivo.Checked = true;
            chkBanco.Checked = false;
        }


        private void tsbtnEditConta_Click(object sender, EventArgs e)
        {
            // Muda para a tabpage Dados 
            if (tcContas.SelectedIndex == 0)
            {
                tcContas.SelectedTab = tpDadosConta;
            }

            // Habilita e desabilita botoes e filtros.
            tsbtnAddConta.Enabled = false;
            tsbtnEditConta.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;
            txtPesquisa.Enabled = false;
            dgvContas.Enabled = false;
            rdoTodos.Enabled = false;
            rdoAtivo.Enabled = false;
            rdoInativo.Enabled = false;
            txtDescricao.Enabled = true;
            chkAtivo.Enabled = true;
            chkBanco.Enabled = true;
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            char ativo, banco;

            if (txtDescricao.Text.Length == 0)
            {
                MessageBox.Show("Por favor, insira uma descrição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Operador ternário. Substitiu os IFs
            ativo = (chkAtivo.Checked == true ? 'S' : 'N');
            banco = (chkBanco.Checked == true ? 'S' : 'N');

            try
            {
                con.OpenConn();

                if (txtIdConta.Text.Length == 0)
                {
                    cmd = new MySqlCommand("INSERT INTO CONTA (DESCRICAO, ATIVO, BANCO) " +
                "VALUES ('" + txtDescricao.Text + "', '" + ativo + "', '" + banco + "')", con.query);

                }
                else if (txtIdConta.Text.Length != 0)
                {
                    cmd = new MySqlCommand("UPDATE CONTA SET DESCRICAO = '" + txtDescricao.Text + "', ATIVO = '" + ativo + "', " +
                    "BANCO = '" + banco + "' WHERE ID = '" + txtIdConta.Text + "';", con.query);
                }

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Cadastro salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Consulta();

                // Habilita e desabilita botoes e filtros.
                tsbtnAddConta.Enabled = true;
                tsbtnEditConta.Enabled = true;
                tsbtnSalvar.Enabled = false;
                tsbtnCancelar.Enabled = false;
                txtPesquisa.Enabled = true;
                dgvContas.Enabled = true;
                rdoTodos.Enabled = true;
                rdoAtivo.Enabled = true;
                rdoInativo.Enabled = true;
                txtDescricao.Enabled = false;
                chkAtivo.Enabled = false;
                chkBanco.Enabled = false;

                if (tcContas.SelectedIndex != 0)
                {
                    tcContas.SelectedTab = tpConta;
                }
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
            this.Consulta();

            // Habilita e desabilita botoes e filtros.
            tsbtnAddConta.Enabled = true;
            tsbtnEditConta.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;
            txtPesquisa.Enabled = true;
            dgvContas.Enabled = true;
            rdoTodos.Enabled = true;
            rdoAtivo.Enabled = true;
            rdoInativo.Enabled = true;
            txtDescricao.Enabled = false;
            chkAtivo.Enabled = false;
            chkBanco.Enabled = false;

            if (tcContas.SelectedIndex != 0)
            {
                tcContas.SelectedTab = tpConta;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void rdoTodos_CheckedChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void rdoAtivo_CheckedChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void rdoInativo_CheckedChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }

        private void dgvContas_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            string ativo, conta;

            DataGridViewRow row = dgvContas.Rows[e.RowIndex];
            if (row != null)
            {
                txtIdConta.Text = row.Cells[0].Value.ToString();
                txtDescricao.Text = row.Cells[1].Value.ToString();
                ativo = row.Cells[2].Value.ToString();
                conta = row.Cells[3].Value.ToString();

                //Operador ternário. Substitiu os IFs
                chkAtivo.Checked = (ativo == "S" ? true : false);
                chkBanco.Checked = (conta == "S" ? true : false);

                /*if (ativo == "S")
                {
                    chkAtivo.Checked = true;
                }
                else if (ativo == "N")
                {
                    chkAtivo.Checked = false;
                }

                if (conta == "S")
                {
                    chkBanco.Checked = true;
                }
                else if (conta == "N")
                {
                    chkBanco.Checked = false;
                }*/
            }
        }
    }
}
