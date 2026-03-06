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
            btnExportar = new Button();
            dtpDe = new DateTimePicker();
            dtpAte = new DateTimePicker();
            lbPesquisar = new Label();
            label1 = new Label();
            label2 = new Label();
            cbTipoFiltro = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            panelMain = new Panel();
            label4 = new Label();
            lbTituloDash = new Label();
            panelForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgMovimentacoes).BeginInit();
            panelMain.SuspendLayout();
            panelForm.SuspendLayout();
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
            dtgMovimentacoes.BackgroundColor = Color.FromArgb(30, 35, 45);
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
            dtgMovimentacoes.Location = new Point(16, 130);
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
            dtgMovimentacoes.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dtgMovimentacoes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgMovimentacoes.RowTemplate.Height = 40;
            dtgMovimentacoes.Size = new Size(942, 452);
            dtgMovimentacoes.TabIndex = 47;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Microsoft Sans Serif", 12F);
            txtPesquisar.Location = new Point(16, 88);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar por Produto";
            txtPesquisar.Size = new Size(294, 26);
            txtPesquisar.TabIndex = 48;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged_1;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportar.BackColor = Color.FromArgb(80, 80, 120);
            btnExportar.FlatStyle = FlatStyle.Popup;
            btnExportar.Font = new Font("Franklin Gothic Medium", 14F);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(866, 83);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(92, 31);
            btnExportar.TabIndex = 51;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // dtpDe
            // 
            dtpDe.CalendarFont = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDe.Font = new Font("Microsoft Sans Serif", 12F);
            dtpDe.Location = new Point(324, 88);
            dtpDe.Name = "dtpDe";
            dtpDe.Size = new Size(122, 26);
            dtpDe.TabIndex = 52;
            // 
            // dtpAte
            // 
            dtpAte.Font = new Font("Microsoft Sans Serif", 12F);
            dtpAte.Location = new Point(452, 88);
            dtpAte.Name = "dtpAte";
            dtpAte.Size = new Size(113, 26);
            dtpAte.TabIndex = 53;
            // 
            // lbPesquisar
            // 
            lbPesquisar.AutoSize = true;
            lbPesquisar.Font = new Font("Franklin Gothic Medium", 10F);
            lbPesquisar.ForeColor = Color.FromArgb(180, 180, 190);
            lbPesquisar.Location = new Point(16, 64);
            lbPesquisar.Name = "lbPesquisar";
            lbPesquisar.Size = new Size(294, 18);
            lbPesquisar.TabIndex = 55;
            lbPesquisar.Text = "Pesquisar Movimentação com nome do produto";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F);
            label1.ForeColor = Color.FromArgb(180, 180, 190);
            label1.Location = new Point(188, 64);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 57;
            label1.Text = "De";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(452, 64);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 58;
            label2.Text = "Até";
            // 
            // cbTipoFiltro
            // 
            cbTipoFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbTipoFiltro.FlatStyle = FlatStyle.Popup;
            cbTipoFiltro.Font = new Font("Microsoft Sans Serif", 11F);
            cbTipoFiltro.FormattingEnabled = true;
            cbTipoFiltro.Items.AddRange(new object[] { "DEVOLUCAO_CLIENTE", "AJUSTE_POSITIVO", "OUTROS" });
            cbTipoFiltro.Location = new Point(581, 88);
            cbTipoFiltro.Name = "cbTipoFiltro";
            cbTipoFiltro.Size = new Size(156, 26);
            cbTipoFiltro.TabIndex = 59;
            cbTipoFiltro.SelectedIndexChanged += cbTipoFiltro_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(743, 85);
            button1.Name = "button1";
            button1.Size = new Size(117, 30);
            button1.TabIndex = 60;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F);
            label3.ForeColor = Color.FromArgb(180, 180, 190);
            label3.Location = new Point(581, 61);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 61;
            label3.Text = "Filtrar por tipo";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(30, 30, 45);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(lbTituloDash);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(lbPesquisar);
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(cbTipoFiltro);
            panelMain.Controls.Add(dtpAte);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(dtpDe);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(btnExportar);
            panelMain.Controls.Add(txtPesquisar);
            panelMain.Controls.Add(dtgMovimentacoes);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(9, 8);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(971, 606);
            panelMain.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 12F);
            label4.ForeColor = Color.FromArgb(180, 180, 190);
            label4.Location = new Point(324, 64);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 63;
            label4.Text = "De";
            // 
            // lbTituloDash
            // 
            lbTituloDash.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTituloDash.Font = new Font("Franklin Gothic Medium", 23F);
            lbTituloDash.ForeColor = SystemColors.Highlight;
            lbTituloDash.Location = new Point(232, 12);
            lbTituloDash.Name = "lbTituloDash";
            lbTituloDash.Size = new Size(505, 34);
            lbTituloDash.TabIndex = 62;
            lbTituloDash.Text = "Movimentações Do Estoque";
            lbTituloDash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(panelMain);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 0);
            panelForm.Margin = new Padding(3, 2, 3, 2);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(9, 8, 9, 8);
            panelForm.Size = new Size(989, 622);
            panelForm.TabIndex = 63;
            // 
            // MovimentacaoProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(989, 622);
            Controls.Add(panelForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MovimentacaoProdutos";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "MovimentacaoProdutos";
            Load += MovimentacaoProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgMovimentacoes).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtgMovimentacoes;
        private TextBox txtPesquisar;
        private Button btnExportar;
        private DateTimePicker dtpDe;
        private DateTimePicker dtpAte;
        private Label lbPesquisar;
        private Label label1;
        private Label label2;
        private ComboBox cbTipoFiltro;
        private Button button1;
        private Label label3;
        private Panel panelMain;
        private Panel panelForm;
        private Label lbTituloDash;
        private Label label4;
    }
}