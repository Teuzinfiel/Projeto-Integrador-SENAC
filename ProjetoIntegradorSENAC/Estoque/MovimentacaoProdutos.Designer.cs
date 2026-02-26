namespace ProjetoIntegradorSENAC.Estoque
{
    partial class MovimentacaoProdutos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dtgMovimentacoes = new DataGridView();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            btnExportar = new Button();
            dtpDe = new DateTimePicker();
            dtpAte = new DateTimePicker();
            labelTitulo = new Label();
            lbPesquisar = new Label();
            label1 = new Label();
            label2 = new Label();
            cbTipoFiltro = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgMovimentacoes).BeginInit();
            SuspendLayout();
            // 
            // dtgMovimentacoes
            // 
            dtgMovimentacoes.AllowUserToAddRows = false;
            dtgMovimentacoes.AllowUserToDeleteRows = false;
            dtgMovimentacoes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgMovimentacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgMovimentacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgMovimentacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgMovimentacoes.BackgroundColor = Color.FromArgb(30, 30, 40);
            dtgMovimentacoes.BorderStyle = BorderStyle.None;
            dtgMovimentacoes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgMovimentacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgMovimentacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMovimentacoes.EnableHeadersVisualStyles = false;
            dtgMovimentacoes.GridColor = Color.FromArgb(60, 60, 80);
            dtgMovimentacoes.Location = new Point(12, 157);
            dtgMovimentacoes.MultiSelect = false;
            dtgMovimentacoes.Name = "dtgMovimentacoes";
            dtgMovimentacoes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgMovimentacoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dtgMovimentacoes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgMovimentacoes.RowTemplate.Height = 40;
            dtgMovimentacoes.Size = new Size(1302, 517);
            dtgMovimentacoes.TabIndex = 47;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top;
            txtPesquisar.Font = new Font("Franklin Gothic Book", 18F);
            txtPesquisar.Location = new Point(12, 112);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar por Produto";
            txtPesquisar.Size = new Size(398, 35);
            txtPesquisar.TabIndex = 48;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged_1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top;
            btnPesquisar.BackColor = SystemColors.Highlight;
            btnPesquisar.FlatStyle = FlatStyle.Popup;
            btnPesquisar.Font = new Font("Franklin Gothic Medium", 14F);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(416, 112);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(99, 32);
            btnPesquisar.TabIndex = 49;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top;
            btnExportar.BackColor = Color.FromArgb(80, 80, 120);
            btnExportar.FlatStyle = FlatStyle.Popup;
            btnExportar.Font = new Font("Franklin Gothic Medium", 14F);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(1194, 115);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(120, 31);
            btnExportar.TabIndex = 51;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // dtpDe
            // 
            dtpDe.Anchor = AnchorStyles.Top;
            dtpDe.Font = new Font("Franklin Gothic Book", 14F);
            dtpDe.Location = new Point(520, 115);
            dtpDe.Name = "dtpDe";
            dtpDe.Size = new Size(179, 29);
            dtpDe.TabIndex = 52;
            // 
            // dtpAte
            // 
            dtpAte.Anchor = AnchorStyles.Top;
            dtpAte.Font = new Font("Franklin Gothic Book", 14F);
            dtpAte.Location = new Point(705, 116);
            dtpAte.Name = "dtpAte";
            dtpAte.Size = new Size(192, 29);
            dtpAte.TabIndex = 53;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.Top;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Franklin Gothic Medium", 36F);
            labelTitulo.ForeColor = Color.FromArgb(180, 180, 190);
            labelTitulo.Location = new Point(368, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(596, 61);
            labelTitulo.TabIndex = 54;
            labelTitulo.Text = "Movimentações Do Estoque";
            // 
            // lbPesquisar
            // 
            lbPesquisar.Anchor = AnchorStyles.Top;
            lbPesquisar.AutoSize = true;
            lbPesquisar.Font = new Font("Franklin Gothic Medium", 12F);
            lbPesquisar.ForeColor = Color.FromArgb(180, 180, 190);
            lbPesquisar.Location = new Point(12, 87);
            lbPesquisar.Name = "lbPesquisar";
            lbPesquisar.Size = new Size(337, 21);
            lbPesquisar.TabIndex = 55;
            lbPesquisar.Text = "Pesquisar Movimentação com nome do produto";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F);
            label1.ForeColor = Color.FromArgb(180, 180, 190);
            label1.Location = new Point(520, 91);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 57;
            label1.Text = "De";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(705, 92);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 58;
            label2.Text = "Até";
            // 
            // cbTipoFiltro
            // 
            cbTipoFiltro.Anchor = AnchorStyles.Top;
            cbTipoFiltro.FlatStyle = FlatStyle.Popup;
            cbTipoFiltro.Font = new Font("Franklin Gothic Demi Cond", 13F);
            cbTipoFiltro.FormattingEnabled = true;
            cbTipoFiltro.Items.AddRange(new object[] { "DEVOLUCAO_CLIENTE", "AJUSTE_POSITIVO", "OUTROS" });
            cbTipoFiltro.Location = new Point(1019, 115);
            cbTipoFiltro.Name = "cbTipoFiltro";
            cbTipoFiltro.Size = new Size(169, 29);
            cbTipoFiltro.TabIndex = 59;
            cbTipoFiltro.SelectedIndexChanged += cbTipoFiltro_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(903, 116);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 60;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F);
            label3.ForeColor = Color.FromArgb(180, 180, 190);
            label3.Location = new Point(1019, 91);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 61;
            label3.Text = "Filtrar por tipo";
            // 
            // MovimentacaoProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1326, 686);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(cbTipoFiltro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnExportar);
            Controls.Add(dtpDe);
            Controls.Add(dtpAte);
            Controls.Add(labelTitulo);
            Controls.Add(lbPesquisar);
            Controls.Add(dtgMovimentacoes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MovimentacaoProdutos";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "MovimentacaoProdutos";
            Load += MovimentacaoProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgMovimentacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgMovimentacoes;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Button btnExportar;
        private DateTimePicker dtpDe;
        private DateTimePicker dtpAte;
        private Label labelTitulo;
        private Label lbPesquisar;
        private Label label1;
        private Label label2;
        private ComboBox cbTipoFiltro;
        private Button button1;
        private Label label3;
    }
}