namespace app
{
    partial class frm_es
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
            this.l_Turma = new System.Windows.Forms.Label();
            this.l_ano = new System.Windows.Forms.Label();
            this.txt_turma = new System.Windows.Forms.MaskedTextBox();
            this.txt_ano = new System.Windows.Forms.MaskedTextBox();
            this.btn_cursoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Turma
            // 
            this.l_Turma.AutoSize = true;
            this.l_Turma.Location = new System.Drawing.Point(33, 59);
            this.l_Turma.Name = "l_Turma";
            this.l_Turma.Size = new System.Drawing.Size(41, 15);
            this.l_Turma.TabIndex = 1;
            this.l_Turma.Text = "Turma";
            // 
            // l_ano
            // 
            this.l_ano.AutoSize = true;
            this.l_ano.Location = new System.Drawing.Point(45, 122);
            this.l_ano.Name = "l_ano";
            this.l_ano.Size = new System.Drawing.Size(29, 15);
            this.l_ano.TabIndex = 2;
            this.l_ano.Text = "Ano";
            // 
            // txt_turma
            // 
            this.txt_turma.Location = new System.Drawing.Point(80, 59);
            this.txt_turma.Name = "txt_turma";
            this.txt_turma.Size = new System.Drawing.Size(100, 23);
            this.txt_turma.TabIndex = 3;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(80, 122);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 23);
            this.txt_ano.TabIndex = 4;
            // 
            // btn_cursoe
            // 
            this.btn_cursoe.Location = new System.Drawing.Point(80, 199);
            this.btn_cursoe.Name = "btn_cursoe";
            this.btn_cursoe.Size = new System.Drawing.Size(75, 23);
            this.btn_cursoe.TabIndex = 5;
            this.btn_cursoe.Text = "Confirmar";
            this.btn_cursoe.UseVisualStyleBackColor = true;
            this.btn_cursoe.Click += new System.EventHandler(this.btn_cursoe_Click);
            // 
            // frm_es
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cursoe);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_turma);
            this.Controls.Add(this.l_ano);
            this.Controls.Add(this.l_Turma);
            this.Name = "frm_es";
            this.Text = "Curso Engenharia de Software";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_Turma;
        private Label l_ano;
        private MaskedTextBox txt_turma;
        private MaskedTextBox txt_ano;
        private Button btn_cursoe;
    }
}