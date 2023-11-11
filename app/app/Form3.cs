using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class frmcad : Form
    {
        public frmcad()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal usuario = new frmPrincipal();
            usuario.MdiParent = this;//informar janela filha
            usuario.Show();
        }
    }
}
