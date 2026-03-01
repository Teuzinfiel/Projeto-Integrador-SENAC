namespace ProjetoIntegradorSENAC
{
    partial class frmChat
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelTop;
        private Button btnMinimizar;
        private Button btnSair;

        private Panel panel2;
        private Panel panel1;

        private Label labelTitulo;
        private FlowLayoutPanel flowChat;
        private TextBox txtMensagem;
        private Button btnEnviar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelTop = new Panel();
            btnMinimizar = new Button();
            btnSair = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            flowChat = new FlowLayoutPanel();
            txtMensagem = new TextBox();
            btnEnviar = new Button();
            labelTitulo = new Label();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(30, 30, 40);
            panelTop.Controls.Add(btnMinimizar);
            panelTop.Controls.Add(btnSair);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(360, 32);
            panelTop.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(280, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(40, 32);
            btnMinimizar.TabIndex = 0;
            btnMinimizar.Text = "-";
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Right;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(320, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(40, 32);
            btnSair.TabIndex = 1;
            btnSair.Text = "X";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 32);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(18, 15, 18, 15);
            panel2.Size = new Size(360, 442);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(flowChat);
            panel1.Controls.Add(txtMensagem);
            panel1.Controls.Add(btnEnviar);
            panel1.Controls.Add(labelTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(18, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 412);
            panel1.TabIndex = 0;
            // 
            // flowChat
            // 
            flowChat.AutoScroll = true;
            flowChat.BackColor = Color.FromArgb(30, 30, 40);
            flowChat.Dock = DockStyle.Fill;
            flowChat.FlowDirection = FlowDirection.TopDown;
            flowChat.Location = new Point(0, 40);
            flowChat.Name = "flowChat";
            flowChat.Padding = new Padding(10);
            flowChat.Size = new Size(324, 316);
            flowChat.TabIndex = 0;
            flowChat.WrapContents = false;
            // 
            // txtMensagem
            // 
            txtMensagem.BackColor = Color.FromArgb(50, 50, 60);
            txtMensagem.BorderStyle = BorderStyle.None;
            txtMensagem.Dock = DockStyle.Bottom;
            txtMensagem.Font = new Font("Microsoft Sans Serif", 10F);
            txtMensagem.ForeColor = Color.White;
            txtMensagem.Location = new Point(0, 356);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(324, 16);
            txtMensagem.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = SystemColors.Highlight;
            btnEnviar.Dock = DockStyle.Bottom;
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Franklin Gothic Medium", 12F);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(0, 372);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(324, 40);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            // 
            // labelTitulo
            // 
            labelTitulo.Dock = DockStyle.Top;
            labelTitulo.Font = new Font("Microsoft Sans Serif", 14F);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(0, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(324, 40);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Chat Interno";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChat
            // 
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(360, 474);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChat";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmChat_Load;
            panelTop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
    }
}