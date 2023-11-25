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
    public partial class x : Form
    {
        public x()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btn_professor_Click(object sender, EventArgs e)
        {
            if (txt6_disciplinaa.Text == "")
            {
                MessageBox.Show("Campo de Disciplina está vazio");
                txt6_disciplinaa.Focus();
            }
            if (txt6_formacaoo.Text == "")
            {
                MessageBox.Show("Campo Formação está vazio");
                txt6_formacaoo.Focus();
            }
            if (txt6_nomee.Text == "")
            {
                MessageBox.Show("Campo Nome está vazio");
                txt6_nomee.Focus();
            }
            if (txt6_periodoo.Text == "")
            {
                MessageBox.Show("Campo Periodo está vazio");
                txt6_periodoo.Focus();
            }
            else
            { 

                MessageBox.Show("Ola Professor:" + txt6_nomee.Text);
        }

    }
}
}
