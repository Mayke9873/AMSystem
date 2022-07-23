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
    public partial class FrmCompra : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        decimal ValorCompra = 0, DescontoCompra = 0;

        public MessageBoxIcon MessageBoxIcons { get; private set; }

        public FrmCompra()
        {
            InitializeComponent();
        }

        private void FrmCompra_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btnSair_Click(sender, e);
                    break;

                case Keys.F3:
                    btnConfirmar_Click(sender, e);
                    break;

                case Keys.F4:
                    btnCancelar_Click(sender, e);
                    break;

                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(ActiveControl, !e.Shift, true, true, true);
                    break;
            }
        }

        private void txtIdFornecedor_Leave(object sender, EventArgs e)
        {
            if (txtIdFornecedor.Text.Length != 0)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand($"SELECT NOME FROM FORNECEDOR WHERE ID = {int.Parse(txtIdFornecedor.Text)};", con.query);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtFornecedor.Text = reader[0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Forncedor não encontrado. Por favor, verifique!", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdFornecedor.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.CloseConn();
                }
            }
        }

        private void txtIdProduto_Leave(object sender, EventArgs e)
        {
            if (txtIdProduto.Text.Length != 0)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand($"SELECT DESCRICAO FROM PRODUTO WHERE ID = {int.Parse(txtIdProduto.Text)}", con.query);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtProduto.Text = reader[0].ToString();
                        txtQtd.Text = "1,000";
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado. Por favor, verifique!", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdProduto.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.CloseConn();
                }
            }
        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txtFornecedor.Text.Length != 0)
            {
                if (txtIdFornecedor.Text.Length == 0)
                {
                    dgvNome.Location = new Point(12, 110);
                    dgvNome.Visible = true;

                    try
                    {
                        con.OpenConn();
                        cmd = new MySqlCommand($"SELECT ID, NOME FROM FORNECEDOR WHERE NOME LIKE '%{txtFornecedor.Text}%'", con.query);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dgvNome.DataSource = ds;
                        dgvNome.DataMember = ds.Tables[0].TableName;
                        cmd.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.CloseConn();
                    }
                }
                else
                {
                    dgvNome.Visible = false;
                }
            }
            else
            {
                dgvNome.Visible = false;
            }
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtProduto.Text.Length != 0)
            {
                if (txtIdProduto.Text.Length == 0)
                {
                    dgvProdutos.Location = new Point(12, 166);
                    dgvProdutos.Visible = true;

                    try
                    {
                        con.OpenConn();
                        cmd = new MySqlCommand($"SELECT ID, DESCRICAO, ESTOQUE, pCompra FROM PRODUTO WHERE DESCRICAO LIKE '%{txtProduto.Text}%';", con.query);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dgvProdutos.DataSource = ds;
                        dgvProdutos.DataMember = ds.Tables[0].TableName;
                        cmd.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.CloseConn();
                    }
                }
                else
                {
                    dgvProdutos.Visible = false;
                }
            }
            else
            {
                dgvProdutos.Visible = false;
            }
        }

        private void txtValorUnit_Enter(object sender, EventArgs e)
        {
            if (txtQtd.Text.Length == 0)
            {
                txtQtd.Text = "1,000";
            }
            else if (decimal.Parse(txtQtd.Text) == 0)
            {
                MessageBox.Show("Quantidade não pode ser 0. Por favor, verifique!", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                con.OpenConn();
                cmd = new MySqlCommand($"SELECT pCompra FROM PRODUTO WHERE ID = '{txtIdProduto.Text}' AND descricao = '{txtProduto.Text}'", con.query);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtValorUnit.Text = reader[0].ToString();
                    txtQtd.Text = decimal.Parse(txtQtd.Text).ToString("F3");                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CloseConn();
            }
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            decimal vTotal, vProduto = 0, desconto = 0;

            if (txtValorUnit.Text.Length == 0)
            {
                txtProduto.Focus();
            }
            else
            {
                vProduto = Convert.ToDecimal(txtValorUnit.Text);
            }

            if (txtDesconto.Text.Length != 0)
            {
                desconto = Convert.ToDecimal(txtDesconto.Text);
                vTotal = (vProduto * Convert.ToDecimal(txtQtd.Text) - desconto);

                txtValorTotal.Text = vTotal.ToString("F2");
            }
            else
            {
                vTotal = vProduto * Convert.ToDecimal(txtQtd.Text);

                txtValorTotal.Text = vTotal.ToString("F2");
                txtDesconto.Text = "0,00";
            }
        }

        private void txtValorTotal_Enter(object sender, EventArgs e)
        {
            if (txtIdCompra.Text.Length == 0)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("insert into COMPRA (ID, EX) select (select max(id)+1 from COMPRA), 1;", con.query);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    cmd = new MySqlCommand("SELECT ID FROM COMPRA WHERE ID = (SELECT MAX(ID) FROM COMPRA);", con.query);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    txtIdCompra.Text = dr["ID"].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.CloseConn();
                }
            }

            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("INSERT INTO COMPRA_ITEM (id_Compra, idProd, descricao, valor, desconto, quantidade, total, ex) VALUES" +
                    $"((select max(id) from COMPRA), '{txtIdProduto.Text}', '{txtProduto.Text}', '{txtValorUnit.Text.Replace(",", ".")}', '{txtDesconto.Text.Replace(",", ".")}'," +
                    $"'{txtQtd.Text.Replace(",", ".")}', '{txtValorTotal.Text.Replace(",", ".")}', 9);", con.query);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                cmd = new MySqlCommand("SELECT IDPROD, DESCRICAO, QUANTIDADE, VALOR, DESCONTO, TOTAL FROM COMPRA_ITEM WHERE ID_COMPRA = (SELECT MAX(ID_COMPRA) FROM COMPRA_ITEM);", con.query);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvProdCompra.DataSource = ds;
                dgvProdCompra.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CloseConn();
            }

            ValorCompra += decimal.Parse(txtValorTotal.Text);
            txtValorCompra.Text = ValorCompra.ToString();

            DescontoCompra += decimal.Parse(txtDesconto.Text);
            txtDescontoCompra.Text = DescontoCompra.ToString();

            txtIdProduto.Clear();
            txtProduto.Clear();
            txtQtd.Clear();
            txtValorUnit.Clear();
            txtDesconto.Clear();
            txtValorTotal.Clear();

            txtIdProduto.Focus();
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
                txtQtd.Text = "1,000";
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CloseConn();
            }

            txtQtd.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand($"SELECT ID, NOME FROM FORNECEDOR WHERE ID = {int.Parse(txtIdFornecedor.Text)} AND NOME = '{txtFornecedor.Text}';", con.query);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (!dr.Read())
                {
                    MessageBox.Show("Forncedor não encontrado. Por favor, verifique!", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CloseConn();
            }

            if (txtIdCompra.Text != null && txtIdFornecedor.Text != null && txtFornecedor.Text != null)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("UPDATE COMPRA SET ID_FORNECEDOR = @ID_FORNECEDOR, FORNECEDOR = @FORNECEDOR, VALOR = @VALOR, DESCONTO = @DESC, VALOR_TOTAL = @TOTAL, " +
                        $"PAGO = @PAGO, DATA_COMPRA = @DATA, EX = 0 WHERE ID = '{txtIdCompra.Text}';", con.query);

                    cmd.Parameters.AddWithValue("@ID_FORNECEDOR", txtIdFornecedor.Text);
                    cmd.Parameters.AddWithValue("@FORNECEDOR", txtFornecedor.Text);
                    cmd.Parameters.AddWithValue("@VALOR", decimal.Parse(txtValorCompra.Text));
                    cmd.Parameters.AddWithValue("@DESC", decimal.Parse(txtDescontoCompra.Text));
                    cmd.Parameters.AddWithValue("@TOTAL", decimal.Parse(txtValorCompra.Text));
                    cmd.Parameters.AddWithValue("@PAGO", decimal.Parse(txtValorCompra.Text));
                    cmd.Parameters.AddWithValue("@DATA", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    //Carrega DataSet dos produtos inseridos na compra.
                    cmd = new MySqlCommand("SELECT IDPROD, DESCRICAO, QUANTIDADE, VALOR, DESCONTO, TOTAL FROM COMPRA_ITEM " +
                        "WHERE ID_COMPRA = (SELECT MAX(ID_COMPRA) FROM COMPRA_ITEM);", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet dsProdCompra = new DataSet();
                    da.Fill(dsProdCompra);
                    cmd.Dispose();

                    foreach (DataRow dr in dsProdCompra.Tables[0].Rows)
                    {
                        cmd = new MySqlCommand($"UPDATE COMPRA_ITEM SET EX = 0 WHERE IDPROD = '{dr["idprod"]} AND EX  = 9' AND ID_COMPRA = '{txtIdCompra.Text}';", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        cmd = new MySqlCommand("INSERT INTO MOVESTOQUE (idproduto, quantidade, dataMov, idFornecedor, tipoMov) VALUES " +
                            $"('{dr["idprod"]}', '{dr["quantidade"]}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{txtIdFornecedor.Text}', 'C');", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        cmd = new MySqlCommand($"UPDATE PRODUTO SET estoque = (select sum(quantidade) from movestoque where idproduto = '{dr["idprod"]}') WHERE ID = '{dr["idprod"]}';", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }

                    MessageBox.Show("Compra realizada com sucesso!", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cmd = new MySqlCommand("SELECT IDPROD, DESCRICAO, QUANTIDADE, VALOR, DESCONTO, TOTAL FROM COMPRA_ITEM WHERE id = 0;", con.query);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvProdCompra.DataSource = ds;
                    dgvProdCompra.DataMember = ds.Tables[0].TableName;
                    con.CloseConn();
                }

                txtIdCompra.Clear();
                txtIdFornecedor.Clear();
                txtFornecedor.Clear();
                txtIdProduto.Clear();
                txtProduto.Clear();
                txtQtd.Clear();
                txtValorUnit.Clear();
                txtDesconto.Clear();
                txtValorTotal.Clear();
                txtValorCompra.Clear();
                txtDescontoCompra.Clear();
                txtIdFornecedor.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtIdFornecedor.Text.Length != 0 || txtFornecedor.Text.Length != 0 || txtIdProduto.Text.Length != 0 && txtProduto.Text.Length != 0)
            {
                if (MessageBox.Show("Deseja cancelar compra?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //Exclui itens da venda
                        con.OpenConn();
                        cmd = new MySqlCommand($"DELETE FROM COMPRA_ITEM WHERE ID_COMPRA = {int.Parse(txtIdCompra.Text)};", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        //Exclui a venda
                        cmd = new MySqlCommand($"DELETE FROM COMPRA WHERE ID = {int.Parse(txtIdCompra.Text)};", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        //Refaz select dos itens
                        cmd = new MySqlCommand("SELECT IDPROD, DESCRICAO, QUANTIDADE, VALOR, DESCONTO, TOTAL FROM COMPRA_ITEM WHERE id = 0;", con.query);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dgvProdCompra.DataSource = ds;
                        dgvProdCompra.DataMember = ds.Tables[0].TableName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.CloseConn();
                    }
                }

                txtIdCompra.Clear();
                txtIdFornecedor.Clear();
                txtFornecedor.Clear();
                txtIdProduto.Clear();
                txtProduto.Clear();
                txtQtd.Clear();
                txtValorUnit.Clear();
                txtDesconto.Clear();
                txtValorTotal.Clear();
                txtValorCompra.Clear();
                txtDescontoCompra.Clear();
                txtIdFornecedor.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (txtIdCompra.Text.Length != 0)
            {
                if (MessageBox.Show("Deseja cancelar compra?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        //Exclui itens da venda
                        con.OpenConn();
                        cmd = new MySqlCommand($"DELETE FROM COMPRA_ITEM WHERE ID_COMPRA = {int.Parse(txtIdCompra.Text)};", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        //Exclui a venda
                        cmd = new MySqlCommand($"DELETE FROM COMPRA WHERE ID = {int.Parse(txtIdCompra.Text)};", con.query);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.CloseConn();
                    }
                    this.Close();
                    return;
                }
            }
            else if (MessageBox.Show("Deseja sair da compra?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                return;
            }
        }
    }
}
