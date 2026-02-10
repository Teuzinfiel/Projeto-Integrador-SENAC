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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dtgProdutos = new DataGridView();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            lbDescricao = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            SuspendLayout();
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToAddRows = false;
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProdutos.BackgroundColor = Color.FromArgb(30, 30, 40);
            dtgProdutos.BorderStyle = BorderStyle.None;
            dtgProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle6.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.FromArgb(60, 60, 80);
            dtgProdutos.Location = new Point(12, 125);
            dtgProdutos.MultiSelect = false;
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle7.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle8.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dtgProdutos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dtgProdutos.RowTemplate.Height = 40;
            dtgProdutos.Size = new Size(1302, 549);
            dtgProdutos.TabIndex = 44;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.Highlight;
            btnPesquisar.FlatStyle = FlatStyle.Popup;
            btnPesquisar.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(759, 81);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(132, 38);
            btnPesquisar.TabIndex = 46;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BackColor = Color.White;
            txtPesquisa.Font = new Font("Franklin Gothic Book", 20.25F);
            txtPesquisa.ForeColor = Color.FromArgb(40, 40, 50);
            txtPesquisa.Location = new Point(81, 81);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "  Digite nome ou código do Produto";
            txtPesquisa.Size = new Size(672, 38);
            txtPesquisa.TabIndex = 45;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 81);
            button2.Name = "button2";
            button2.Size = new Size(63, 38);
            button2.TabIndex = 48;
            button2.Text = "\u007f";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Franklin Gothic Medium", 17F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(897, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(417, 37);
            comboBox1.TabIndex = 49;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Franklin Gothic Medium", 12F);
            lbDescricao.ForeColor = Color.FromArgb(180, 180, 190);
            lbDescricao.Location = new Point(81, 57);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(135, 21);
            lbDescricao.TabIndex = 51;
            lbDescricao.Text = "Pesquisar produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F);
            label1.ForeColor = Color.FromArgb(180, 180, 190);
            label1.Location = new Point(897, 57);
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
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 53;
            label2.Text = "Ordem";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 23F);
            label3.ForeColor = Color.FromArgb(180, 180, 190);
            label3.Location = new Point(470, 9);
            label3.Name = "label3";
            label3.Size = new Size(378, 37);
            label3.TabIndex = 61;
            label3.Text = "Informações sobre Estoque";
            // 
            // estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1326, 686);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbDescricao);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisa);
            Controls.Add(dtgProdutos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "estoque";
            Text = "estoque";
            Load += estoque_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgProdutos;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private Button button2;
        private ComboBox comboBox1;
        private Label lbDescricao;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}