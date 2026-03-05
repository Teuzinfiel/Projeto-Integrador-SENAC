namespace ProjetoIntegradorSENAC.Dashboard
{
    partial class dashboardVenda
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
            Info1_dash = new GroupBox();
            lbDash1 = new Label();
            label3 = new Label();
            Info2_dash = new GroupBox();
            lbDash2 = new Label();
            label1 = new Label();
            Info3_dash = new GroupBox();
            lbDash3 = new Label();
            label2 = new Label();
            Info4_dash = new GroupBox();
            lbDash4 = new Label();
            label4 = new Label();
            grafico1_dash = new GroupBox();
            grafico1 = new OxyPlot.WindowsForms.PlotView();
            lbTituloGrafico1 = new Label();
            grafico2_dash = new GroupBox();
            grafico2 = new OxyPlot.WindowsForms.PlotView();
            lbTituloGrafico2 = new Label();
            btnProdutos = new Button();
            btnVendas = new Button();
            btnComparacao = new Button();
            maskedInicio = new MaskedTextBox();
            maskedFim = new MaskedTextBox();
            btnBuscar = new Button();
            lbTempo1 = new Label();
            lbTempo2 = new Label();
            panelForm = new Panel();
            tlpMain = new TableLayoutPanel();
            tlpBot = new TableLayoutPanel();
            tlpMeio = new TableLayoutPanel();
            panelTop = new Panel();
            btnEstoque = new Button();
            lbTituloDash = new Label();
            Info1_dash.SuspendLayout();
            Info2_dash.SuspendLayout();
            Info3_dash.SuspendLayout();
            Info4_dash.SuspendLayout();
            grafico1_dash.SuspendLayout();
            grafico2_dash.SuspendLayout();
            panelForm.SuspendLayout();
            tlpMain.SuspendLayout();
            tlpBot.SuspendLayout();
            tlpMeio.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // Info1_dash
            // 
            Info1_dash.BackgroundImageLayout = ImageLayout.None;
            Info1_dash.Controls.Add(lbDash1);
            Info1_dash.Controls.Add(label3);
            Info1_dash.Dock = DockStyle.Fill;
            Info1_dash.Font = new Font("Segoe UI", 7.8F);
            Info1_dash.ForeColor = SystemColors.Control;
            Info1_dash.Location = new Point(10, 8);
            Info1_dash.Margin = new Padding(0, 3, 5, 3);
            Info1_dash.Name = "Info1_dash";
            Info1_dash.Padding = new Padding(3, 0, 3, 3);
            Info1_dash.Size = new Size(266, 114);
            Info1_dash.TabIndex = 3;
            Info1_dash.TabStop = false;
            // 
            // lbDash1
            // 
            lbDash1.Dock = DockStyle.Fill;
            lbDash1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDash1.ForeColor = Color.DodgerBlue;
            lbDash1.Location = new Point(3, 35);
            lbDash1.Name = "lbDash1";
            lbDash1.Size = new Size(260, 76);
            lbDash1.TabIndex = 0;
            lbDash1.Text = "lbDash1";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 18);
            label3.Name = "label3";
            label3.Size = new Size(260, 17);
            label3.TabIndex = 3;
            label3.Text = "Total de vendas (Lucro, Quantidade)";
            // 
            // Info2_dash
            // 
            Info2_dash.Controls.Add(lbDash2);
            Info2_dash.Controls.Add(label1);
            Info2_dash.Dock = DockStyle.Fill;
            Info2_dash.FlatStyle = FlatStyle.Flat;
            Info2_dash.Font = new Font("Segoe UI", 7.8F);
            Info2_dash.ForeColor = SystemColors.Control;
            Info2_dash.Location = new Point(286, 8);
            Info2_dash.Margin = new Padding(5, 3, 5, 3);
            Info2_dash.Name = "Info2_dash";
            Info2_dash.Padding = new Padding(3, 0, 3, 3);
            Info2_dash.Size = new Size(261, 114);
            Info2_dash.TabIndex = 4;
            Info2_dash.TabStop = false;
            // 
            // lbDash2
            // 
            lbDash2.Dock = DockStyle.Fill;
            lbDash2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDash2.ForeColor = Color.DodgerBlue;
            lbDash2.Location = new Point(3, 59);
            lbDash2.Name = "lbDash2";
            lbDash2.Size = new Size(255, 52);
            lbDash2.TabIndex = 0;
            lbDash2.Text = "lbDash2";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(255, 41);
            label1.TabIndex = 3;
            label1.Text = "Categoria líder finaceiro (Lucro, Quantidade)";
            // 
            // Info3_dash
            // 
            Info3_dash.Controls.Add(lbDash3);
            Info3_dash.Controls.Add(label2);
            Info3_dash.Dock = DockStyle.Fill;
            Info3_dash.Font = new Font("Segoe UI", 7.8F);
            Info3_dash.ForeColor = SystemColors.Control;
            Info3_dash.Location = new Point(557, 8);
            Info3_dash.Margin = new Padding(5, 3, 5, 3);
            Info3_dash.Name = "Info3_dash";
            Info3_dash.Padding = new Padding(3, 0, 3, 3);
            Info3_dash.Size = new Size(261, 114);
            Info3_dash.TabIndex = 4;
            Info3_dash.TabStop = false;
            // 
            // lbDash3
            // 
            lbDash3.Dock = DockStyle.Fill;
            lbDash3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDash3.ForeColor = Color.DodgerBlue;
            lbDash3.Location = new Point(3, 38);
            lbDash3.Name = "lbDash3";
            lbDash3.Size = new Size(255, 73);
            lbDash3.TabIndex = 0;
            lbDash3.Text = "lbDash3";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(255, 20);
            label2.TabIndex = 3;
            label2.Text = "Ticket médio de vendas";
            // 
            // Info4_dash
            // 
            Info4_dash.Controls.Add(lbDash4);
            Info4_dash.Controls.Add(label4);
            Info4_dash.Dock = DockStyle.Fill;
            Info4_dash.Font = new Font("Segoe UI", 7.8F);
            Info4_dash.ForeColor = SystemColors.Control;
            Info4_dash.Location = new Point(828, 8);
            Info4_dash.Margin = new Padding(5, 3, 0, 3);
            Info4_dash.Name = "Info4_dash";
            Info4_dash.Padding = new Padding(3, 0, 3, 3);
            Info4_dash.Size = new Size(266, 114);
            Info4_dash.TabIndex = 4;
            Info4_dash.TabStop = false;
            // 
            // lbDash4
            // 
            lbDash4.Dock = DockStyle.Fill;
            lbDash4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDash4.ForeColor = Color.DodgerBlue;
            lbDash4.Location = new Point(3, 59);
            lbDash4.Name = "lbDash4";
            lbDash4.Size = new Size(260, 52);
            lbDash4.TabIndex = 0;
            lbDash4.Text = "lbDash4";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(3, 18);
            label4.Name = "label4";
            label4.Size = new Size(260, 41);
            label4.TabIndex = 3;
            label4.Text = "Média de produtos vendidos por pedido";
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
            grafico1_dash.Size = new Size(537, 423);
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
            grafico1.Size = new Size(531, 372);
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
            lbTituloGrafico1.TabIndex = 3;
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
            grafico2_dash.Size = new Size(537, 423);
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
            grafico2.Size = new Size(531, 372);
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
            lbTituloGrafico2.TabIndex = 3;
            lbTituloGrafico2.Text = "label3";
            lbTituloGrafico2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProdutos
            // 
            btnProdutos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProdutos.BackColor = SystemColors.Highlight;
            btnProdutos.Cursor = Cursors.Hand;
            btnProdutos.FlatStyle = FlatStyle.Popup;
            btnProdutos.Font = new Font("Franklin Gothic Medium", 15F);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Location = new Point(937, 72);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(159, 53);
            btnProdutos.TabIndex = 9;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnVendas
            // 
            btnVendas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVendas.BackColor = SystemColors.Highlight;
            btnVendas.Cursor = Cursors.Hand;
            btnVendas.FlatStyle = FlatStyle.Popup;
            btnVendas.Font = new Font("Franklin Gothic Medium", 15F);
            btnVendas.ForeColor = Color.White;
            btnVendas.Location = new Point(772, 132);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(159, 53);
            btnVendas.TabIndex = 11;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            // 
            // btnComparacao
            // 
            btnComparacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnComparacao.BackColor = SystemColors.Highlight;
            btnComparacao.Cursor = Cursors.Hand;
            btnComparacao.FlatStyle = FlatStyle.Popup;
            btnComparacao.Font = new Font("Franklin Gothic Medium", 15F);
            btnComparacao.ForeColor = Color.White;
            btnComparacao.Location = new Point(937, 131);
            btnComparacao.Name = "btnComparacao";
            btnComparacao.Size = new Size(159, 53);
            btnComparacao.TabIndex = 12;
            btnComparacao.Text = "Comparação";
            btnComparacao.UseVisualStyleBackColor = false;
            btnComparacao.Click += btnComparacao_Click;
            // 
            // maskedInicio
            // 
            maskedInicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            maskedInicio.Font = new Font("Microsoft Sans Serif", 20.25F);
            maskedInicio.Location = new Point(72, 131);
            maskedInicio.Margin = new Padding(3, 4, 3, 4);
            maskedInicio.Mask = "00/00/0000";
            maskedInicio.Name = "maskedInicio";
            maskedInicio.Size = new Size(179, 46);
            maskedInicio.TabIndex = 13;
            maskedInicio.ValidatingType = typeof(DateTime);
            // 
            // maskedFim
            // 
            maskedFim.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            maskedFim.Font = new Font("Microsoft Sans Serif", 20.25F);
            maskedFim.Location = new Point(322, 132);
            maskedFim.Margin = new Padding(3, 4, 3, 4);
            maskedFim.Mask = "00/00/0000";
            maskedFim.Name = "maskedFim";
            maskedFim.Size = new Size(179, 46);
            maskedFim.TabIndex = 14;
            maskedFim.ValidatingType = typeof(DateTime);
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Franklin Gothic Medium", 15F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(509, 131);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(142, 47);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lbTempo1
            // 
            lbTempo1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbTempo1.AutoSize = true;
            lbTempo1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTempo1.ForeColor = Color.White;
            lbTempo1.Location = new Point(10, 134);
            lbTempo1.Name = "lbTempo1";
            lbTempo1.Size = new Size(56, 37);
            lbTempo1.TabIndex = 16;
            lbTempo1.Text = "De:";
            // 
            // lbTempo2
            // 
            lbTempo2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbTempo2.AutoSize = true;
            lbTempo2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTempo2.ForeColor = Color.White;
            lbTempo2.Location = new Point(258, 134);
            lbTempo2.Name = "lbTempo2";
            lbTempo2.Size = new Size(63, 37);
            lbTempo2.TabIndex = 17;
            lbTempo2.Text = "Ate:";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(45, 45, 60);
            panelForm.Controls.Add(tlpMain);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 0);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(10, 11, 10, 11);
            panelForm.Size = new Size(1130, 829);
            panelForm.TabIndex = 18;
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
            tlpMain.Location = new Point(10, 11);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.5098F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.64706F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 57.84314F));
            tlpMain.Size = new Size(1110, 807);
            tlpMain.TabIndex = 38;
            // 
            // tlpBot
            // 
            tlpBot.ColumnCount = 2;
            tlpBot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBot.Controls.Add(grafico1_dash, 0, 0);
            tlpBot.Controls.Add(grafico2_dash, 1, 0);
            tlpBot.Dock = DockStyle.Fill;
            tlpBot.Location = new Point(3, 342);
            tlpBot.Name = "tlpBot";
            tlpBot.Padding = new Padding(10, 5, 10, 11);
            tlpBot.RowCount = 1;
            tlpBot.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBot.Size = new Size(1104, 462);
            tlpBot.TabIndex = 0;
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
            tlpMeio.Location = new Point(3, 200);
            tlpMeio.Name = "tlpMeio";
            tlpMeio.Padding = new Padding(10, 5, 10, 11);
            tlpMeio.RowCount = 1;
            tlpMeio.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMeio.Size = new Size(1104, 136);
            tlpMeio.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(30, 30, 45);
            panelTop.Controls.Add(btnEstoque);
            panelTop.Controls.Add(btnBuscar);
            panelTop.Controls.Add(btnComparacao);
            panelTop.Controls.Add(lbTituloDash);
            panelTop.Controls.Add(btnVendas);
            panelTop.Controls.Add(lbTempo1);
            panelTop.Controls.Add(btnProdutos);
            panelTop.Controls.Add(lbTempo2);
            panelTop.Controls.Add(maskedFim);
            panelTop.Controls.Add(maskedInicio);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1104, 191);
            panelTop.TabIndex = 2;
            // 
            // btnEstoque
            // 
            btnEstoque.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEstoque.BackColor = SystemColors.Highlight;
            btnEstoque.Cursor = Cursors.Hand;
            btnEstoque.FlatStyle = FlatStyle.Popup;
            btnEstoque.Font = new Font("Franklin Gothic Medium", 15F);
            btnEstoque.ForeColor = Color.White;
            btnEstoque.Location = new Point(772, 72);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(159, 53);
            btnEstoque.TabIndex = 38;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += buttonEstoque_Click;
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
            lbTituloDash.Text = "Vendas";
            lbTituloDash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dashboardVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1130, 829);
            Controls.Add(panelForm);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "dashboardVenda";
            Text = "dashboard";
            Load += dashboard_Load;
            Info1_dash.ResumeLayout(false);
            Info2_dash.ResumeLayout(false);
            Info3_dash.ResumeLayout(false);
            Info4_dash.ResumeLayout(false);
            grafico1_dash.ResumeLayout(false);
            grafico2_dash.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            tlpBot.ResumeLayout(false);
            tlpMeio.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox Info1_dash;
        private GroupBox Info2_dash;
        private GroupBox Info3_dash;
        private GroupBox Info4_dash;
        private GroupBox grafico1_dash;
        private GroupBox grafico2_dash;
        private OxyPlot.WindowsForms.PlotView grafico1;
        private OxyPlot.WindowsForms.PlotView grafico2;
        private Label lbDash1;
        private Label lbDash2;
        private Label lbDash3;
        private Label lbDash4;
        private Button btnProdutos;
        private Button btnVendas;
        private Button btnComparacao;
        private MaskedTextBox maskedInicio;
        private MaskedTextBox maskedFim;
        private Button btnBuscar;
        private Label lbTempo1;
        private Label lbTempo2;
        private Panel panelForm;
        private Label lbTituloDash;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpBot;
        private TableLayoutPanel tlpMeio;
        private Panel panelTop;
        private Button btnEstoque;
        private Label lbTituloGrafico1;
        private Label lbTituloGrafico2;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}