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
    public partial class frm_es : Form
    {
        public frm_es()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btn_cursoe_Click(object sender, EventArgs e)
        {
            if (txt_ano.Text == "")
            {
                MessageBox.Show("Campo Ano está vazio");
                txt_ano.Focus();
            }
            if (txt_turma.Text == "")
            {
                MessageBox.Show("Campo Turma está vazio");
                txt_turma.Focus();
            }
            else
            {

                MessageBox.Show("Sua turma do curso de Engenharia de Software é:" + txt_turma.Text + "\n Do ano:" + txt_ano.Text);
            }
        }
    }
}
