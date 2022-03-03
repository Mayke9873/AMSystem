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
    }
}
