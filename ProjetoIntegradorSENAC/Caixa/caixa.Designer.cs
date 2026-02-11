namespace ProjetoIntegradorSENAC.Caixa
{
    partial class caixa
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
            btnCancelar = new Button();
            btnCompra = new Button();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            txtPesquisa = new TextBox();
            flpCaixa = new FlowLayoutPanel();
            lbPreço = new Label();
            label5 = new Label();
            label1 = new Label();
            label6 = new Label();
            lbItens = new Label();
            label11 = new Label();
            label12 = new Label();
            textDesconto = new TextBox();
            button1 = new Button();
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
            dtgProdutos.Location = new Point(12, 205);
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
            dtgProdutos.Size = new Size(562, 267);
            dtgProdutos.TabIndex = 6;
            dtgProdutos.CellClick += dtgProdutos_CellClick;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(198, 500);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(185, 35);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar Compra";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCompra
            // 
            btnCompra.BackColor = SystemColors.Highlight;
            btnCompra.FlatStyle = FlatStyle.Popup;
            btnCompra.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompra.ForeColor = Color.White;
            btnCompra.Location = new Point(389, 497);
            btnCompra.Name = "btnCompra";
            btnCompra.Size = new Size(185, 38);
            btnCompra.TabIndex = 10;
            btnCompra.Text = "Finalizar Compra";
            btnCompra.UseVisualStyleBackColor = false;
            btnCompra.Click += btnCompra_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 119);
            label7.Name = "label7";
            label7.Size = new Size(321, 39);
            label7.TabIndex = 27;
            label7.Text = "Pesquisa de produto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 25F);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(611, 17);
            label8.Name = "label8";
            label8.Size = new Size(96, 39);
            label8.TabIndex = 28;
            label8.Text = "Caixa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi Cond", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(144, 9);
            label4.Name = "label4";
            label4.Size = new Size(473, 47);
            label4.TabIndex = 29;
            label4.Text = "Adicione seus pedidos Aqui no";
            // 
            // txtPesquisa
            // 
            txtPesquisa.BackColor = Color.White;
            txtPesquisa.Font = new Font("Franklin Gothic Book", 20.25F);
            txtPesquisa.ForeColor = Color.FromArgb(40, 40, 50);
            txtPesquisa.Location = new Point(12, 161);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "  Digite nome ou código do Produto";
            txtPesquisa.Size = new Size(562, 38);
            txtPesquisa.TabIndex = 30;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // flpCaixa
            // 
            flpCaixa.BackColor = Color.FromArgb(30, 30, 40);
            flpCaixa.Location = new Point(592, 80);
            flpCaixa.Name = "flpCaixa";
            flpCaixa.Size = new Size(722, 455);
            flpCaixa.TabIndex = 31;
            // 
            // lbPreço
            // 
            lbPreço.AutoSize = true;
            lbPreço.Font = new Font("Franklin Gothic Medium Cond", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPreço.ForeColor = Color.White;
            lbPreço.Location = new Point(1175, 592);
            lbPreço.Name = "lbPreço";
            lbPreço.Size = new Size(63, 75);
            lbPreço.TabIndex = 32;
            lbPreço.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1103, 550);
            label5.Name = "label5";
            label5.Size = new Size(191, 47);
            label5.TabIndex = 33;
            label5.Text = "Preço Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1094, 592);
            label1.Name = "label1";
            label1.Size = new Size(95, 75);
            label1.TabIndex = 34;
            label1.Text = "R$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium Cond", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(837, 550);
            label6.Name = "label6";
            label6.Size = new Size(207, 47);
            label6.TabIndex = 35;
            label6.Text = "Items Totais:";
            // 
            // lbItens
            // 
            lbItens.AutoSize = true;
            lbItens.Font = new Font("Franklin Gothic Medium Cond", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItens.ForeColor = Color.White;
            lbItens.Location = new Point(840, 592);
            lbItens.Name = "lbItens";
            lbItens.Size = new Size(63, 75);
            lbItens.TabIndex = 36;
            lbItens.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Franklin Gothic Medium Cond", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(694, 592);
            label11.Name = "label11";
            label11.Size = new Size(73, 75);
            label11.TabIndex = 39;
            label11.Text = "%";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Franklin Gothic Medium Cond", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(600, 550);
            label12.Name = "label12";
            label12.Size = new Size(167, 47);
            label12.TabIndex = 38;
            label12.Text = "Desconto:";
            // 
            // textDesconto
            // 
            textDesconto.BackColor = Color.White;
            textDesconto.Font = new Font("Franklin Gothic Book", 20.25F);
            textDesconto.ForeColor = Color.FromArgb(40, 40, 50);
            textDesconto.Location = new Point(614, 610);
            textDesconto.Name = "textDesconto";
            textDesconto.Size = new Size(74, 38);
            textDesconto.TabIndex = 40;
            textDesconto.Text = "0";
            textDesconto.TextChanged += textDesconto_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(389, 592);
            button1.Name = "button1";
            button1.Size = new Size(185, 38);
            button1.TabIndex = 41;
            button1.Text = "Finalizar Compra";
            button1.UseVisualStyleBackColor = false;
            // 
            // caixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1326, 686);
            Controls.Add(button1);
            Controls.Add(flpCaixa);
            Controls.Add(textDesconto);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(lbItens);
            Controls.Add(label6);
            Controls.Add(lbPreço);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtPesquisa);
            Controls.Add(label4);
            Controls.Add(btnCompra);
            Controls.Add(btnCancelar);
            Controls.Add(dtgProdutos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "caixa";
            Text = "caixa";
            Load += caixa_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgProdutos;
        private Button btnCancelar;
        private Button btnCompra;
        private Label label7;
        private Label label8;
        private Label label4;
        private TextBox txtPesquisa;
        private FlowLayoutPanel flpCaixa;
        private Label lbPreço;
        private Label label5;
        private Label label1;
        private Label label6;
        private Label lbItens;
        private Label label11;
        private Label label12;
        private TextBox textDesconto;
        private Button button1;
    }
}