using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SistemaComercioV1._0
{
    public partial class frmCadatroBebida : Form
    {
        public frmCadatroBebida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.Show();
            this.Close();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void mskDataVld_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            cmbCategoria.Text = "";
            txtSabor.Text = "";
            txtDesc.Text = "";
            txtValor.Text = "";
            txtNome.Focus();
            btnSalvar.Enabled = false;
        }

        private void LblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }



        private void TxtValor_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtValor.Text.Length - 1; i++)
            {
                if ((txtValor.Text[i] >= '0' &&
                    txtValor.Text[i] <= '9') ||
                    txtValor.Text[i] == ',')
                {
                    x += txtValor.Text[i];
                }
            }
            txtValor.Text = x;
            txtValor.SelectAll();
        }

        private void FrmCadatroBebida_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=ROTIV-PC;Initial Catalog=BD_COMERCIO;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            conexao.Open();

            cmd.CommandText = "INSERT INTO dbo.CADASTRO_BEBIDAS(NOME, CATEGORIA, SABOR, DESCRICAO, VALOR)" + "VALUES ('" + txtNome.Text + "','" + cmbCategoria.Text + "','" + txtSabor.Text + "','" + txtDesc.Text + "','" + txtValor.Text + "')";
            cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
            cmd.Parameters.AddWithValue("@CATEGORIA", cmbCategoria.Text);
            cmd.Parameters.AddWithValue("@SABOR", txtSabor.Text);
            cmd.Parameters.AddWithValue("@DESCRICAO", txtDesc.Text);
            cmd.Parameters.AddWithValue("@VALOR", txtValor.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexao.Close();
        }

        private void BtnSalvar_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("F");
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                   (e.KeyChar != ',' && e.KeyChar != '.' &&
                    e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
                {
                    e.KeyChar = (Char)0;
                }
                else
                {
                    if (e.KeyChar == '.' || e.KeyChar == ',')
                    {
                        if (!txtValor.Text.Contains(','))
                        {
                            e.KeyChar = ',';
                        }
                        else
                        {
                            e.KeyChar = (Char)0;
                        }
                    }
                }
            }
        }

        private void TxtValor_MouseLeave(object sender, EventArgs e)
        {
            txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("F");
        }
    }
}



