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

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sistemaDeInformaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SI sistema = new frm_SI();
            sistema.MdiParent = this;//informar janela filha
            sistema.Show();

        }

        private void engenhariaDeSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_es engenharia = new frm_es();
            engenharia.MdiParent = this;//informar janela filha
            engenharia.Show();
        }

        private void cadastroProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x usuariop = new x();
            usuariop.MdiParent = this;//informar janela filha
            usuariop.Show();
        }
    }
}
