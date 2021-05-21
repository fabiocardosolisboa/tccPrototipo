using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tcc
{
    public partial class frmPacientes : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public frmPacientes()
        {
            InitializeComponent();
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=tcc;Uid=root;Pwd=12345678;");
                conexao.Open();
                strSQL = "SELECT ID FROM CAD_CLIENTE";
                comando = new MySqlCommand(strSQL, conexao);
                MySqlDataReader dr = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbID.DisplayMember = "ID";
                cbID.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=tcc;Uid=root;Pwd=12345678;");
                strSQL = "UPDATE CAD_CLIENTE SET NOME=@NOME,ENDERECO=@ENDERECO,BAIRRO=@BAIRRO," +
                    "TELEFONE=@TELEFONE,EMAIL=@EMAIL WHERE ID=@ID";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", cbID.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                dataGridView1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
                MessageBox.Show("pronto");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=tcc;Uid=root;Pwd=12345678;");
                strSQL = "SELECT * FROM CAD_CLIENTE WHERE NOME=@NOME";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                conexao.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    cbID.Text = Convert.ToString(dr["id"]);
                    txtEndereco.Text = Convert.ToString(dr["endereco"]);
                    txtBairro.Text = Convert.ToString(dr["bairro"]);
                    txtTelefone.Text = Convert.ToString(dr["telefone"]);
                    txtEmail.Text = Convert.ToString(dr["email"]);
                }
                if (txtEndereco.Text == "" && txtBairro.Text == "" &&
                    txtTelefone.Text == "" && txtEmail.Text == "")
                {
                    MessageBox.Show("Não existe paciente com esse nome");
                    dataGridView1.Visible = true;
                    txtNome.Text = "";
                    txtNome.Enabled = false;
                    btnNome.Enabled = false;
                }
                else 
                {
                    if (txtEndereco.Text != "" && txtBairro.Text != "" &&
                    txtTelefone.Text != "" && txtEmail.Text != "")
                    {
                        dataGridView1.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
                MessageBox.Show("processo executado");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=tcc;Uid=root;Pwd=12345678;");
                strSQL = "DELETE FROM CAD_CLIENTE WHERE ID=@ID";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", cbID.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                strSQL = "SELECT ID FROM CAD_CLIENTE";
                comando = new MySqlCommand(strSQL, conexao);
                MySqlDataReader dr = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbID.DisplayMember = "ID";
                cbID.DataSource = dt;
                dataGridView1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
                MessageBox.Show("pronto");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=tcc;Uid=root;Pwd=12345678;");
                strSQL = "SELECT * FROM CAD_CLIENTE";
                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                txtNome.Text = "";
                txtNome.Enabled = false;
                btnNome.Enabled = false;
                dataGridView1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
                MessageBox.Show("processo executado");
            }
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=tcc;Uid=root;Pwd=12345678;");
                conexao.Open();
                strSQL = "SELECT ID FROM CAD_CLIENTE";
                comando = new MySqlCommand(strSQL, conexao);
                MySqlDataReader dr = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbID.DisplayMember = "ID";
                cbID.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=tcc;Uid=root;Pwd=12345678;");
                strSQL = "SELECT * FROM CAD_CLIENTE WHERE ID=@ID";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", cbID.Text);
                conexao.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    txtNome.Text = Convert.ToString(dr["nome"]);
                    txtEndereco.Text = Convert.ToString(dr["endereco"]);
                    txtBairro.Text = Convert.ToString(dr["bairro"]);
                    txtTelefone.Text = Convert.ToString(dr["telefone"]);
                    txtEmail.Text = Convert.ToString(dr["email"]);
                }
                dataGridView1.Visible = false;
                txtNome.Enabled = true;
                btnNome.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
                MessageBox.Show("processo executado");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            btnNome.Enabled = true;
        }
    }
}
