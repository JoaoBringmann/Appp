namespace app
{
    partial class frm_SI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Sitemai = new System.Windows.Forms.Button();
            this.l_Turma = new System.Windows.Forms.Label();
            this.l_Ano = new System.Windows.Forms.Label();
            this.txt_Turma2 = new System.Windows.Forms.MaskedTextBox();
            this.txt_Ano2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_Sitemai
            // 
            this.btn_Sitemai.Location = new System.Drawing.Point(102, 160);
            this.btn_Sitemai.Name = "btn_Sitemai";
            this.btn_Sitemai.Size = new System.Drawing.Size(75, 23);
            this.btn_Sitemai.TabIndex = 0;
            this.btn_Sitemai.Text = "Confirmar";
            this.btn_Sitemai.UseVisualStyleBackColor = true;
            this.btn_Sitemai.Click += new System.EventHandler(this.btn_Sitemai_Click);
            // 
            // l_Turma
            // 
            this.l_Turma.AutoSize = true;
            this.l_Turma.Location = new System.Drawing.Point(30, 41);
            this.l_Turma.Name = "l_Turma";
            this.l_Turma.Size = new System.Drawing.Size(41, 15);
            this.l_Turma.TabIndex = 1;
            this.l_Turma.Text = "Turma";
            // 
            // l_Ano
            // 
            this.l_Ano.AutoSize = true;
            this.l_Ano.Location = new System.Drawing.Point(42, 88);
            this.l_Ano.Name = "l_Ano";
            this.l_Ano.Size = new System.Drawing.Size(29, 15);
            this.l_Ano.TabIndex = 2;
            this.l_Ano.Text = "Ano";
            // 
            // txt_Turma2
            // 
            this.txt_Turma2.Location = new System.Drawing.Point(77, 41);
            this.txt_Turma2.Name = "txt_Turma2";
            this.txt_Turma2.Size = new System.Drawing.Size(100, 23);
            this.txt_Turma2.TabIndex = 3;
            // 
            // txt_Ano2
            // 
            this.txt_Ano2.Location = new System.Drawing.Point(77, 88);
            this.txt_Ano2.Name = "txt_Ano2";
            this.txt_Ano2.Size = new System.Drawing.Size(100, 23);
            this.txt_Ano2.TabIndex = 4;
            // 
            // frm_SI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Ano2);
            this.Controls.Add(this.txt_Turma2);
            this.Controls.Add(this.l_Ano);
            this.Controls.Add(this.l_Turma);
            this.Controls.Add(this.btn_Sitemai);
            this.Name = "frm_SI";
            this.Text = "Curso Sistema de informação";
            this.Load += new System.EventHandler(this.frm_SI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Sitemai;
        private Label l_Turma;
        private Label l_Ano;
        private MaskedTextBox txt_Turma2;
        private MaskedTextBox txt_Ano2;
    }
}