namespace app
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_confirm = new System.Windows.Forms.Button();
            this.txlogin = new System.Windows.Forms.Label();
            this.txt_principal = new System.Windows.Forms.MaskedTextBox();
            this.txpassword = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.datanascimento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_confirm
            // 
            this.txt_confirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_confirm.Location = new System.Drawing.Point(258, 33);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.Size = new System.Drawing.Size(75, 23);
            this.txt_confirm.TabIndex = 1;
            this.txt_confirm.Text = "Confirmar";
            this.txt_confirm.UseVisualStyleBackColor = false;
            this.txt_confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // txlogin
            // 
            this.txlogin.AutoSize = true;
            this.txlogin.Location = new System.Drawing.Point(22, 33);
            this.txlogin.Name = "txlogin";
            this.txlogin.Size = new System.Drawing.Size(40, 15);
            this.txlogin.TabIndex = 2;
            this.txlogin.Text = "Nome";
            this.txlogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_principal
            // 
            this.txt_principal.Location = new System.Drawing.Point(65, 33);
            this.txt_principal.Name = "txt_principal";
            this.txt_principal.Size = new System.Drawing.Size(100, 23);
            this.txt_principal.TabIndex = 3;
            this.txt_principal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_login_MaskInputRejected);
            // 
            // txpassword
            // 
            this.txpassword.AutoSize = true;
            this.txpassword.Location = new System.Drawing.Point(26, 65);
            this.txpassword.Name = "txpassword";
            this.txpassword.Size = new System.Drawing.Size(36, 15);
            this.txpassword.TabIndex = 4;
            this.txpassword.Text = "Email";
            this.txpassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(65, 62);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 23);
            this.txt_password.TabIndex = 5;
            this.txt_password.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_password_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "RG";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(65, 91);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(100, 23);
            this.txt_rg.TabIndex = 8;
            this.txt_rg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // datanascimento
            // 
            this.datanascimento.Location = new System.Drawing.Point(22, 140);
            this.datanascimento.Name = "datanascimento";
            this.datanascimento.Size = new System.Drawing.Size(200, 23);
            this.datanascimento.TabIndex = 9;
            this.datanascimento.ValueChanged += new System.EventHandler(this.datanascimento_ValueChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datanascimento);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txpassword);
            this.Controls.Add(this.txt_principal);
            this.Controls.Add(this.txlogin);
            this.Controls.Add(this.txt_confirm);
            this.Name = "frmPrincipal";
            this.Text = "Cadastra Usuario";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button txt_confirm;
        private Label txlogin;
        private MaskedTextBox txt_principal;
        private Label txpassword;
        private MaskedTextBox txt_password;
        private Label label1;
        private MaskedTextBox txt_rg;
        private DateTimePicker datanascimento;
    }
}