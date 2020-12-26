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
    public partial class frmSorvete : Form
    {
        public frmSorvete()
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
    }
}
