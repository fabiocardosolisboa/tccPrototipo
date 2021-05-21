using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tcc
{
    public partial class frmCadastro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public frmCadastro()
        {
            InitializeComponent();
            txtID.Text = RetornaUltimoCodigo().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=tcc;Uid=root;Pwd=12345678;");
                strSQL = "INSERT INTO CAD_CLIENTE (NOME,ENDERECO,BAIRRO,TELEFONE,EMAIL) " +
                    "VALUES (@NOME,@ENDERECO,@BAIRRO,@TELEFONE,@EMAIL)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtBairro.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
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
            txtID.Text = RetornaUltimoCodigo().ToString();
        }
        private int RetornaUltimoCodigo()
        {
            int codigoRetornado = 0;
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=tcc;Uid=root;Pwd=12345678;");
                strSQL = "SELECT MAX(ID) FROM CAD_CLIENTE";
                comando = new MySqlCommand(strSQL, conexao);
                conexao.Open();
                codigoRetornado = Convert.ToInt32(comando.ExecuteScalar());
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
            return codigoRetornado;
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
