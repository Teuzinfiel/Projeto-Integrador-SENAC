namespace ProjetoIntegradorSENAC.personalizado
{
    partial class caixaDecisao
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
            BtnSim = new Button();
            lbMensagem = new Label();
            btnNao = new Button();
            btnSair = new Button();
            panel2 = new Panel();
            lbTitulo = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(BtnSim);
            panel1.Controls.Add(lbMensagem);
            panel1.Controls.Add(btnNao);
            panel1.Location = new Point(11, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 147);
            panel1.TabIndex = 44;
            // 
            // BtnSim
            // 
            BtnSim.BackColor = SystemColors.Highlight;
            BtnSim.FlatAppearance.BorderColor = SystemColors.Highlight;
            BtnSim.FlatAppearance.BorderSize = 2;
            BtnSim.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 60);
            BtnSim.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            BtnSim.FlatStyle = FlatStyle.Flat;
            BtnSim.Font = new Font("Franklin Gothic Medium", 15F);
            BtnSim.ForeColor = SystemColors.Control;
            BtnSim.Location = new Point(57, 87);
            BtnSim.Name = "BtnSim";
            BtnSim.Size = new Size(94, 44);
            BtnSim.TabIndex = 40;
            BtnSim.Text = "Sim";
            BtnSim.UseVisualStyleBackColor = false;
            BtnSim.Click += BtnSim_Click;
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMensagem.ForeColor = Color.FromArgb(180, 180, 190);
            lbMensagem.Location = new Point(17, 27);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(58, 23);
            lbMensagem.TabIndex = 38;
            lbMensagem.Text = "label1";
            // 
            // btnNao
            // 
            btnNao.BackColor = Color.Transparent;
            btnNao.FlatAppearance.BorderColor = Color.FromArgb(201, 0, 0);
            btnNao.FlatAppearance.BorderSize = 2;
            btnNao.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 60);
            btnNao.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            btnNao.FlatStyle = FlatStyle.Flat;
            btnNao.Font = new Font("Franklin Gothic Medium", 15F);
            btnNao.ForeColor = Color.FromArgb(201, 0, 0);
            btnNao.Location = new Point(247, 87);
            btnNao.Margin = new Padding(3, 4, 3, 4);
            btnNao.Name = "btnNao";
            btnNao.Size = new Size(94, 44);
            btnNao.TabIndex = 39;
            btnNao.Text = "Não";
            btnNao.UseVisualStyleBackColor = false;
            btnNao.Click += btnNao_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.Dock = DockStyle.Right;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(351, 0);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(62, 44);
            btnSair.TabIndex = 41;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(lbTitulo);
            panel2.Controls.Add(btnSair);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 44);
            panel2.TabIndex = 43;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Franklin Gothic Medium", 10.8F);
            lbTitulo.ForeColor = Color.FromArgb(180, 180, 190);
            lbTitulo.Location = new Point(11, 11);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(58, 23);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "label1";
            // 
            // caixaDecisao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(413, 219);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "caixaDecisao";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Escolha_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbMensagem;
        private Button btnNao;
        private Button btnSair;
        private Panel panel2;
        private Label lbTitulo;
        private Button BtnSim;
    }
}