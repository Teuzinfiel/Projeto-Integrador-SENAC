namespace ProjetoIntegradorSENAC
{
    partial class recuperarEmail
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            picLoading = new PictureBox();
            lblCarregando = new Label();
            btnEnviar = new Button();
            bntVoltar = new Button();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panelTop = new Panel();
            btnMinimizar = new Button();
            btnSair = new Button();
            timerLoading = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(picLoading);
            panel1.Controls.Add(lblCarregando);
            panel1.Controls.Add(btnEnviar);
            panel1.Controls.Add(bntVoltar);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 68);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 639);
            panel1.TabIndex = 0;
            panel1.TabStop = true;
            // 
            // picLoading
            // 
            picLoading.Image = Properties.Resources.spinner;
            picLoading.Location = new Point(276, 487);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(42, 41);
            picLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            picLoading.TabIndex = 32;
            picLoading.TabStop = false;
            picLoading.Visible = false;
            // 
            // lblCarregando
            // 
            lblCarregando.AutoSize = true;
            lblCarregando.Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarregando.ForeColor = Color.FromArgb(180, 180, 190);
            lblCarregando.Location = new Point(158, 496);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(112, 23);
            lblCarregando.TabIndex = 31;
            lblCarregando.Text = "Carregando...";
            lblCarregando.Visible = false;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = SystemColors.Highlight;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(43, 308);
            btnEnviar.Margin = new Padding(3, 4, 3, 4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(397, 49);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar código";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnCadastro_Click;
            // 
            // bntVoltar
            // 
            bntVoltar.BackColor = Color.Transparent;
            bntVoltar.Cursor = Cursors.Hand;
            bntVoltar.FlatAppearance.BorderColor = SystemColors.Highlight;
            bntVoltar.FlatAppearance.BorderSize = 2;
            bntVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 60);
            bntVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            bntVoltar.FlatStyle = FlatStyle.Flat;
            bntVoltar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntVoltar.ForeColor = SystemColors.Highlight;
            bntVoltar.Location = new Point(43, 544);
            bntVoltar.Margin = new Padding(3, 4, 3, 4);
            bntVoltar.Name = "bntVoltar";
            bntVoltar.Size = new Size(223, 49);
            bntVoltar.TabIndex = 30;
            bntVoltar.Text = "Voltar para o login";
            bntVoltar.UseVisualStyleBackColor = false;
            bntVoltar.Click += bntVoltar_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(224, 224, 224);
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F);
            txtEmail.HideSelection = false;
            txtEmail.Location = new Point(43, 232);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite o seu e-mail";
            txtEmail.Size = new Size(397, 38);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(44, 107);
            label2.Name = "label2";
            label2.Size = new Size(400, 50);
            label2.TabIndex = 1;
            label2.Text = "Digite seu e-mail e enviaremos um código de \r\n      verificação para redefinir sua senha.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 23F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(54, 19);
            label1.Name = "label1";
            label1.Size = new Size(381, 45);
            label1.TabIndex = 0;
            label1.Text = "Esqueceu sua senha?";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(30, 30, 40);
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(393, 44);
            panelTop.TabIndex = 3;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(393, 0);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(62, 44);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(454, 0);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(62, 44);
            btnSair.TabIndex = 1;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // timerLoading
            // 
            timerLoading.Tick += timerLoading_Tick;
            // 
            // recuperarEmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(516, 720);
            Controls.Add(btnMinimizar);
            Controls.Add(panel1);
            Controls.Add(btnSair);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "recuperarEmail";
            Text = "Form1";
            Load += recuperarEmail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMinimizar;
        private Panel panelTop;
        private Button btnSair;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Button bntVoltar;
        private Button btnEnviar;
        private Label lblCarregando;
        private PictureBox picLoading;
        private System.Windows.Forms.Timer timerLoading;
    }
}