using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            frmSorvete frm = new frmSorvete();
            frm.Show();
            Hide();
        }
    }
}
