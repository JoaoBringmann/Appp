namespace app
{
    partial class x
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
            this.txt6_nome = new System.Windows.Forms.Label();
            this.txt_disciplina = new System.Windows.Forms.Label();
            this.txt6_formacao = new System.Windows.Forms.Label();
            this.txt6_periodo = new System.Windows.Forms.Label();
            this.txt6_formacaoo = new System.Windows.Forms.MaskedTextBox();
            this.txt6_periodoo = new System.Windows.Forms.MaskedTextBox();
            this.txt6_nomee = new System.Windows.Forms.MaskedTextBox();
            this.txt6_disciplinaa = new System.Windows.Forms.MaskedTextBox();
            this.btn_professor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt6_nome
            // 
            this.txt6_nome.AutoSize = true;
            this.txt6_nome.Location = new System.Drawing.Point(32, 28);
            this.txt6_nome.Name = "txt6_nome";
            this.txt6_nome.Size = new System.Drawing.Size(40, 15);
            this.txt6_nome.TabIndex = 0;
            this.txt6_nome.Text = "Nome";
            // 
            // txt_disciplina
            // 
            this.txt_disciplina.AutoSize = true;
            this.txt_disciplina.Location = new System.Drawing.Point(14, 115);
            this.txt_disciplina.Name = "txt_disciplina";
            this.txt_disciplina.Size = new System.Drawing.Size(58, 15);
            this.txt_disciplina.TabIndex = 1;
            this.txt_disciplina.Text = "Disciplina";
            // 
            // txt6_formacao
            // 
            this.txt6_formacao.AutoSize = true;
            this.txt6_formacao.Location = new System.Drawing.Point(12, 57);
            this.txt6_formacao.Name = "txt6_formacao";
            this.txt6_formacao.Size = new System.Drawing.Size(60, 15);
            this.txt6_formacao.TabIndex = 2;
            this.txt6_formacao.Text = "Formação";
            // 
            // txt6_periodo
            // 
            this.txt6_periodo.AutoSize = true;
            this.txt6_periodo.Location = new System.Drawing.Point(24, 86);
            this.txt6_periodo.Name = "txt6_periodo";
            this.txt6_periodo.Size = new System.Drawing.Size(48, 15);
            this.txt6_periodo.TabIndex = 3;
            this.txt6_periodo.Text = "Periodo";
            // 
            // txt6_formacaoo
            // 
            this.txt6_formacaoo.Location = new System.Drawing.Point(78, 54);
            this.txt6_formacaoo.Name = "txt6_formacaoo";
            this.txt6_formacaoo.Size = new System.Drawing.Size(100, 23);
            this.txt6_formacaoo.TabIndex = 4;
            // 
            // txt6_periodoo
            // 
            this.txt6_periodoo.Location = new System.Drawing.Point(78, 83);
            this.txt6_periodoo.Name = "txt6_periodoo";
            this.txt6_periodoo.Size = new System.Drawing.Size(100, 23);
            this.txt6_periodoo.TabIndex = 5;
            // 
            // txt6_nomee
            // 
            this.txt6_nomee.Location = new System.Drawing.Point(78, 25);
            this.txt6_nomee.Name = "txt6_nomee";
            this.txt6_nomee.Size = new System.Drawing.Size(100, 23);
            this.txt6_nomee.TabIndex = 6;
            // 
            // txt6_disciplinaa
            // 
            this.txt6_disciplinaa.Location = new System.Drawing.Point(78, 112);
            this.txt6_disciplinaa.Name = "txt6_disciplinaa";
            this.txt6_disciplinaa.Size = new System.Drawing.Size(100, 23);
            this.txt6_disciplinaa.TabIndex = 7;
            // 
            // btn_professor
            // 
            this.btn_professor.Location = new System.Drawing.Point(265, 49);
            this.btn_professor.Name = "btn_professor";
            this.btn_professor.Size = new System.Drawing.Size(75, 23);
            this.btn_professor.TabIndex = 8;
            this.btn_professor.Text = "Confirmar";
            this.btn_professor.UseVisualStyleBackColor = true;
            this.btn_professor.Click += new System.EventHandler(this.btn_professor_Click);
            // 
            // x
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_professor);
            this.Controls.Add(this.txt6_disciplinaa);
            this.Controls.Add(this.txt6_nomee);
            this.Controls.Add(this.txt6_periodoo);
            this.Controls.Add(this.txt6_formacaoo);
            this.Controls.Add(this.txt6_periodo);
            this.Controls.Add(this.txt6_formacao);
            this.Controls.Add(this.txt_disciplina);
            this.Controls.Add(this.txt6_nome);
            this.Name = "x";
            this.Text = "Cadastro Professor";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txt6_nome;
        private Label txt_disciplina;
        private Label txt6_formacao;
        private Label txt6_periodo;
        private MaskedTextBox txt6_formacaoo;
        private MaskedTextBox txt6_periodoo;
        private MaskedTextBox txt6_nomee;
        private MaskedTextBox txt6_disciplinaa;
        private Button btn_professor;
    }
}