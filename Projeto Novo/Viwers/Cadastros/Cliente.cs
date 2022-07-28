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

            this.Consulta();
        }

        private void Consulta()
        {
            if (rdoAtivo.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    sql = "SELECT Id, Nome, RG, CpfCnpj, dtnasc, Endereco, numendereco, Bairro, dtregistro, Tipo, Ativo" +
                    " FROM CLIENTE WHERE ativo = 'S' and ((Nome like '%" + txtPesquisa.Text + "%') or (Id like '%" + txtPesquisa.Text + "%'));";

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
            else if (rdoInativo.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    sql = "SELECT Id, Nome, RG, CpfCnpj, dtnasc, Endereco, numendereco, Bairro, dtregistro, Tipo, Ativo" +
                    " FROM CLIENTE WHERE ativo = 'N' and ((Nome like '%" + txtPesquisa.Text + "%') or (Id like '%" + txtPesquisa.Text + "%'));";

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
            else if (rdoTodos.Checked == true)
            {
                try
                {
                    con.OpenConn();
                    sql = "SELECT Id, Nome, RG, CpfCnpj, dtnasc, Endereco, numendereco, Bairro, dtregistro, Tipo, Ativo" +
                    " FROM CLIENTE where Nome like '%" + txtPesquisa.Text + "%' OR Id like '%" + txtPesquisa.Text + "%';";

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

            txtPesquisa.Enabled = false;
            txtNomeCli.Enabled = true;
            mtxRG.Enabled = true;
            mtxCpf.Enabled = true;
            mtxDtNasc.Enabled = true;
            txtEnderecoCli.Enabled = true;
            txtNumEndCli.Enabled = true;
            txtBairroCli.Enabled = true;
            chkAtivo.Enabled = true;
            grpTpCliente.Enabled = true;
            mtxRG.Enabled = true;
            dgvCliente.Enabled = false;
            dgvCliente.TabStop = false;

            chkAtivo.Checked = true;
            rdoFisica.Checked = true;

            txtIdCli.Clear();
            txtNomeCli.Clear();
            mtxRG.Clear();
            mtxCpf.Clear();
            mtxDtNasc.Clear();
            txtEnderecoCli.Clear();
            txtNumEndCli.Clear();
            txtBairroCli.Clear();
        }

        private void tsbtnSalvar_Click(object sender, EventArgs e)
        {
            string ativo;
            string tipoCli;

            if (txtNomeCli.Text.Length == 0)
            {
                MessageBox.Show("Campo nome não preenchido, por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Operador ternário. Substitui os IFs
            ativo = (chkAtivo.Checked == true ? "S" : "N");
            tipoCli = (rdoFisica.Checked == true ? "F" : "J");

            Pessoas pessoas = new Pessoas()
            {
                Nome = txtNomeCli.Text,
                Rg = mtxRG.Text,
                CpfCnpj = mtxCpf.Text.Replace(".", "").Replace("-", ""),
                Endereco = txtEnderecoCli.Text,
                NumEndereco = txtNumEndCli.Text,
                Bairro = txtBairroCli.Text,
                Tipo = tipoCli,
                Ativo = ativo
            };

            if (mtxDtNasc.MaskFull)
            {
                pessoas.DtNasc = DateTime.Parse(mtxDtNasc.Text);
            }

            if (txtIdCli.Text.Length == 0)
            {
                pessoas.CadastraCliente();
            }
            else
            {
                pessoas.Id = int.Parse(txtIdCli.Text);
                pessoas.EditaCliente();
            }

            this.Consulta();

            tcClientes.SelectedTab = tpCliente;

            tsbtnAddCliente.Enabled = true;
            tsbtnEditCliente.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;

            txtPesquisa.Enabled = true;
            txtNomeCli.Enabled = false;
            mtxRG.Enabled = false;
            mtxCpf.Enabled = false;
            mtxDtNasc.Enabled = false;
            txtEnderecoCli.Enabled = false;
            txtNumEndCli.Enabled = false;
            txtBairroCli.Enabled = false;
            chkAtivo.Enabled = false;
            grpTpCliente.Enabled = false;
            dgvCliente.Enabled = true;
            dgvCliente.TabStop = true;
        }


        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            tcClientes.SelectTab(tpCliente); //muda para a tabpage indicada.

            tsbtnAddCliente.Enabled = true;
            tsbtnEditCliente.Enabled = true;
            tsbtnSalvar.Enabled = false;
            tsbtnCancelar.Enabled = false;

            txtPesquisa.Enabled = true;
            txtNomeCli.Enabled = false;
            mtxRG.Enabled = false;
            mtxCpf.Enabled = false;
            mtxDtNasc.Enabled = false;
            txtEnderecoCli.Enabled = false;
            txtNumEndCli.Enabled = false;
            txtBairroCli.Enabled = false;
            chkAtivo.Enabled = false;
            grpTpCliente.Enabled = false;
            dgvCliente.Enabled = true;
            dgvCliente.TabStop = true;
        }
        private void tsbtnEditCliente_Click(object sender, EventArgs e)
        {
            tcClientes.SelectedTab = tpDados; //muda para a tabpage especifica.

            tsbtnAddCliente.Enabled = false;
            tsbtnEditCliente.Enabled = false;
            tsbtnSalvar.Enabled = true;
            tsbtnCancelar.Enabled = true;

            txtPesquisa.Enabled = false;
            txtNomeCli.Enabled = true;
            mtxRG.Enabled = true;
            mtxCpf.Enabled = true;
            mtxDtNasc.Enabled = true;
            txtEnderecoCli.Enabled = true;
            txtNumEndCli.Enabled = true;
            txtBairroCli.Enabled = true;
            chkAtivo.Enabled = true;
            grpTpCliente.Enabled = true;
            dgvCliente.Enabled = false;
            dgvCliente.TabStop = false;
        }

        private void dgvCliente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string tipo, ativo;

            //Outra forma de levar informação para os campos
            //txtIdCli.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();

            DataGridViewRow row = dgvCliente.Rows[e.RowIndex];
            txtIdCli.Text = row.Cells[0].Value.ToString();
            txtNomeCli.Text = row.Cells[1].Value.ToString();
            mtxRG.Text = row.Cells[2].Value.ToString();
            mtxCpf.Text = row.Cells[3].Value.ToString();
            mtxDtNasc.Text = row.Cells[4].Value.ToString();
            txtEnderecoCli.Text = row.Cells[5].Value.ToString();
            txtNumEndCli.Text = row.Cells[6].Value.ToString();
            txtBairroCli.Text = row.Cells[7].Value.ToString();

            ativo = row.Cells[10].Value.ToString();
            chkAtivo.Checked = (ativo == "S" ? true : false);

            tipo = row.Cells[9].Value.ToString();
            if (tipo == "F")
            {
                rdoFisica.Checked = true;
            }
            else if (tipo == "J")
            {
                rdoJuridica.Checked = true;
            }
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void rdoFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblRG.Text = "RG:";
            lblCPF.Text = "CPF:";
            mtxCpf.Mask = "###,###,###-##";
        }

        private void rdoJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblRG.Text = "IE:";
            lblCPF.Text = "CNPJ:";
            mtxCpf.Mask = "##,###,###/####-##";
        }
    }
}
