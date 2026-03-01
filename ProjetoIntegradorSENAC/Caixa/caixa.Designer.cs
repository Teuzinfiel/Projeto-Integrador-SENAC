namespace ProjetoIntegradorSENAC.Caixa
{
    partial class caixa
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dtgProdutos;
        private TextBox txtPesquisa;
        private FlowLayoutPanel flpCaixa;
        private Label lbItens;
        private Label lbPreço;
        private TextBox textDesconto;
        private Button btnCompra;
        private Button btnCancelar;
        private Button btnDevolucao;
        private Label lblPrecoTotal;
        private Label lblDesconto;
        private Label lblCaixa;
        private TableLayoutPanel mainLayout;
        private Panel leftPanel;
        private Panel rightPanel;
        private Panel topPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            topPanel = new Panel();
            lblCaixa = new Label();
            mainLayout = new TableLayoutPanel();
            leftPanel = new Panel();
            dtgProdutos = new DataGridView();
            txtPesquisa = new TextBox();
            rightPanel = new Panel();
            rightLayout = new TableLayoutPanel();
            flpCaixa = new FlowLayoutPanel();
            lblPrecoTotal = new Label();
            lbPreço = new Label();
            lblDesconto = new Label();
            textDesconto = new TextBox();
            btnCompra = new Button();
            btnCancelar = new Button();
            btnDevolucao = new Button();
            lbItens = new Label();
            lblItensTitulo = new Label();
            topPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            rightPanel.SuspendLayout();
            rightLayout.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(25, 25, 35);
            topPanel.Controls.Add(lblCaixa);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1400, 80);
            topPanel.TabIndex = 1;
            // 
            // lblCaixa
            // 
            lblCaixa.AutoSize = true;
            lblCaixa.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblCaixa.ForeColor = Color.FromArgb(0, 150, 255);
            lblCaixa.Location = new Point(25, 15);
            lblCaixa.Name = "lblCaixa";
            lblCaixa.Size = new Size(118, 51);
            lblCaixa.TabIndex = 0;
            lblCaixa.Text = "Caixa";
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            mainLayout.Controls.Add(leftPanel, 0, 0);
            mainLayout.Controls.Add(rightPanel, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 80);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1400, 720);
            mainLayout.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(30, 30, 40);
            leftPanel.Controls.Add(dtgProdutos);
            leftPanel.Controls.Add(txtPesquisa);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(3, 3);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(15);
            leftPanel.Size = new Size(834, 714);
            leftPanel.TabIndex = 0;
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToAddRows = false;
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProdutos.BackgroundColor = Color.FromArgb(35, 35, 45);
            dtgProdutos.BorderStyle = BorderStyle.None;
            dtgProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 150, 255);
            dtgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgProdutos.Dock = DockStyle.Fill;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.Location = new Point(15, 47);
            dtgProdutos.Margin = new Padding(0, 15, 0, 0);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 55);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgProdutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dtgProdutos.RowTemplate.Height = 40;
            dtgProdutos.Size = new Size(804, 652);
            dtgProdutos.TabIndex = 0;
            dtgProdutos.CellClick += dtgProdutos_CellClick;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Dock = DockStyle.Top;
            txtPesquisa.Font = new Font("Segoe UI", 14F);
            txtPesquisa.Location = new Point(15, 15);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Digite nome ou código do produto";
            txtPesquisa.Size = new Size(804, 32);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(40, 40, 50);
            rightPanel.Controls.Add(rightLayout);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(843, 3);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(20);
            rightPanel.Size = new Size(554, 714);
            rightPanel.TabIndex = 1;
            // ===============================
            // rightLayout
            // ===============================
            rightLayout = new TableLayoutPanel();
            rightLayout.ColumnCount = 1;
            rightLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rightLayout.Dock = DockStyle.Fill;
            rightLayout.Name = "rightLayout";
            rightLayout.RowCount = 10;

            // IMPORTANTE: limpar antes
            rightLayout.RowStyles.Clear();

            // Área da lista (agora proporcional, não fixa)
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 55F)); // flpCaixa

            rightLayout.RowStyles.Add(new RowStyle()); // lblPrecoTotal
            rightLayout.RowStyles.Add(new RowStyle()); // lbPreço
            rightLayout.RowStyles.Add(new RowStyle()); // lblDesconto
            rightLayout.RowStyles.Add(new RowStyle()); // textDesconto
            rightLayout.RowStyles.Add(new RowStyle()); // lblItensTitulo
            rightLayout.RowStyles.Add(new RowStyle()); // lbItens

            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F)); // btnCompra
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F)); // btnCancelar
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F)); // btnDevolucao

            // ===============================
            // CONTROLES
            // ===============================
            rightLayout.Controls.Add(flpCaixa, 0, 0);
            rightLayout.Controls.Add(lblPrecoTotal, 0, 1);
            rightLayout.Controls.Add(lbPreço, 0, 2);
            rightLayout.Controls.Add(lblDesconto, 0, 3);
            rightLayout.Controls.Add(textDesconto, 0, 4);
            rightLayout.Controls.Add(lblItensTitulo, 0, 5);
            rightLayout.Controls.Add(lbItens, 0, 6);
            rightLayout.Controls.Add(btnCompra, 0, 7);
            rightLayout.Controls.Add(btnCancelar, 0, 8);
            rightLayout.Controls.Add(btnDevolucao, 0, 9);

            // MUITO IMPORTANTE
            rightPanel.Controls.Clear();
            rightPanel.Controls.Add(rightLayout);
            // 
            // flpCaixa
            // 
            flpCaixa.AutoScroll = true;
            flpCaixa.BackColor = Color.FromArgb(45, 45, 60);
            flpCaixa.Dock = DockStyle.Fill;
            flpCaixa.Location = new Point(3, 3);
            flpCaixa.Name = "flpCaixa";
            flpCaixa.Padding = new Padding(10);
            flpCaixa.Size = new Size(508, 321);
            flpCaixa.TabIndex = 0;
            // 
            // lblPrecoTotal
            // 
            lblPrecoTotal.AutoSize = true;
            lblPrecoTotal.Font = new Font("Segoe UI", 14F);
            lblPrecoTotal.ForeColor = Color.White;
            lblPrecoTotal.Location = new Point(3, 327);
            lblPrecoTotal.Name = "lblPrecoTotal";
            lblPrecoTotal.Size = new Size(105, 25);
            lblPrecoTotal.TabIndex = 1;
            lblPrecoTotal.Text = "Preço Total";
            // 
            // lbPreço
            // 
            lbPreço.AutoSize = true;
            lbPreço.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lbPreço.ForeColor = Color.FromArgb(0, 150, 255);
            lbPreço.Location = new Point(3, 352);
            lbPreço.Name = "lbPreço";
            lbPreço.Size = new Size(155, 51);
            lbPreço.TabIndex = 2;
            lbPreço.Text = "R$ 0,00";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Font = new Font("Segoe UI", 14F);
            lblDesconto.ForeColor = Color.White;
            lblDesconto.Location = new Point(3, 403);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(124, 25);
            lblDesconto.TabIndex = 3;
            lblDesconto.Text = "Desconto (%)";
            // 
            // textDesconto
            // 
            textDesconto.Dock = DockStyle.Fill;
            textDesconto.Font = new Font("Segoe UI", 14F);
            textDesconto.Location = new Point(3, 474);
            textDesconto.Name = "textDesconto";
            textDesconto.Size = new Size(508, 32);
            textDesconto.TabIndex = 4;
            textDesconto.Text = "0";
            textDesconto.TextChanged += textDesconto_TextChanged;
            // 
            // btnCompra
            // 
            btnCompra.BackColor = Color.FromArgb(0, 150, 255);
            btnCompra.Dock = DockStyle.Fill;
            btnCompra.FlatAppearance.BorderSize = 0;
            btnCompra.FlatStyle = FlatStyle.Flat;
            btnCompra.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCompra.ForeColor = Color.White;
            btnCompra.Location = new Point(3, 547);
            btnCompra.Name = "btnCompra";
            btnCompra.Size = new Size(508, 49);
            btnCompra.TabIndex = 5;
            btnCompra.Text = "Finalizar Compra";
            btnCompra.UseVisualStyleBackColor = false;
            btnCompra.Click += btnCompra_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(200, 50, 50);
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(3, 602);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(508, 49);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar Compra";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnDevolucao
            // 
            btnDevolucao.BackColor = Color.FromArgb(0, 200, 150);
            btnDevolucao.Dock = DockStyle.Fill;
            btnDevolucao.FlatAppearance.BorderSize = 0;
            btnDevolucao.FlatStyle = FlatStyle.Flat;
            btnDevolucao.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDevolucao.ForeColor = Color.White;
            btnDevolucao.Location = new Point(3, 657);
            btnDevolucao.Name = "btnDevolucao";
            btnDevolucao.Size = new Size(508, 14);
            btnDevolucao.TabIndex = 7;
            btnDevolucao.Text = "Devolver Pedido";
            btnDevolucao.UseVisualStyleBackColor = false;
            btnDevolucao.Click += button1_Click;
            // 
            // lbItens
            // 
            lbItens.AutoSize = true;
            lbItens.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbItens.ForeColor = Color.FromArgb(0, 200, 83);
            lbItens.Location = new Point(0, 494);
            lbItens.Margin = new Padding(0, 5, 0, 0);
            lbItens.Name = "lbItens";
            lbItens.Size = new Size(23, 25);
            lbItens.TabIndex = 8;
            lbItens.Text = "0";
            // 
            // lblItensTitulo
            // 
            lblItensTitulo.AutoSize = true;
            lblItensTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblItensTitulo.ForeColor = Color.White;
            lblItensTitulo.Location = new Point(0, 443);
            lblItensTitulo.Margin = new Padding(0, 15, 0, 0);
            lblItensTitulo.Name = "lblItensTitulo";
            lblItensTitulo.Size = new Size(95, 20);
            lblItensTitulo.TabIndex = 0;
            lblItensTitulo.Text = "Itens Venda:";
            // 
            // caixa
            // 
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(1400, 800);
            Controls.Add(mainLayout);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "caixa";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            mainLayout.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            rightPanel.ResumeLayout(false);
            rightLayout.ResumeLayout(false);
            rightLayout.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel rightLayout;
        private Label lblItensTitulo;
    }
}