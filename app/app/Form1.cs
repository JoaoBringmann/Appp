namespace app
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_principal.Text=="")
            {
                MessageBox.Show("Campo de Nome está vazio");
                txt_principal.Focus();
            }
            if (txt_password.Text=="")
            {
                MessageBox.Show("Campo Email está vazio");
                txt_password.Focus();
            }
            if (txt_rg.Text == "") 
            {
                MessageBox.Show("Campo Rg está vazio");
                txt_password.Focus();
            }
            else
            

                MessageBox.Show("Ola Aluno:" + txt_principal.Text);
        }

        private void txt_password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_login_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu tambem não sei");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_bcadastro_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_cadastro_Click(object sender, EventArgs e)
        {

        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void datanascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}