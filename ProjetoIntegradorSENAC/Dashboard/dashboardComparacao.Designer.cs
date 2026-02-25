namespace ProjetoIntegradorSENAC
{
    partial class dashboardComparacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardComparacao));
            lbTempo2 = new Label();
            lbTempo1 = new Label();
            btnBuscar = new Button();
            maskedFim1Periodo = new MaskedTextBox();
            maskedFim2Periodo = new MaskedTextBox();
            btnComparacao = new Button();
            btnVendas = new Button();
            btnProdutos = new Button();
            grafico2_dash = new GroupBox();
            imgProximo = new PictureBox();
            imgLonge = new PictureBox();
            lblLonge = new Label();
            lblProximo = new Label();
            grafico2 = new OxyPlot.WindowsForms.PlotView();
            grafico1_dash = new GroupBox();
            grafico1 = new OxyPlot.WindowsForms.PlotView();
            Info2_dash = new GroupBox();
            lbDash2 = new Label();
            Info3_dash = new GroupBox();
            lbDash3 = new Label();
            Info4_dash = new GroupBox();
            lbDash4 = new Label();
            Info1_dash = new GroupBox();
            lbDash1 = new Label();
            label1 = new Label();
            label2 = new Label();
            maskedInicio2Periodo = new MaskedTextBox();
            maskedInicio1Periodo = new MaskedTextBox();
            panel1 = new Panel();
            tlpMain = new TableLayoutPanel();
            tlpMeio = new TableLayoutPanel();
            tlpBot = new TableLayoutPanel();
            panel2 = new Panel();
            lbTituloDash = new Label();
            grafico2_dash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgProximo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLonge).BeginInit();
            grafico1_dash.SuspendLayout();
            Info2_dash.SuspendLayout();
            Info3_dash.SuspendLayout();
            Info4_dash.SuspendLayout();
            Info1_dash.SuspendLayout();
            panel1.SuspendLayout();
            tlpMain.SuspendLayout();
            tlpMeio.SuspendLayout();
            tlpBot.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbTempo2
            // 
            lbTempo2.AutoSize = true;
            lbTempo2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTempo2.ForeColor = Color.White;
            lbTempo2.Location = new Point(7, 159);
            lbTempo2.Name = "lbTempo2";
            lbTempo2.Size = new Size(142, 37);
            lbTempo2.TabIndex = 31;
            lbTempo2.Text = "2ºPeríodo:";
            // 
            // lbTempo1
            // 
            lbTempo1.AutoSize = true;
            lbTempo1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTempo1.ForeColor = Color.White;
            lbTempo1.Location = new Point(7, 97);
            lbTempo1.Name = "lbTempo1";
            lbTempo1.Size = new Size(142, 37);
            lbTempo1.TabIndex = 30;
            lbTempo1.Text = "1ºPeríodo:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Franklin Gothic Medium", 15F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(639, 143);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(166, 53);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // maskedFim1Periodo
            // 
            maskedFim1Periodo.Font = new Font("Microsoft Sans Serif", 20.25F);
            maskedFim1Periodo.Location = new Point(414, 89);
            maskedFim1Periodo.Margin = new Padding(3, 4, 3, 4);
            maskedFim1Periodo.Mask = "00/00/0000";
            maskedFim1Periodo.Name = "maskedFim1Periodo";
            maskedFim1Periodo.Size = new Size(191, 46);
            maskedFim1Periodo.TabIndex = 28;
            maskedFim1Periodo.ValidatingType = typeof(DateTime);
            // 
            // maskedFim2Periodo
            // 
            maskedFim2Periodo.Font = new Font("Microsoft Sans Serif", 20.25F);
            maskedFim2Periodo.Location = new Point(414, 150);
            maskedFim2Periodo.Margin = new Padding(3, 4, 3, 4);
            maskedFim2Periodo.Mask = "00/00/0000";
            maskedFim2Periodo.Name = "maskedFim2Periodo";
            maskedFim2Periodo.Size = new Size(191, 46);
            maskedFim2Periodo.TabIndex = 27;
            maskedFim2Periodo.ValidatingType = typeof(DateTime);
            // 
            // btnComparacao
            // 
            btnComparacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnComparacao.BackColor = SystemColors.Highlight;
            btnComparacao.Cursor = Cursors.Hand;
            btnComparacao.FlatStyle = FlatStyle.Popup;
            btnComparacao.Font = new Font("Franklin Gothic Medium", 15F);
            btnComparacao.ForeColor = Color.White;
            btnComparacao.Location = new Point(1332, 143);
            btnComparacao.Name = "btnComparacao";
            btnComparacao.Size = new Size(166, 53);
            btnComparacao.TabIndex = 26;
            btnComparacao.Text = "Comparação";
            btnComparacao.UseVisualStyleBackColor = false;
            // 
            // btnVendas
            // 
            btnVendas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVendas.BackColor = SystemColors.Highlight;
            btnVendas.Cursor = Cursors.Hand;
            btnVendas.FlatStyle = FlatStyle.Popup;
            btnVendas.Font = new Font("Franklin Gothic Medium", 15F);
            btnVendas.ForeColor = Color.White;
            btnVendas.Location = new Point(1141, 143);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(166, 53);
            btnVendas.TabIndex = 25;
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
            btnProdutos.Location = new Point(947, 143);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(166, 53);
            btnProdutos.TabIndex = 24;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // grafico2_dash
            // 
            grafico2_dash.Controls.Add(imgProximo);
            grafico2_dash.Controls.Add(imgLonge);
            grafico2_dash.Controls.Add(lblLonge);
            grafico2_dash.Controls.Add(lblProximo);
            grafico2_dash.Controls.Add(grafico2);
            grafico2_dash.Dock = DockStyle.Fill;
            grafico2_dash.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grafico2_dash.ForeColor = SystemColors.Control;
            grafico2_dash.Location = new Point(759, 8);
            grafico2_dash.Margin = new Padding(5, 3, 3, 3);
            grafico2_dash.Name = "grafico2_dash";
            grafico2_dash.Size = new Size(736, 491);
            grafico2_dash.TabIndex = 23;
            grafico2_dash.TabStop = false;
            grafico2_dash.Text = "Gráfico2";
            // 
            // imgProximo
            // 
            imgProximo.Image = (Image)resources.GetObject("imgProximo.Image");
            imgProximo.Location = new Point(6, 459);
            imgProximo.Name = "imgProximo";
            imgProximo.Size = new Size(26, 19);
            imgProximo.SizeMode = PictureBoxSizeMode.CenterImage;
            imgProximo.TabIndex = 4;
            imgProximo.TabStop = false;
            // 
            // imgLonge
            // 
            imgLonge.Image = (Image)resources.GetObject("imgLonge.Image");
            imgLonge.Location = new Point(156, 459);
            imgLonge.Name = "imgLonge";
            imgLonge.Size = new Size(26, 19);
            imgLonge.TabIndex = 3;
            imgLonge.TabStop = false;
            // 
            // lblLonge
            // 
            lblLonge.AutoSize = true;
            lblLonge.Location = new Point(188, 459);
            lblLonge.Name = "lblLonge";
            lblLonge.Size = new Size(69, 20);
            lblLonge.TabIndex = 2;
            lblLonge.Text = "lblLonge";
            // 
            // lblProximo
            // 
            lblProximo.AutoSize = true;
            lblProximo.ImageAlign = ContentAlignment.MiddleLeft;
            lblProximo.Location = new Point(39, 459);
            lblProximo.Name = "lblProximo";
            lblProximo.Size = new Size(85, 20);
            lblProximo.TabIndex = 1;
            lblProximo.Text = "lblProximo";
            // 
            // grafico2
            // 
            grafico2.Dock = DockStyle.Fill;
            grafico2.Location = new Point(3, 23);
            grafico2.Name = "grafico2";
            grafico2.PanCursor = Cursors.Hand;
            grafico2.Size = new Size(730, 465);
            grafico2.TabIndex = 0;
            grafico2.Text = "plotView2";
            grafico2.ZoomHorizontalCursor = Cursors.SizeWE;
            grafico2.ZoomRectangleCursor = Cursors.SizeNWSE;
            grafico2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // grafico1_dash
            // 
            grafico1_dash.Controls.Add(grafico1);
            grafico1_dash.Dock = DockStyle.Fill;
            grafico1_dash.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grafico1_dash.ForeColor = SystemColors.Control;
            grafico1_dash.Location = new Point(13, 8);
            grafico1_dash.Margin = new Padding(3, 3, 5, 3);
            grafico1_dash.Name = "grafico1_dash";
            grafico1_dash.Size = new Size(736, 491);
            grafico1_dash.TabIndex = 22;
            grafico1_dash.TabStop = false;
            grafico1_dash.Text = "Gráfico1";
            // 
            // grafico1
            // 
            grafico1.Dock = DockStyle.Fill;
            grafico1.Location = new Point(3, 23);
            grafico1.Name = "grafico1";
            grafico1.PanCursor = Cursors.Hand;
            grafico1.Size = new Size(730, 465);
            grafico1.TabIndex = 0;
            grafico1.Text = "plotView1";
            grafico1.ZoomHorizontalCursor = Cursors.SizeWE;
            grafico1.ZoomRectangleCursor = Cursors.SizeNWSE;
            grafico1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Info2_dash
            // 
            Info2_dash.Controls.Add(lbDash2);
            Info2_dash.Dock = DockStyle.Fill;
            Info2_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info2_dash.ForeColor = SystemColors.Control;
            Info2_dash.Location = new Point(387, 8);
            Info2_dash.Margin = new Padding(5, 3, 5, 3);
            Info2_dash.Name = "Info2_dash";
            Info2_dash.Size = new Size(362, 140);
            Info2_dash.TabIndex = 19;
            Info2_dash.TabStop = false;
            Info2_dash.Text = "groupBox2";
            // 
            // lbDash2
            // 
            lbDash2.AutoSize = true;
            lbDash2.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lbDash2.Location = new Point(6, 55);
            lbDash2.Name = "lbDash2";
            lbDash2.Size = new Size(64, 18);
            lbDash2.TabIndex = 0;
            lbDash2.Text = "lbDash2";
            // 
            // Info3_dash
            // 
            Info3_dash.Controls.Add(lbDash3);
            Info3_dash.Dock = DockStyle.Fill;
            Info3_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info3_dash.ForeColor = SystemColors.Control;
            Info3_dash.Location = new Point(759, 8);
            Info3_dash.Margin = new Padding(5, 3, 5, 3);
            Info3_dash.Name = "Info3_dash";
            Info3_dash.Size = new Size(362, 140);
            Info3_dash.TabIndex = 20;
            Info3_dash.TabStop = false;
            Info3_dash.Text = "groupBox3";
            // 
            // lbDash3
            // 
            lbDash3.AutoSize = true;
            lbDash3.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lbDash3.Location = new Point(6, 55);
            lbDash3.Name = "lbDash3";
            lbDash3.Size = new Size(64, 18);
            lbDash3.TabIndex = 0;
            lbDash3.Text = "lbDash3";
            // 
            // Info4_dash
            // 
            Info4_dash.Controls.Add(lbDash4);
            Info4_dash.Dock = DockStyle.Fill;
            Info4_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info4_dash.ForeColor = SystemColors.Control;
            Info4_dash.Location = new Point(1131, 8);
            Info4_dash.Margin = new Padding(5, 3, 0, 3);
            Info4_dash.Name = "Info4_dash";
            Info4_dash.Size = new Size(367, 140);
            Info4_dash.TabIndex = 21;
            Info4_dash.TabStop = false;
            Info4_dash.Text = "groupBox4";
            // 
            // lbDash4
            // 
            lbDash4.AutoSize = true;
            lbDash4.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lbDash4.Location = new Point(6, 55);
            lbDash4.Name = "lbDash4";
            lbDash4.Size = new Size(64, 18);
            lbDash4.TabIndex = 0;
            lbDash4.Text = "lbDash4";
            // 
            // Info1_dash
            // 
            Info1_dash.BackgroundImageLayout = ImageLayout.None;
            Info1_dash.Controls.Add(lbDash1);
            Info1_dash.Dock = DockStyle.Fill;
            Info1_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info1_dash.ForeColor = SystemColors.Control;
            Info1_dash.Location = new Point(10, 8);
            Info1_dash.Margin = new Padding(0, 3, 5, 3);
            Info1_dash.Name = "Info1_dash";
            Info1_dash.Size = new Size(367, 140);
            Info1_dash.TabIndex = 18;
            Info1_dash.TabStop = false;
            Info1_dash.Text = "groupBox1";
            // 
            // lbDash1
            // 
            lbDash1.AutoSize = true;
            lbDash1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDash1.Location = new Point(6, 55);
            lbDash1.Name = "lbDash1";
            lbDash1.Size = new Size(64, 18);
            lbDash1.TabIndex = 0;
            lbDash1.Text = "lbDash1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(344, 97);
            label1.Name = "label1";
            label1.Size = new Size(63, 37);
            label1.TabIndex = 32;
            label1.Text = "Até:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(344, 159);
            label2.Name = "label2";
            label2.Size = new Size(63, 37);
            label2.TabIndex = 33;
            label2.Text = "Até:";
            // 
            // maskedInicio2Periodo
            // 
            maskedInicio2Periodo.Font = new Font("Microsoft Sans Serif", 20.25F);
            maskedInicio2Periodo.Location = new Point(144, 157);
            maskedInicio2Periodo.Margin = new Padding(3, 4, 3, 4);
            maskedInicio2Periodo.Mask = "00/00/0000";
            maskedInicio2Periodo.Name = "maskedInicio2Periodo";
            maskedInicio2Periodo.Size = new Size(191, 46);
            maskedInicio2Periodo.TabIndex = 34;
            // 
            // maskedInicio1Periodo
            // 
            maskedInicio1Periodo.Font = new Font("Microsoft Sans Serif", 20.25F);
            maskedInicio1Periodo.Location = new Point(144, 91);
            maskedInicio1Periodo.Margin = new Padding(3, 4, 3, 4);
            maskedInicio1Periodo.Mask = "00/00/0000";
            maskedInicio1Periodo.Name = "maskedInicio1Periodo";
            maskedInicio1Periodo.Size = new Size(191, 46);
            maskedInicio1Periodo.TabIndex = 35;
            maskedInicio1Periodo.ValidatingType = typeof(DateTime);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 60);
            panel1.Controls.Add(tlpMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1534, 967);
            panel1.TabIndex = 36;
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.FromArgb(30, 30, 45);
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpMeio, 0, 1);
            tlpMain.Controls.Add(tlpBot, 0, 2);
            tlpMain.Controls.Add(panel2, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(10, 10);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.51F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.65F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 57.84F));
            tlpMain.Size = new Size(1514, 947);
            tlpMain.TabIndex = 37;
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
            tlpMeio.Location = new Point(3, 235);
            tlpMeio.Name = "tlpMeio";
            tlpMeio.Padding = new Padding(10, 5, 10, 10);
            tlpMeio.RowCount = 1;
            tlpMeio.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMeio.Size = new Size(1508, 161);
            tlpMeio.TabIndex = 1;
            // 
            // tlpBot
            // 
            tlpBot.ColumnCount = 2;
            tlpBot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBot.Controls.Add(grafico1_dash, 0, 0);
            tlpBot.Controls.Add(grafico2_dash, 1, 0);
            tlpBot.Dock = DockStyle.Fill;
            tlpBot.Location = new Point(3, 402);
            tlpBot.Name = "tlpBot";
            tlpBot.Padding = new Padding(10, 5, 10, 40);
            tlpBot.RowCount = 1;
            tlpBot.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBot.Size = new Size(1508, 542);
            tlpBot.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(maskedFim2Periodo);
            panel2.Controls.Add(lbTituloDash);
            panel2.Controls.Add(maskedFim1Periodo);
            panel2.Controls.Add(btnComparacao);
            panel2.Controls.Add(btnProdutos);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(btnVendas);
            panel2.Controls.Add(maskedInicio1Periodo);
            panel2.Controls.Add(lbTempo1);
            panel2.Controls.Add(maskedInicio2Periodo);
            panel2.Controls.Add(lbTempo2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1508, 226);
            panel2.TabIndex = 3;
            // 
            // lbTituloDash
            // 
            lbTituloDash.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTituloDash.Font = new Font("Franklin Gothic Medium", 23F);
            lbTituloDash.ForeColor = SystemColors.Highlight;
            lbTituloDash.Location = new Point(642, 14);
            lbTituloDash.Name = "lbTituloDash";
            lbTituloDash.Size = new Size(234, 45);
            lbTituloDash.TabIndex = 36;
            lbTituloDash.Text = "Comparação";
            lbTituloDash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dashboardComparacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1534, 967);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "dashboardComparacao";
            Text = "dashboardComparacao";
            Load += dashboardComparacao_Load;
            grafico2_dash.ResumeLayout(false);
            grafico2_dash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgProximo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLonge).EndInit();
            grafico1_dash.ResumeLayout(false);
            Info2_dash.ResumeLayout(false);
            Info2_dash.PerformLayout();
            Info3_dash.ResumeLayout(false);
            Info3_dash.PerformLayout();
            Info4_dash.ResumeLayout(false);
            Info4_dash.PerformLayout();
            Info1_dash.ResumeLayout(false);
            Info1_dash.PerformLayout();
            panel1.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            tlpMeio.ResumeLayout(false);
            tlpBot.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbTempo2;
        private Label lbTempo1;
        private Button btnBuscar;
        private MaskedTextBox maskedFim1Periodo;
        private MaskedTextBox maskedFim2Periodo;
        private Button btnComparacao;
        private Button btnVendas;
        private Button btnProdutos;
        private GroupBox grafico2_dash;
        private PictureBox imgProximo;
        private PictureBox imgLonge;
        private Label lblLonge;
        private Label lblProximo;
        private OxyPlot.WindowsForms.PlotView grafico2;
        private GroupBox grafico1_dash;
        private OxyPlot.WindowsForms.PlotView grafico1;
        private GroupBox Info2_dash;
        private Label lbDash2;
        private GroupBox Info3_dash;
        private Label lbDash3;
        private GroupBox Info4_dash;
        private Label lbDash4;
        private GroupBox Info1_dash;
        private Label lbDash1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedInicio2Periodo;
        private MaskedTextBox maskedInicio1Periodo;
        private Panel panel1;
        private Label lbTituloDash;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpMeio;
        private TableLayoutPanel tlpBot;
        private Panel panel2;
    }
}