namespace ProjetoIntegradorSENAC.Dashboard
{
    partial class dashboardEstoque
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
            panelMain = new Panel();
            tlpMain = new TableLayoutPanel();
            tlpBot = new TableLayoutPanel();
            grafico1_dash = new GroupBox();
            grafico1 = new OxyPlot.WindowsForms.PlotView();
            lbTituloGrafico1 = new Label();
            grafico2_dash = new GroupBox();
            grafico2 = new OxyPlot.WindowsForms.PlotView();
            lbTituloGrafico2 = new Label();
            tlpMeio = new TableLayoutPanel();
            Info1_dash = new GroupBox();
            lbDash1 = new Label();
            label2 = new Label();
            Info2_dash = new GroupBox();
            lbDash2 = new Label();
            label3 = new Label();
            Info3_dash = new GroupBox();
            lbDash3 = new Label();
            label4 = new Label();
            Info4_dash = new GroupBox();
            lbDash4 = new Label();
            label5 = new Label();
            panelTop = new Panel();
            lbTempo = new Label();
            btnEstoque = new Button();
            btnComparacao = new Button();
            btnVendas = new Button();
            btnProdutos = new Button();
            lbTituloDash = new Label();
            panelMain.SuspendLayout();
            tlpMain.SuspendLayout();
            tlpBot.SuspendLayout();
            grafico1_dash.SuspendLayout();
            grafico2_dash.SuspendLayout();
            tlpMeio.SuspendLayout();
            Info1_dash.SuspendLayout();
            Info2_dash.SuspendLayout();
            Info3_dash.SuspendLayout();
            Info4_dash.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(45, 45, 60);
            panelMain.Controls.Add(tlpMain);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(10);
            panelMain.Size = new Size(1130, 829);
            panelMain.TabIndex = 49;
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.FromArgb(30, 30, 45);
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpBot, 0, 2);
            tlpMain.Controls.Add(tlpMeio, 0, 1);
            tlpMain.Controls.Add(panelTop, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(10, 10);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.5098F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.64706F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 57.84314F));
            tlpMain.Size = new Size(1110, 809);
            tlpMain.TabIndex = 39;
            // 
            // tlpBot
            // 
            tlpBot.ColumnCount = 2;
            tlpBot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBot.Controls.Add(grafico1_dash, 0, 0);
            tlpBot.Controls.Add(grafico2_dash, 1, 0);
            tlpBot.Dock = DockStyle.Fill;
            tlpBot.Location = new Point(3, 343);
            tlpBot.Name = "tlpBot";
            tlpBot.Padding = new Padding(10, 5, 10, 11);
            tlpBot.RowCount = 1;
            tlpBot.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBot.Size = new Size(1104, 463);
            tlpBot.TabIndex = 0;
            // 
            // grafico1_dash
            // 
            grafico1_dash.Controls.Add(grafico1);
            grafico1_dash.Controls.Add(lbTituloGrafico1);
            grafico1_dash.Dock = DockStyle.Fill;
            grafico1_dash.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grafico1_dash.ForeColor = SystemColors.Control;
            grafico1_dash.Location = new Point(10, 8);
            grafico1_dash.Margin = new Padding(0, 3, 5, 20);
            grafico1_dash.Name = "grafico1_dash";
            grafico1_dash.Size = new Size(537, 424);
            grafico1_dash.TabIndex = 5;
            grafico1_dash.TabStop = false;
            grafico1_dash.Text = "Gráfico1";
            // 
            // grafico1
            // 
            grafico1.Dock = DockStyle.Fill;
            grafico1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grafico1.Location = new Point(3, 48);
            grafico1.Name = "grafico1";
            grafico1.PanCursor = Cursors.Hand;
            grafico1.Size = new Size(531, 373);
            grafico1.TabIndex = 0;
            grafico1.Text = "plotView1";
            grafico1.ZoomHorizontalCursor = Cursors.SizeWE;
            grafico1.ZoomRectangleCursor = Cursors.SizeNWSE;
            grafico1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // lbTituloGrafico1
            // 
            lbTituloGrafico1.Dock = DockStyle.Top;
            lbTituloGrafico1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloGrafico1.Location = new Point(3, 23);
            lbTituloGrafico1.Name = "lbTituloGrafico1";
            lbTituloGrafico1.Size = new Size(531, 25);
            lbTituloGrafico1.TabIndex = 6;
            lbTituloGrafico1.Text = "label3";
            lbTituloGrafico1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grafico2_dash
            // 
            grafico2_dash.Controls.Add(grafico2);
            grafico2_dash.Controls.Add(lbTituloGrafico2);
            grafico2_dash.Dock = DockStyle.Fill;
            grafico2_dash.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grafico2_dash.ForeColor = SystemColors.Control;
            grafico2_dash.Location = new Point(557, 8);
            grafico2_dash.Margin = new Padding(5, 3, 0, 20);
            grafico2_dash.Name = "grafico2_dash";
            grafico2_dash.Size = new Size(537, 424);
            grafico2_dash.TabIndex = 6;
            grafico2_dash.TabStop = false;
            grafico2_dash.Text = "Gráfico2";
            // 
            // grafico2
            // 
            grafico2.Dock = DockStyle.Fill;
            grafico2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grafico2.Location = new Point(3, 48);
            grafico2.Name = "grafico2";
            grafico2.PanCursor = Cursors.Hand;
            grafico2.Size = new Size(531, 373);
            grafico2.TabIndex = 0;
            grafico2.Text = "plotView2";
            grafico2.ZoomHorizontalCursor = Cursors.SizeWE;
            grafico2.ZoomRectangleCursor = Cursors.SizeNWSE;
            grafico2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // lbTituloGrafico2
            // 
            lbTituloGrafico2.Dock = DockStyle.Top;
            lbTituloGrafico2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloGrafico2.Location = new Point(3, 23);
            lbTituloGrafico2.Name = "lbTituloGrafico2";
            lbTituloGrafico2.Size = new Size(531, 25);
            lbTituloGrafico2.TabIndex = 6;
            lbTituloGrafico2.Text = "label3";
            lbTituloGrafico2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpMeio
            // 
            tlpMeio.ColumnCount = 4;
            tlpMeio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMeio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMeio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMeio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMeio.Controls.Add(Info1_dash, 0, 0);
            tlpMeio.Controls.Add(Info2_dash, 1, 0);
            tlpMeio.Controls.Add(Info3_dash, 2, 0);
            tlpMeio.Controls.Add(Info4_dash, 3, 0);
            tlpMeio.Dock = DockStyle.Fill;
            tlpMeio.Location = new Point(3, 201);
            tlpMeio.Name = "tlpMeio";
            tlpMeio.Padding = new Padding(10, 5, 10, 11);
            tlpMeio.RowCount = 1;
            tlpMeio.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMeio.Size = new Size(1104, 136);
            tlpMeio.TabIndex = 1;
            // 
            // Info1_dash
            // 
            Info1_dash.BackgroundImageLayout = ImageLayout.None;
            Info1_dash.Controls.Add(lbDash1);
            Info1_dash.Controls.Add(label2);
            Info1_dash.Dock = DockStyle.Fill;
            Info1_dash.Font = new Font("Segoe UI", 7.8F);
            Info1_dash.ForeColor = SystemColors.Control;
            Info1_dash.Location = new Point(10, 8);
            Info1_dash.Margin = new Padding(0, 3, 5, 3);
            Info1_dash.Name = "Info1_dash";
            Info1_dash.Size = new Size(266, 114);
            Info1_dash.TabIndex = 3;
            Info1_dash.TabStop = false;
            // 
            // lbDash1
            // 
            lbDash1.Dock = DockStyle.Fill;
            lbDash1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDash1.ForeColor = Color.DodgerBlue;
            lbDash1.Location = new Point(3, 41);
            lbDash1.Name = "lbDash1";
            lbDash1.Size = new Size(260, 70);
            lbDash1.TabIndex = 0;
            lbDash1.Text = "lbDash1";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(260, 20);
            label2.TabIndex = 1;
            label2.Text = "Total de itens no estoque";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Info2_dash
            // 
            Info2_dash.Controls.Add(lbDash2);
            Info2_dash.Controls.Add(label3);
            Info2_dash.Dock = DockStyle.Fill;
            Info2_dash.Font = new Font("Segoe UI", 7.8F);
            Info2_dash.ForeColor = SystemColors.Control;
            Info2_dash.Location = new Point(286, 8);
            Info2_dash.Margin = new Padding(5, 3, 5, 3);
            Info2_dash.Name = "Info2_dash";
            Info2_dash.Size = new Size(261, 114);
            Info2_dash.TabIndex = 4;
            Info2_dash.TabStop = false;
            // 
            // lbDash2
            // 
            lbDash2.Dock = DockStyle.Fill;
            lbDash2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDash2.ForeColor = Color.DodgerBlue;
            lbDash2.Location = new Point(3, 41);
            lbDash2.Name = "lbDash2";
            lbDash2.Size = new Size(255, 70);
            lbDash2.TabIndex = 0;
            lbDash2.Text = "lbDash2";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 21);
            label3.Name = "label3";
            label3.Size = new Size(255, 20);
            label3.TabIndex = 2;
            label3.Text = "Custo total do estoque";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Info3_dash
            // 
            Info3_dash.Controls.Add(lbDash3);
            Info3_dash.Controls.Add(label4);
            Info3_dash.Dock = DockStyle.Fill;
            Info3_dash.Font = new Font("Segoe UI", 7.8F);
            Info3_dash.ForeColor = SystemColors.Control;
            Info3_dash.Location = new Point(557, 8);
            Info3_dash.Margin = new Padding(5, 3, 5, 3);
            Info3_dash.Name = "Info3_dash";
            Info3_dash.Size = new Size(261, 114);
            Info3_dash.TabIndex = 4;
            Info3_dash.TabStop = false;
            // 
            // lbDash3
            // 
            lbDash3.Dock = DockStyle.Fill;
            lbDash3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDash3.ForeColor = Color.DodgerBlue;
            lbDash3.Location = new Point(3, 62);
            lbDash3.Name = "lbDash3";
            lbDash3.Size = new Size(255, 49);
            lbDash3.TabIndex = 0;
            lbDash3.Text = "lbDash3";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 21);
            label4.Name = "label4";
            label4.Size = new Size(255, 41);
            label4.TabIndex = 2;
            label4.Text = "Valor do estoque (Lucro, Margem de lucro)";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Info4_dash
            // 
            Info4_dash.Controls.Add(lbDash4);
            Info4_dash.Controls.Add(label5);
            Info4_dash.Dock = DockStyle.Fill;
            Info4_dash.Font = new Font("Segoe UI", 7.8F);
            Info4_dash.ForeColor = SystemColors.Control;
            Info4_dash.Location = new Point(828, 8);
            Info4_dash.Margin = new Padding(5, 3, 0, 3);
            Info4_dash.Name = "Info4_dash";
            Info4_dash.Size = new Size(266, 114);
            Info4_dash.TabIndex = 4;
            Info4_dash.TabStop = false;
            // 
            // lbDash4
            // 
            lbDash4.Dock = DockStyle.Fill;
            lbDash4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDash4.ForeColor = Color.DodgerBlue;
            lbDash4.Location = new Point(3, 62);
            lbDash4.Name = "lbDash4";
            lbDash4.Size = new Size(260, 49);
            lbDash4.TabIndex = 0;
            lbDash4.Text = "lbDash4";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 21);
            label5.Name = "label5";
            label5.Size = new Size(260, 41);
            label5.TabIndex = 2;
            label5.Text = "Produto com maior quantidade no estoque";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(30, 30, 45);
            panelTop.Controls.Add(lbTempo);
            panelTop.Controls.Add(btnEstoque);
            panelTop.Controls.Add(btnComparacao);
            panelTop.Controls.Add(btnVendas);
            panelTop.Controls.Add(btnProdutos);
            panelTop.Controls.Add(lbTituloDash);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1104, 192);
            panelTop.TabIndex = 2;
            // 
            // lbTempo
            // 
            lbTempo.AutoSize = true;
            lbTempo.Font = new Font("Franklin Gothic Medium", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTempo.ForeColor = Color.Gainsboro;
            lbTempo.Location = new Point(10, 143);
            lbTempo.Name = "lbTempo";
            lbTempo.Size = new Size(512, 36);
            lbTempo.TabIndex = 49;
            lbTempo.Text = "Dados atualizados em: 00/00/000 00:00";
            // 
            // btnEstoque
            // 
            btnEstoque.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEstoque.BackColor = SystemColors.Highlight;
            btnEstoque.Cursor = Cursors.Hand;
            btnEstoque.FlatStyle = FlatStyle.Popup;
            btnEstoque.Font = new Font("Franklin Gothic Medium", 15F);
            btnEstoque.ForeColor = Color.White;
            btnEstoque.Location = new Point(770, 67);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(159, 53);
            btnEstoque.TabIndex = 47;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            // 
            // btnComparacao
            // 
            btnComparacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnComparacao.BackColor = SystemColors.Highlight;
            btnComparacao.Cursor = Cursors.Hand;
            btnComparacao.FlatStyle = FlatStyle.Popup;
            btnComparacao.Font = new Font("Franklin Gothic Medium", 15F);
            btnComparacao.ForeColor = Color.White;
            btnComparacao.Location = new Point(935, 126);
            btnComparacao.Name = "btnComparacao";
            btnComparacao.Size = new Size(159, 53);
            btnComparacao.TabIndex = 41;
            btnComparacao.Text = "Comparação";
            btnComparacao.UseVisualStyleBackColor = false;
            btnComparacao.Click += btnComparacao_Click;
            // 
            // btnVendas
            // 
            btnVendas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVendas.BackColor = SystemColors.Highlight;
            btnVendas.Cursor = Cursors.Hand;
            btnVendas.FlatStyle = FlatStyle.Popup;
            btnVendas.Font = new Font("Franklin Gothic Medium", 15F);
            btnVendas.ForeColor = Color.White;
            btnVendas.Location = new Point(770, 126);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(159, 53);
            btnVendas.TabIndex = 40;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProdutos.BackColor = SystemColors.Highlight;
            btnProdutos.Cursor = Cursors.Hand;
            btnProdutos.FlatStyle = FlatStyle.Popup;
            btnProdutos.Font = new Font("Franklin Gothic Medium", 15F);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Location = new Point(935, 67);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(159, 53);
            btnProdutos.TabIndex = 39;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // lbTituloDash
            // 
            lbTituloDash.Anchor = AnchorStyles.Top;
            lbTituloDash.Font = new Font("Franklin Gothic Medium", 23F);
            lbTituloDash.ForeColor = SystemColors.Highlight;
            lbTituloDash.Location = new Point(473, 14);
            lbTituloDash.Name = "lbTituloDash";
            lbTituloDash.Size = new Size(169, 45);
            lbTituloDash.TabIndex = 37;
            lbTituloDash.Text = "Estoque";
            lbTituloDash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dashboardEstoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 829);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboardEstoque";
            Text = "dashboardEstoque";
            Load += dashboardEstoque_Load;
            Shown += dashboardEstoque_Shown;
            panelMain.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            tlpBot.ResumeLayout(false);
            grafico1_dash.ResumeLayout(false);
            grafico2_dash.ResumeLayout(false);
            tlpMeio.ResumeLayout(false);
            Info1_dash.ResumeLayout(false);
            Info2_dash.ResumeLayout(false);
            Info3_dash.ResumeLayout(false);
            Info4_dash.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpBot;
        private GroupBox grafico1_dash;
        private OxyPlot.WindowsForms.PlotView grafico1;
        private GroupBox grafico2_dash;
        private OxyPlot.WindowsForms.PlotView grafico2;
        private TableLayoutPanel tlpMeio;
        private GroupBox Info1_dash;
        private Label lbDash1;
        private GroupBox Info2_dash;
        private Label lbDash2;
        private GroupBox Info3_dash;
        private Label lbDash3;
        private GroupBox Info4_dash;
        private Label lbDash4;
        private Panel panelTop;
        private Button btnEstoque;
        private Button btnComparacao;
        private Button btnVendas;
        private Button btnProdutos;
        private Label lbTituloDash;
        private Label lbTempo;
        private Label lbTituloGrafico1;
        private Label lbTituloGrafico2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}