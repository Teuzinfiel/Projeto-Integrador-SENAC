namespace ProjetoIntegradorSENAC.personalizado
{
    partial class caixaInformacao
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
            panel1 = new Panel();
            lbMensagem = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(lbMensagem);
            panel1.ForeColor = Color.FromArgb(180, 180, 190);
            panel1.Location = new Point(12, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 78);
            panel1.TabIndex = 41;
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMensagem.ForeColor = Color.FromArgb(180, 180, 190);
            lbMensagem.Location = new Point(10, 8);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(333, 60);
            lbMensagem.TabIndex = 38;
            lbMensagem.Text = "A senha deve ter no mínimo oito caracteres,\r\ncom pelo menos uma letra maiúscula e minúscula\r\num caractere númerico e um caractere especial.";
            // 
            // caixaInformacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(357, 91);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(180, 180, 190);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "caixaInformacao";
            Text = "caixaInformacao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbMensagem;
    }
}