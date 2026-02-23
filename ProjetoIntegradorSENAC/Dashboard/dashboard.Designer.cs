namespace ProjetoIntegradorSENAC.Dashboard
{
    partial class dashboard
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
            Info2_dash = new GroupBox();
            lbDash2 = new Label();
            Info3_dash = new GroupBox();
            lbDash3 = new Label();
            Info4_dash = new GroupBox();
            lbDash4 = new Label();
            grafico1_dash = new GroupBox();
            grafico1 = new OxyPlot.WindowsForms.PlotView();
            grafico2_dash = new GroupBox();
            grafico2 = new OxyPlot.WindowsForms.PlotView();
            btnProdutos = new Button();
            btnVendas = new Button();
            btnComparacao = new Button();
            maskedInicio = new MaskedTextBox();
            maskedFim = new MaskedTextBox();
            btnBuscar = new Button();
            lbTempo1 = new Label();
            lbTempo2 = new Label();
            panel1 = new Panel();
            lbTituloDash = new Label();
            Info1_dash.SuspendLayout();
            Info2_dash.SuspendLayout();
            Info3_dash.SuspendLayout();
            Info4_dash.SuspendLayout();
            grafico1_dash.SuspendLayout();
            grafico2_dash.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Info1_dash
            // 
            Info1_dash.BackgroundImageLayout = ImageLayout.None;
            Info1_dash.Controls.Add(lbDash1);
            Info1_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info1_dash.ForeColor = SystemColors.Control;
            Info1_dash.Location = new Point(16, 243);
            Info1_dash.Name = "Info1_dash";
            Info1_dash.Size = new Size(358, 125);
            Info1_dash.TabIndex = 3;
            Info1_dash.TabStop = false;
            Info1_dash.Text = "groupBox1";
            // 
            // lbDash1
            // 
            lbDash1.AutoSize = true;
            lbDash1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDash1.Location = new Point(6, 56);
            lbDash1.Name = "lbDash1";
            lbDash1.Size = new Size(64, 18);
            lbDash1.TabIndex = 0;
            lbDash1.Text = "lbDash1";
            // 
            // Info2_dash
            // 
            Info2_dash.Controls.Add(lbDash2);
            Info2_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info2_dash.ForeColor = SystemColors.Control;
            Info2_dash.Location = new Point(390, 243);
            Info2_dash.Name = "Info2_dash";
            Info2_dash.Size = new Size(358, 125);
            Info2_dash.TabIndex = 4;
            Info2_dash.TabStop = false;
            Info2_dash.Text = "groupBox2";
            // 
            // lbDash2
            // 
            lbDash2.AutoSize = true;
            lbDash2.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lbDash2.Location = new Point(6, 56);
            lbDash2.Name = "lbDash2";
            lbDash2.Size = new Size(64, 18);
            lbDash2.TabIndex = 0;
            lbDash2.Text = "lbDash2";
            // 
            // Info3_dash
            // 
            Info3_dash.Controls.Add(lbDash3);
            Info3_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info3_dash.ForeColor = SystemColors.Control;
            Info3_dash.Location = new Point(760, 243);
            Info3_dash.Name = "Info3_dash";
            Info3_dash.Size = new Size(358, 125);
            Info3_dash.TabIndex = 4;
            Info3_dash.TabStop = false;
            Info3_dash.Text = "groupBox3";
            // 
            // lbDash3
            // 
            lbDash3.AutoSize = true;
            lbDash3.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lbDash3.Location = new Point(6, 56);
            lbDash3.Name = "lbDash3";
            lbDash3.Size = new Size(64, 18);
            lbDash3.TabIndex = 0;
            lbDash3.Text = "lbDash3";
            // 
            // Info4_dash
            // 
            Info4_dash.Controls.Add(lbDash4);
            Info4_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info4_dash.ForeColor = SystemColors.Control;
            Info4_dash.Location = new Point(1134, 243);
            Info4_dash.Name = "Info4_dash";
            Info4_dash.Size = new Size(358, 125);
            Info4_dash.TabIndex = 4;
            Info4_dash.TabStop = false;
            Info4_dash.Text = "groupBox4";
            // 
            // lbDash4
            // 
            lbDash4.AutoSize = true;
            lbDash4.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lbDash4.Location = new Point(6, 56);
            lbDash4.Name = "lbDash4";
            lbDash4.Size = new Size(64, 18);
            lbDash4.TabIndex = 0;
            lbDash4.Text = "lbDash4";
            // 
            // grafico1_dash
            // 
            grafico1_dash.Controls.Add(grafico1);
            grafico1_dash.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grafico1_dash.ForeColor = SystemColors.Control;
            grafico1_dash.Location = new Point(16, 401);
            grafico1_dash.Name = "grafico1_dash";
            grafico1_dash.Size = new Size(731, 480);
            grafico1_dash.TabIndex = 5;
            grafico1_dash.TabStop = false;
            grafico1_dash.Text = "Gráfico1";
            // 
            // grafico1
            // 
            grafico1.Location = new Point(1, 27);
            grafico1.Name = "grafico1";
            grafico1.PanCursor = Cursors.Hand;
            grafico1.Size = new Size(713, 435);
            grafico1.TabIndex = 0;
            grafico1.Text = "plotView1";
            grafico1.ZoomHorizontalCursor = Cursors.SizeWE;
            grafico1.ZoomRectangleCursor = Cursors.SizeNWSE;
            grafico1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // grafico2_dash
            // 
            grafico2_dash.Controls.Add(grafico2);
            grafico2_dash.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grafico2_dash.ForeColor = SystemColors.Control;
            grafico2_dash.Location = new Point(760, 401);
            grafico2_dash.Name = "grafico2_dash";
            grafico2_dash.Size = new Size(731, 480);
            grafico2_dash.TabIndex = 6;
            grafico2_dash.TabStop = false;
            grafico2_dash.Text = "Gráfico2";
            // 
            // grafico2
            // 
            grafico2.Location = new Point(1, 27);
            grafico2.Name = "grafico2";
            grafico2.PanCursor = Cursors.Hand;
            grafico2.Size = new Size(713, 435);
            grafico2.TabIndex = 0;
            grafico2.Text = "plotView2";
            grafico2.ZoomHorizontalCursor = Cursors.SizeWE;
            grafico2.ZoomRectangleCursor = Cursors.SizeNWSE;
            grafico2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = SystemColors.Highlight;
            btnProdutos.Cursor = Cursors.Hand;
            btnProdutos.FlatStyle = FlatStyle.Popup;
            btnProdutos.Font = new Font("Franklin Gothic Medium", 15F);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Location = new Point(1149, 155);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(154, 53);
            btnProdutos.TabIndex = 9;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = SystemColors.Highlight;
            btnVendas.Cursor = Cursors.Hand;
            btnVendas.FlatStyle = FlatStyle.Popup;
            btnVendas.Font = new Font("Franklin Gothic Medium", 15F);
            btnVendas.ForeColor = Color.White;
            btnVendas.Location = new Point(961, 155);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(154, 53);
            btnVendas.TabIndex = 11;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnComparacao
            // 
            btnComparacao.BackColor = SystemColors.Highlight;
            btnComparacao.Cursor = Cursors.Hand;
            btnComparacao.FlatStyle = FlatStyle.Popup;
            btnComparacao.Font = new Font("Franklin Gothic Medium", 15F);
            btnComparacao.ForeColor = Color.White;
            btnComparacao.Location = new Point(1334, 155);
            btnComparacao.Name = "btnComparacao";
            btnComparacao.Size = new Size(154, 53);
            btnComparacao.TabIndex = 12;
            btnComparacao.Text = "Comparação";
            btnComparacao.UseVisualStyleBackColor = false;
            btnComparacao.Click += btnComparacao_Click;
            // 
            // maskedInicio
            // 
            maskedInicio.Font = new Font("Microsoft Sans Serif", 20.25F);
            maskedInicio.Location = new Point(118, 118);
            maskedInicio.Margin = new Padding(3, 4, 3, 4);
            maskedInicio.Mask = "00/00/0000";
            maskedInicio.Name = "maskedInicio";
            maskedInicio.Size = new Size(426, 46);
            maskedInicio.TabIndex = 13;
            maskedInicio.ValidatingType = typeof(DateTime);
            // 
            // maskedFim
            // 
            maskedFim.Font = new Font("Microsoft Sans Serif", 20.25F);
            maskedFim.Location = new Point(118, 182);
            maskedFim.Margin = new Padding(3, 4, 3, 4);
            maskedFim.Mask = "00/00/0000";
            maskedFim.Name = "maskedFim";
            maskedFim.Size = new Size(426, 46);
            maskedFim.TabIndex = 14;
            maskedFim.ValidatingType = typeof(DateTime);
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Franklin Gothic Medium", 15F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(578, 155);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(142, 53);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lbTempo1
            // 
            lbTempo1.AutoSize = true;
            lbTempo1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTempo1.ForeColor = Color.White;
            lbTempo1.Location = new Point(22, 129);
            lbTempo1.Name = "lbTempo1";
            lbTempo1.Size = new Size(87, 37);
            lbTempo1.TabIndex = 16;
            lbTempo1.Text = "Inicio:";
            // 
            // lbTempo2
            // 
            lbTempo2.AutoSize = true;
            lbTempo2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTempo2.ForeColor = Color.White;
            lbTempo2.Location = new Point(41, 193);
            lbTempo2.Name = "lbTempo2";
            lbTempo2.Size = new Size(66, 37);
            lbTempo2.TabIndex = 17;
            lbTempo2.Text = "Fim:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 45);
            panel1.Controls.Add(lbTituloDash);
            panel1.Controls.Add(lbTempo1);
            panel1.Controls.Add(lbTempo2);
            panel1.Controls.Add(Info1_dash);
            panel1.Controls.Add(Info4_dash);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(Info3_dash);
            panel1.Controls.Add(maskedFim);
            panel1.Controls.Add(Info2_dash);
            panel1.Controls.Add(maskedInicio);
            panel1.Controls.Add(grafico1_dash);
            panel1.Controls.Add(btnComparacao);
            panel1.Controls.Add(grafico2_dash);
            panel1.Controls.Add(btnVendas);
            panel1.Controls.Add(btnProdutos);
            panel1.Location = new Point(14, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1508, 941);
            panel1.TabIndex = 18;
            // 
            // lbTituloDash
            // 
            lbTituloDash.AutoSize = true;
            lbTituloDash.Font = new Font("Franklin Gothic Medium", 23F);
            lbTituloDash.ForeColor = SystemColors.Highlight;
            lbTituloDash.Location = new Point(683, 32);
            lbTituloDash.Name = "lbTituloDash";
            lbTituloDash.Size = new Size(381, 45);
            lbTituloDash.TabIndex = 37;
            lbTituloDash.Text = "Esqueceu sua senha?";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1534, 967);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "dashboard";
            Text = "dashboard";
            Load += dashboard_Load;
            Info1_dash.ResumeLayout(false);
            Info1_dash.PerformLayout();
            Info2_dash.ResumeLayout(false);
            Info2_dash.PerformLayout();
            Info3_dash.ResumeLayout(false);
            Info3_dash.PerformLayout();
            Info4_dash.ResumeLayout(false);
            Info4_dash.PerformLayout();
            grafico1_dash.ResumeLayout(false);
            grafico2_dash.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label lbTituloDash;
    }
}