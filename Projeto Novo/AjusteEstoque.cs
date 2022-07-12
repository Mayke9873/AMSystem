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
    public partial class FrmAjusteEstoque : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;

        public FrmAjusteEstoque()
        {
            InitializeComponent();
        }

        private void FrmAjusteEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    this.SelectNextControl(ActiveControl, !e.Shift, true, true, true);
                    break;

                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
        private void txtIdProduto_Leave(object sender, EventArgs e)
        {
            if (txtIdProduto.Text.Length != 0)
            {
                try
                {
                    con.OpenConn();
                    cmd = new MySqlCommand("SELECT DESCRICAO FROM PRODUTO WHERE ID = '" + int.Parse(txtIdProduto.Text) + "';", con.query);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        txtDescricao.Text = dataReader[0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Produto não cadastrado. Por favor, verifique!", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdProduto.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AmSystem Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.CloseConn();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                con.OpenConn();
                cmd = new MySqlCommand("SELECT ID, DESCRICAO FROM PRODUTO WHERE ID = '" + txtIdProduto.Text + "' AND DESCRICAO = '" + txtDescricao.Text + "';", con.query);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    if (mtxQtd.Text.Length != 0)
                    {
                        if (rdoEntrada.Checked)
                        {
                            try
                            {
                                con.OpenConn();

                                cmd = new MySqlCommand("INSERT INTO MOVESTOQUE (idproduto, quantidade, dataMov, idUsuario, tipoMov) VALUES " +
                                        "('" + txtIdProduto.Text + "', '" + mtxQtd.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '', 'A');", con.query);
                                cmd.ExecuteNonQuery();
                                cmd.Dispose();

                                cmd = new MySqlCommand("UPDATE PRODUTO SET estoque = (select sum(quantidade) from movestoque where idproduto = '" + txtIdProduto.Text + "') WHERE ID = '" + txtIdProduto.Text + "';", con.query);
                                cmd.ExecuteNonQuery();
                                cmd.Dispose();

                                MessageBox.Show("Ajuste de entrada registrado com sucesso!", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "AmSystem Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                txtIdProduto.Clear();
                                txtDescricao.Clear();
                                mtxQtd.Clear();
                                con.CloseConn();
                            }
                        }
                        else if (rdoSaida.Checked)
                        {
                            try
                            {
                                con.OpenConn();

                                cmd = new MySqlCommand("INSERT INTO MOVESTOQUE (idproduto, quantidade, dataMov, idUsuario, tipoMov) VALUES " +
                                        "('" + txtIdProduto.Text + "', '" + mtxQtd.Text + "' * -1, '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '', 'A');", con.query);
                                cmd.ExecuteNonQuery();
                                cmd.Dispose();

                                cmd = new MySqlCommand("UPDATE PRODUTO SET estoque = (select sum(quantidade) from movestoque where idproduto = '" + txtIdProduto.Text + "') WHERE ID = '" + txtIdProduto.Text + "';", con.query);
                                cmd.ExecuteNonQuery();
                                cmd.Dispose();

                                MessageBox.Show("Ajuste de saida registrado com sucesso!", "AmSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "AmSystem Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                txtIdProduto.Clear();
                                txtDescricao.Clear();
                                mtxQtd.Clear();
                                con.CloseConn();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Quanditade não informada. Por favor, verifique!");
                        mtxQtd.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Produto inserido inválido. Por favor, verifique!");
                    txtIdProduto.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AmSystem Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CloseConn();
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Length != 0)
            {
                if (txtIdProduto.Text.Length == 0)
                {
                    dgvProduto.Location = new Point(12, 117);
                    dgvProduto.Visible = true;

                    try
                    {
                        con.OpenConn();
                        cmd = new MySqlCommand("SELECT ID, DESCRICAO, ESTOQUE FROM PRODUTO WHERE DESCRICAO LIKE '%" + txtDescricao.Text + "%';", con.query);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dgvProduto.DataSource = ds;
                        dgvProduto.DataMember = ds.Tables[0].TableName;
                        cmd.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "AmSystem Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.CloseConn();
                    } 
                }
                else
                {
                    dgvProduto.Visible = false;
                }
            }
            else
            {
                dgvProduto.Visible = false;
            }
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con.OpenConn();
                DataGridViewRow row = dgvProduto.Rows[e.RowIndex];
                txtIdProduto.Text = row.Cells[0].Value.ToString();
                txtDescricao.Text = row.Cells[1].Value.ToString();
                mtxQtd.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AmSystem Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CloseConn();
            }
        }
    }
}
