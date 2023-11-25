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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Logar_Click(object sender, EventArgs e)
        {
            if (txt_logi.Text == "login" && txt_senha.Text == "aluno123")
            {
                frmcad principal = new frmcad();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalido");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_logi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_logi.Clear();
            txt_senha.Clear();
        }
    }
}
