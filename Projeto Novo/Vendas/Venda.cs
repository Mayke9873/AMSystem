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
    public partial class FrmVenda : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        decimal vValorUnit;

        public FrmVenda()
        {
            InitializeComponent();
        }

        private void frmVendas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    btnSair_Click(sender, e);
                    break;

                case Keys.F2:
                    btnCancelar_Click(sender, e);
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length != 0 || txtCliente.Text.Length != 0 || txtIdProduto.Text.Length != 0 && txtProduto.Text.Length != 0)
            {
                if (MessageBox.Show("Deseja cancelar venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Close();
                    return;
                }
            }
            else if (MessageBox.Show("Deseja sair da venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length != 0 || txtCliente.Text.Length != 0 || txtIdProduto.Text.Length != 0 && txtProduto.Text.Length != 0)
            {
                if (MessageBox.Show("Deseja cancelar venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtIdVenda.Clear();
                    txtCliente.Clear();
                    txtIdCliente.Clear();
                    txtIdProduto.Clear();
                    txtProduto.Clear();
                    txtQtd.Clear();
                    txtValorUnit.Clear();
                    txtValorTotal.Clear();
                    txtDesconto.Clear();
                    return;
                }
                return;
            }
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtProduto.Text.Length != 0)
            {
                if (txtIdProduto.Text.Length == 0)
                {
                    dgvProdutos.Visible = true;

                    try
                    {
                        con.OpenConn();
                        cmd = new MySqlCommand("SELECT ID, DESCRICAO, estoque, pVENDA FROM PRODUTO WHERE DESCRICAO LIKE '%" + txtProduto.Text + "%' " +
                            "AND ATIVO = 'S';", con.query);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dgvProdutos.DataSource = ds;
                        dgvProdutos.DataMember = ds.Tables[0].TableName;
                        cmd.Dispose();
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
                else if (txtIdProduto.Text.Length != 0)
                {
                    dgvProdutos.Visible = false;
                }
            }
            else
            {
                dgvProdutos.Visible = false;
            }
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con.OpenConn();
                DataGridViewRow row = dgvProdutos.Rows[e.RowIndex];
                txtIdProduto.Text = row.Cells[0].Value.ToString();
                txtProduto.Text = row.Cells[1].Value.ToString();
                txtValorUnit.Text = row.Cells[3].Value.ToString();
                vValorUnit = decimal.Parse(txtValorUnit.Text);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.CloseConn();
            }

            txtQtd.Text = "1";
            txtQtd.Focus();
        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            if (txtQtd.Text.Length == 0)
            {
                txtQtd.Text = "1";
            }
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            decimal vTotal;
            decimal vProdtudo;
            decimal desconto;
            vProdtudo = Convert.ToDecimal(txtValorUnit.Text);


            if (txtDesconto.Text.Length != 0)
            {
                desconto = Convert.ToDecimal(txtDesconto.Text);
                vTotal = (vProdtudo  * Convert.ToDecimal(txtQtd.Text)) - desconto;

                txtValorTotal.Text = vTotal.ToString();
            }
            else
            {
                vTotal = vProdtudo * Convert.ToDecimal(txtQtd.Text);

                txtValorTotal.Text = vTotal.ToString();
            }

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("INSERT INTO VENDA_ITEM (idVenda, idProd, descricao, valor, desconto, quantidade, total) VALUES" +
                    "((select max(id + 1)  from VENDA), '" + txtIdProduto.Text + "', '" + txtProduto.Text + "', '" + txtValorUnit.Text + "', '" + txtDesconto.Text + "'," +
                    "'" + txtQtd.Text + "', '" + txtValorTotal.Text + "')", con.query);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                cmd = new MySqlCommand("SELECT IDPROD, DESCRICAO, QUANTIDADE, VALOR, DESCONTO, TOTAL FROM VENDA_ITEM WHERE IDVENDA = (SELECT MAX(IDVENDA) FROM VENDA_ITEM);", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvProVenda.DataSource = ds;
                dgvProVenda.DataMember = ds.Tables[0].TableName;
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
