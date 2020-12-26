using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaComercioV1._0
{
    public partial class FrmCadastroSorvete : Form
    {
        public FrmCadastroSorvete()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.Show();
            Hide();
        }

        private void TxtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtDesc2.Text = "";
            txtSabor2.Text = "";
            txtValor2.Text = "";
            cmbCategoria2.Text = "";
            txtSabor2.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=ROTIV-PC;Initial Catalog=BD_COMERCIO;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            conexao.Open();

            cmd.CommandText = "INSERT INTO dbo.CADASTRO_SORVETE(SABOR, CATEGORIA, DESCRICAO, VALOR)" + "VALUES ('" + txtSabor2.Text + "','" + cmbCategoria2.Text + "','" + txtDesc2.Text + "','" + txtValor2.Text + "')";
            cmd.Parameters.AddWithValue("@SABOR", txtSabor2.Text);
            cmd.Parameters.AddWithValue("CATEGORIA", cmbCategoria2.Text);
            cmd.Parameters.AddWithValue("DESCRICAO", txtDesc2.Text);
            cmd.Parameters.AddWithValue("@VALOR", txtValor2.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexao.Close();
        }
    }
}
