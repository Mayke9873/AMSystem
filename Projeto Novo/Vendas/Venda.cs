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

        decimal ValorVenda = 0, DescontoVenda = 0;

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
                    this.btnSair_Click(sender, e);
                    break;

                case Keys.F3:
                    this.btnConfirmar_Click(sender, e);
                    break;

                case Keys.F4:
                    this.btnCancelar_Click(sender, e);
                    break;
            }
        }

        private void txtIdVendedor_Leave(object sender, EventArgs e)
        {
            if (txtIdVendedor.Text.Length != 0)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT NOME FROM FUNCIONARIO WHERE ID = " + int.Parse(txtIdVendedor.Text) + ";", con.query);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtVendedor.Text = dr[0].ToString();
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
        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {
            if (txtVendedor.Text.Length != 0)
            {
                if (txtIdVendedor.Text.Length == 0)
                {
                    dgvNome.Location = new Point(12, 102);
                    dgvNome.Visible = true;

                    try
                    {
                        con.OpenConn();
                        cmd = new MySqlCommand("SELECT ID, NOME FROM FUNCIONARIO WHERE NOME LIKE '%" + txtVendedor.Text + "%';", con.query);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dgvNome.DataSource = ds;
                        dgvNome.DataMember = ds.Tables[0].TableName;
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
                else if (txtIdVendedor.Text.Length != 0)
                {
                    dgvNome.Visible = false;
                }
            }
            else
            {
                dgvNome.Visible = false;
            }
        }

        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length != 0)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT NOME FROM CLIENTE WHERE ID = " + int.Parse(txtIdCliente.Text) + ";", con.query);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtCliente.Text = dr[0].ToString();
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
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text.Length != 0)
            {
                if (txtIdCliente.Text.Length == 0)
                {
                    dgvNome.Location = new Point(12, 150);
                    dgvNome.Visible = true;

                    try
                    {
                        con.OpenConn();
                        cmd = new MySqlCommand("SELECT ID, NOME FROM CLIENTE WHERE NOME LIKE '%" + txtCliente.Text + "%';", con.query);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dgvNome.DataSource = ds;
                        dgvNome.DataMember = ds.Tables[0].TableName;
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
                else if (txtIdCliente.Text.Length != 0)
                {
                    dgvNome.Visible = false;
                }
            }
            else
            {
                dgvNome.Visible = false;
            }
        }

        private void txtIdProduto_Leave(object sender, EventArgs e)
        {
            if (txtIdProduto.Text.Length != 0)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT DESCRICAO, pVenda FROM PRODUTO WHERE ID = " + int.Parse(txtIdProduto.Text) + ";", con.query);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtProduto.Text = dr[0].ToString();
                        txtValorUnit.Text = dr[1].ToString();
                        txtQtd.Focus();
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
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtProduto.Text.Length != 0)
            {
                if (txtIdProduto.Text.Length == 0)
                {
                    dgvProdutos.Location = new Point(12, 220);
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

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            if (txtQtd.Text.Length == 0)
            {
                txtQtd.Text = "1,000";
            }
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            decimal vTotal;
            decimal vProdtudo = 0;
            decimal desconto = 0;

            if (txtValorUnit.Text.Length == 0)
            {
                txtProduto.Focus();
            }
            else
            {
                vProdtudo = Convert.ToDecimal(txtValorUnit.Text);
            }


            if (txtDesconto.Text.Length != 0)
            {
                desconto = Convert.ToDecimal(txtDesconto.Text);
                vTotal = (vProdtudo * Convert.ToDecimal(txtQtd.Text)) - desconto;

                txtValorTotal.Text = vTotal.ToString();
            }
            else
            {
                vTotal = vProdtudo * Convert.ToDecimal(txtQtd.Text);

                txtValorTotal.Text = vTotal.ToString();
                txtDesconto.Text = "0,00";
            }
        }

        private void txtValorTotal_Enter(object sender, EventArgs e)
        {
            if (txtIdVenda.Text.Length == 0)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("insert into venda (ID, EX) select (select max(id)+1 from venda), 1;", con.query);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    cmd = new MySqlCommand("SELECT ID FROM VENDA WHERE ID = (SELECT MAX(ID) FROM VENDA);", con.query);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    txtIdVenda.Text = dr["ID"].ToString();

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

            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("INSERT INTO VENDA_ITEM (idVenda, idProd, descricao, valor, desconto, quantidade, total) VALUES" +
                    "((select max(id) from VENDA), '" + txtIdProduto.Text + "', '" + txtProduto.Text + "', '" + txtValorUnit.Text + "', '" + txtDesconto.Text + "'," +
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

            ValorVenda += decimal.Parse(txtValorTotal.Text);
            txtValorVenda.Text = ValorVenda.ToString();

            DescontoVenda += decimal.Parse(txtDesconto.Text);
            txtDescontoVenda.Text = DescontoVenda.ToString();

            txtIdProduto.Clear();
            txtProduto.Clear();
            txtQtd.Clear();
            txtValorUnit.Clear();
            txtDesconto.Clear();
            txtValorTotal.Clear();

            txtProduto.Focus();
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

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.CloseConn();
            }

            txtQtd.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime dtVenda;

            //Verefica funcionario
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT ID, NOME FROM FUNCIONARIO WHERE ID = " + int.Parse(txtIdVendedor.Text) + " AND NOME = '" + txtVendedor.Text + "';", con.query);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == false)
                {
                    MessageBox.Show("Vendedor inválido. Por favor, verifique!", "AMSystem");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message + "");
            }
            finally
            {
                con.CloseConn();
            }

            //Verifica vendedor
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT ID, NOME FROM CLIENTE WHERE ID = " + int.Parse(txtIdCliente.Text) + " AND NOME = '" + txtCliente.Text + "';", con.query);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == false)
                {
                    MessageBox.Show("Cliente inválido. Por favor, verifique!", "AMSystem");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "");
            }
            finally 
            {
                con.CloseConn();
            }

            if (txtIdVenda.Text != null && txtIdCliente.Text != null && txtCliente.Text != null)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("UPDATE VENDA SET ID_CLIENTE = @ID_CLIENTE, CLIENTE = @CLIENTE, VALOR = @VALOR, DESCONTO = @DESC, VALOR_TOTAL = @TOTAL, " +
                        "PAGO = @PAGO , VENDEDOR = @VENDEDOR, DATA_VENDA = @DATA, EX = 0 WHERE ID = '" + txtIdVenda.Text + "'", con.query);

                    cmd.Parameters.AddWithValue("@ID_CLIENTE", txtIdCliente.Text);
                    cmd.Parameters.AddWithValue("@CLIENTE", txtCliente.Text);
                    cmd.Parameters.AddWithValue("@VALOR", decimal.Parse(txtValorVenda.Text));
                    cmd.Parameters.AddWithValue("@DESC", decimal.Parse(txtDescontoVenda.Text));
                    cmd.Parameters.AddWithValue("@TOTAL", decimal.Parse(txtValorVenda.Text));
                    cmd.Parameters.AddWithValue("@PAGO", decimal.Parse(txtValorVenda.Text));
                    cmd.Parameters.AddWithValue("@VENDEDOR", int.Parse(txtIdVendedor.Text));
                    cmd.Parameters.AddWithValue("@DATA", dtVenda = DateTime.Now); 
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    cmd = new MySqlCommand("SELECT IDPROD, DESCRICAO, QUANTIDADE, VALOR, DESCONTO, TOTAL FROM VENDA_ITEM WHERE IDVENDA = (SELECT MAX(IDVENDA) FROM VENDA_ITEM);", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet dsProdVenda = new DataSet();
                    da.Fill(dsProdVenda);
                    cmd.Dispose();

                    foreach (DataRow dr in dsProdVenda.Tables[0].Rows)
                    {
                        cmd = new MySqlCommand("INSERT INTO MOVESTOQUE (idproduto, quantidade, dataMov, idUsuario, tipoMov) VALUES " +
                            "('" + dr["idprod"] + "', '" + dr["quantidade"] + "' * -1, '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + txtIdVendedor.Text + "', 'V');", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        cmd = new MySqlCommand("UPDATE PRODUTO SET estoque = (select sum(quantidade) from movestoque where idproduto = '" + dr["idprod"] + "') WHERE ID = '" + dr["idprod"] + "';", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }

                    MessageBox.Show("Venda realizado com sucesso!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cmd = new MySqlCommand("SELECT IDPROD, DESCRICAO, QUANTIDADE, VALOR, DESCONTO, TOTAL FROM VENDA_ITEM WHERE id = 0;", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvProVenda.DataSource = ds;
                    dgvProVenda.DataMember = ds.Tables[0].TableName;
                    con.CloseConn();
                }

                txtIdVenda.Clear();
                txtIdCliente.Clear();
                txtCliente.Clear();
                txtIdProduto.Clear();
                txtProduto.Clear();
                txtQtd.Clear();
                txtValorUnit.Clear();
                txtDesconto.Clear();
                txtValorTotal.Clear();
                txtValorVenda.Clear();
                txtDescontoVenda.Clear();
                txtIdCliente.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length != 0 || txtCliente.Text.Length != 0 || txtIdProduto.Text.Length != 0 && txtProduto.Text.Length != 0)
            {
                if (MessageBox.Show("Deseja cancelar venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //Exclui itens da venda
                        con.OpenConn();
                        cmd = new MySqlCommand("DELETE FROM VENDA_ITEM WHERE IDVENDA = '" + int.Parse(txtIdVenda.Text) + "';", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        //Exclui a venda
                        cmd = new MySqlCommand("DELETE FROM VENDA WHERE ID = " + int.Parse(txtIdVenda.Text) + ";", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        //Refaz select dos itens
                        cmd = new MySqlCommand("SELECT IDPROD, DESCRICAO, QUANTIDADE, VALOR, DESCONTO, TOTAL FROM VENDA_ITEM WHERE id = 0;", con.query);

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

                    txtIdVenda.Clear();
                    txtCliente.Clear();
                    txtIdCliente.Clear();
                    txtIdProduto.Clear();
                    txtProduto.Clear();
                    txtQtd.Clear();
                    txtValorUnit.Clear();
                    txtValorTotal.Clear();
                    txtDesconto.Clear();
                    txtDescontoVenda.Clear();
                    txtValorVenda.Clear();
                    ValorVenda = 0;
                    txtIdCliente.Focus();
                    return;
                }
                return;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (txtIdVenda.Text.Length != 0)
            {
                if (MessageBox.Show("Deseja cancelar venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        //Exclui itens da venda
                        con.OpenConn();
                        cmd = new MySqlCommand("DELETE FROM VENDA_ITEM WHERE IDVENDA = " + int.Parse(txtIdVenda.Text) + ";", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        //Exclui a venda
                        cmd = new MySqlCommand("DELETE FROM VENDA WHERE ID = " + int.Parse(txtIdVenda.Text) + ";", con.query);
                        cmd.ExecuteNonQuery();
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
                    this.Close();
                    return;
                }
            }
            else if (MessageBox.Show("Deseja sair da venda?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                return;
            }
        }
    }
}
