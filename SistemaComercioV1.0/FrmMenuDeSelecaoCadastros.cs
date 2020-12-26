using System;
using System.Windows.Forms;

namespace SistemaComercioV1._0
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmCadatroBebida frm = new frmCadatroBebida();
            frm.Show();
            Hide();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FrmCadastroSorvete frm = new FrmCadastroSorvete();
            frm.Show();
            Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmCadastroAlimento frm = new FrmCadastroAlimento();
            frm.Show();
            Hide();
        }
    }
}
