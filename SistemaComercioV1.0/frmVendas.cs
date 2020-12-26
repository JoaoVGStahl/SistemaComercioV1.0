using System;
using System.Windows.Forms;

namespace SistemaComercioV1._0
{
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))

                {

                    e.Handled = true;

                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgwVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}


