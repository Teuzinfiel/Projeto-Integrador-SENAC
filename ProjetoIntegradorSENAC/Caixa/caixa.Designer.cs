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
        private TableLayoutPanel mainLayout;
        private Panel leftPanel;
        private Panel rightPanel;

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
            lblItensTitulo = new Label();
            lbItens = new Label();
            btnCompra = new Button();
            btnCancelar = new Button();
            btnDevolucao = new Button();
            mainLayout.SuspendLayout();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            rightPanel.SuspendLayout();
            rightLayout.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(45, 45, 60);
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            mainLayout.Controls.Add(leftPanel, 0, 0);
            mainLayout.Controls.Add(rightPanel, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(10);
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(989, 622);
            mainLayout.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(30, 30, 40);
            leftPanel.Controls.Add(dtgProdutos);
            leftPanel.Controls.Add(txtPesquisa);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(10, 10);
            leftPanel.Margin = new Padding(0, 0, 5, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(15);
            leftPanel.Size = new Size(576, 602);
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
            dtgProdutos.ColumnHeadersHeight = 29;
            dtgProdutos.Dock = DockStyle.Fill;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.Location = new Point(15, 47);
            dtgProdutos.Margin = new Padding(0, 15, 0, 0);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dtgProdutos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 55);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgProdutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dtgProdutos.RowTemplate.Height = 40;
            dtgProdutos.Size = new Size(546, 540);
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
            txtPesquisa.Size = new Size(546, 32);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(40, 40, 50);
            rightPanel.Controls.Add(rightLayout);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(596, 10);
            rightPanel.Margin = new Padding(5, 0, 0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(20);
            rightPanel.Size = new Size(383, 602);
            rightPanel.TabIndex = 1;
            // 
            // rightLayout
            // 
            rightLayout.ColumnCount = 1;
            rightLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
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
            rightLayout.Dock = DockStyle.Fill;
            rightLayout.Location = new Point(20, 20);
            rightLayout.Name = "rightLayout";
            rightLayout.RowCount = 10;
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            rightLayout.RowStyles.Add(new RowStyle());
            rightLayout.RowStyles.Add(new RowStyle());
            rightLayout.RowStyles.Add(new RowStyle());
            rightLayout.RowStyles.Add(new RowStyle());
            rightLayout.RowStyles.Add(new RowStyle());
            rightLayout.RowStyles.Add(new RowStyle());
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            rightLayout.Size = new Size(343, 562);
            rightLayout.TabIndex = 0;
            // 
            // flpCaixa
            // 
            flpCaixa.AutoScroll = true;
            flpCaixa.BackColor = Color.FromArgb(45, 45, 60);
            flpCaixa.Dock = DockStyle.Fill;
            flpCaixa.Location = new Point(3, 3);
            flpCaixa.Name = "flpCaixa";
            flpCaixa.Padding = new Padding(10);
            flpCaixa.Size = new Size(337, 187);
            flpCaixa.TabIndex = 0;
            // 
            // lblPrecoTotal
            // 
            lblPrecoTotal.AutoSize = true;
            lblPrecoTotal.Font = new Font("Segoe UI", 14F);
            lblPrecoTotal.ForeColor = Color.White;
            lblPrecoTotal.Location = new Point(3, 193);
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
            lbPreço.Location = new Point(3, 218);
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
            lblDesconto.Location = new Point(3, 269);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(124, 25);
            lblDesconto.TabIndex = 3;
            lblDesconto.Text = "Desconto (%)";
            // 
            // textDesconto
            // 
            textDesconto.Dock = DockStyle.Fill;
            textDesconto.Font = new Font("Segoe UI", 14F);
            textDesconto.Location = new Point(3, 297);
            textDesconto.Name = "textDesconto";
            textDesconto.Size = new Size(337, 32);
            textDesconto.TabIndex = 4;
            textDesconto.Text = "0";
            textDesconto.TextChanged += textDesconto_TextChanged;
            // 
            // lblItensTitulo
            // 
            lblItensTitulo.AutoSize = true;
            lblItensTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblItensTitulo.ForeColor = Color.White;
            lblItensTitulo.Location = new Point(0, 347);
            lblItensTitulo.Margin = new Padding(0, 15, 0, 0);
            lblItensTitulo.Name = "lblItensTitulo";
            lblItensTitulo.Size = new Size(95, 20);
            lblItensTitulo.TabIndex = 0;
            lblItensTitulo.Text = "Itens Venda:";
            // 
            // lbItens
            // 
            lbItens.AutoSize = true;
            lbItens.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbItens.ForeColor = Color.FromArgb(0, 200, 83);
            lbItens.Location = new Point(0, 372);
            lbItens.Margin = new Padding(0, 5, 0, 0);
            lbItens.Name = "lbItens";
            lbItens.Size = new Size(23, 25);
            lbItens.TabIndex = 8;
            lbItens.Text = "0";
            // 
            // btnCompra
            // 
            btnCompra.BackColor = Color.FromArgb(0, 150, 255);
            btnCompra.Dock = DockStyle.Fill;
            btnCompra.FlatAppearance.BorderSize = 0;
            btnCompra.FlatStyle = FlatStyle.Flat;
            btnCompra.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCompra.ForeColor = Color.White;
            btnCompra.Location = new Point(3, 400);
            btnCompra.Name = "btnCompra";
            btnCompra.Size = new Size(337, 49);
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
            btnCancelar.Location = new Point(3, 455);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(337, 49);
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
            btnDevolucao.Location = new Point(3, 510);
            btnDevolucao.Name = "btnDevolucao";
            btnDevolucao.Size = new Size(337, 49);
            btnDevolucao.TabIndex = 7;
            btnDevolucao.Text = "Devolver Pedido";
            btnDevolucao.UseVisualStyleBackColor = false;
            btnDevolucao.Click += button1_Click;
            // 
            // caixa
            // 
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(989, 622);
            Controls.Add(mainLayout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "caixa";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
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