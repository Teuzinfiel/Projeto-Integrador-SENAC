namespace ProjetoIntegradorSENAC.Estoque
{
    partial class estoque
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dtgProdutos = new DataGridView();
            txtPesquisa = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            lbDescricao = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelForm = new Panel();
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            panelForm.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToAddRows = false;
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProdutos.BackgroundColor = Color.FromArgb(30, 35, 45);
            dtgProdutos.BorderStyle = BorderStyle.None;
            dtgProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.FromArgb(60, 60, 80);
            dtgProdutos.Location = new Point(10, 116);
            dtgProdutos.MultiSelect = false;
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgProdutos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle5.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dtgProdutos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgProdutos.RowTemplate.Height = 40;
            dtgProdutos.Size = new Size(950, 478);
            dtgProdutos.TabIndex = 44;
            dtgProdutos.CellClick += dtgProdutos_CellClick;
            dtgProdutos.CellFormatting += dtgProdutos_CellFormatting;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.BackColor = Color.White;
            txtPesquisa.Font = new Font("Microsoft Sans Serif", 20.25F);
            txtPesquisa.ForeColor = Color.FromArgb(40, 40, 50);
            txtPesquisa.Location = new Point(79, 72);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "  Digite nome ou código do Produto";
            txtPesquisa.Size = new Size(434, 38);
            txtPesquisa.TabIndex = 45;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 72);
            button2.Name = "button2";
            button2.Size = new Size(63, 39);
            button2.TabIndex = 48;
            button2.Text = "\u007f";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Franklin Gothic Medium", 17F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(705, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 37);
            comboBox1.TabIndex = 49;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Franklin Gothic Medium", 12F);
            lbDescricao.ForeColor = Color.FromArgb(180, 180, 190);
            lbDescricao.Location = new Point(76, 48);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(135, 21);
            lbDescricao.TabIndex = 51;
            lbDescricao.Text = "Pesquisar produto";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F);
            label1.ForeColor = Color.FromArgb(180, 180, 190);
            label1.Location = new Point(705, 48);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 52;
            label1.Text = "Filtrar por situação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F);
            label2.ForeColor = Color.FromArgb(180, 180, 190);
            label2.Location = new Point(10, 48);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 53;
            label2.Text = "Ordem";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Franklin Gothic Medium", 23F);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(289, 14);
            label3.Name = "label3";
            label3.Size = new Size(417, 32);
            label3.TabIndex = 61;
            label3.Text = "Informações sobre Estoque";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            panelForm.TabIndex = 62;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(30, 30, 45);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(dtgProdutos);
            panelMain.Controls.Add(comboBox1);
            panelMain.Controls.Add(lbDescricao);
            panelMain.Controls.Add(txtPesquisa);
            panelMain.Controls.Add(button2);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(9, 8);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(971, 606);
            panelMain.TabIndex = 62;
            // 
            // estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(989, 622);
            Controls.Add(panelForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "estoque";
            Text = "estoque";
            Load += estoque_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            panelForm.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtgProdutos;
        private TextBox txtPesquisa;
        private Button button2;
        private ComboBox comboBox1;
        private Label lbDescricao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panelForm;
        private Panel panelMain;
    }
}