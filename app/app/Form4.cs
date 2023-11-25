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
    public partial class frm_SI : Form
    {
        public frm_SI()
        {
            InitializeComponent();
        }

        private void frm_SI_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sitemai_Click(object sender, EventArgs e)
        {
            if (txt_Ano2.Text == "") ;
            {
                MessageBox.Show("Campo Ano está vazio");
                txt_Ano2.Focus();
            }
            if (txt_Turma2.Text == "")
            {
                MessageBox.Show("Campo Turma está vazio");
                txt_Turma2.Focus();
            }
            else
            {

                MessageBox.Show("Sua turma do curso de Sistema de Informaçãe é:" + txt_Turma2.Text + "\n Do ano:" + txt_Ano2.Text);
            }
        }
    }
}
