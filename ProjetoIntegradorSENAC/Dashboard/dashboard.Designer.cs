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
            label1 = new Label();
            Info2_dash = new GroupBox();
            label2 = new Label();
            Info3_dash = new GroupBox();
            label3 = new Label();
            Info4_dash = new GroupBox();
            label4 = new Label();
            grafico1_dash = new GroupBox();
            grafico1 = new OxyPlot.WindowsForms.PlotView();
            grafico2_dash = new GroupBox();
            grafico2 = new OxyPlot.WindowsForms.PlotView();
            comboPeriodo_dash = new ComboBox();
            btnProduto = new Button();
            btnMeses = new Button();
            button1 = new Button();
            Info1_dash.SuspendLayout();
            Info2_dash.SuspendLayout();
            Info3_dash.SuspendLayout();
            Info4_dash.SuspendLayout();
            grafico1_dash.SuspendLayout();
            grafico2_dash.SuspendLayout();
            SuspendLayout();
            // 
            // Info1_dash
            // 
            Info1_dash.Controls.Add(label1);
            Info1_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info1_dash.ForeColor = SystemColors.Control;
            Info1_dash.Location = new Point(77, 141);
            Info1_dash.Name = "Info1_dash";
            Info1_dash.Size = new Size(287, 125);
            Info1_dash.TabIndex = 3;
            Info1_dash.TabStop = false;
            Info1_dash.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 56);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Info2_dash
            // 
            Info2_dash.Controls.Add(label2);
            Info2_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info2_dash.ForeColor = SystemColors.Control;
            Info2_dash.Location = new Point(437, 141);
            Info2_dash.Name = "Info2_dash";
            Info2_dash.Size = new Size(287, 125);
            Info2_dash.TabIndex = 4;
            Info2_dash.TabStop = false;
            Info2_dash.Text = "groupBox2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label2.Location = new Point(97, 56);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // Info3_dash
            // 
            Info3_dash.Controls.Add(label3);
            Info3_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info3_dash.ForeColor = SystemColors.Control;
            Info3_dash.Location = new Point(799, 141);
            Info3_dash.Name = "Info3_dash";
            Info3_dash.Size = new Size(287, 125);
            Info3_dash.TabIndex = 4;
            Info3_dash.TabStop = false;
            Info3_dash.Text = "groupBox3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label3.Location = new Point(95, 56);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // Info4_dash
            // 
            Info4_dash.Controls.Add(label4);
            Info4_dash.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Info4_dash.ForeColor = SystemColors.Control;
            Info4_dash.Location = new Point(1159, 141);
            Info4_dash.Name = "Info4_dash";
            Info4_dash.Size = new Size(287, 125);
            Info4_dash.TabIndex = 4;
            Info4_dash.TabStop = false;
            Info4_dash.Text = "groupBox4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label4.Location = new Point(94, 56);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // grafico1_dash
            // 
            grafico1_dash.Controls.Add(grafico1);
            grafico1_dash.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grafico1_dash.ForeColor = SystemColors.Control;
            grafico1_dash.Location = new Point(77, 299);
            grafico1_dash.Name = "grafico1_dash";
            grafico1_dash.Size = new Size(671, 467);
            grafico1_dash.TabIndex = 5;
            grafico1_dash.TabStop = false;
            grafico1_dash.Text = "Gráfico1";
            // 
            // grafico1
            // 
            grafico1.Location = new Point(18, 27);
            grafico1.Name = "grafico1";
            grafico1.PanCursor = Cursors.Hand;
            grafico1.Size = new Size(634, 425);
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
            grafico2_dash.Location = new Point(775, 299);
            grafico2_dash.Name = "grafico2_dash";
            grafico2_dash.Size = new Size(671, 467);
            grafico2_dash.TabIndex = 6;
            grafico2_dash.TabStop = false;
            grafico2_dash.Text = "Gráfico2";
            // 
            // grafico2
            // 
            grafico2.Location = new Point(19, 27);
            grafico2.Name = "grafico2";
            grafico2.PanCursor = Cursors.Hand;
            grafico2.Size = new Size(635, 425);
            grafico2.TabIndex = 0;
            grafico2.Text = "plotView2";
            grafico2.ZoomHorizontalCursor = Cursors.SizeWE;
            grafico2.ZoomRectangleCursor = Cursors.SizeNWSE;
            grafico2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // comboPeriodo_dash
            // 
            comboPeriodo_dash.BackColor = Color.FromArgb(45, 45, 60);
            comboPeriodo_dash.FlatStyle = FlatStyle.Popup;
            comboPeriodo_dash.Font = new Font("Franklin Gothic Medium", 15F);
            comboPeriodo_dash.ForeColor = Color.White;
            comboPeriodo_dash.FormattingEnabled = true;
            comboPeriodo_dash.Items.AddRange(new object[] { "Hoje", "1 Semana", "1 Mês", "3 Meses", "6 Meses", "12 Meses" });
            comboPeriodo_dash.Location = new Point(77, 53);
            comboPeriodo_dash.Name = "comboPeriodo_dash";
            comboPeriodo_dash.Size = new Size(141, 40);
            comboPeriodo_dash.TabIndex = 7;
            comboPeriodo_dash.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = SystemColors.Highlight;
            btnProduto.Cursor = Cursors.Hand;
            btnProduto.FlatStyle = FlatStyle.Popup;
            btnProduto.Font = new Font("Franklin Gothic Medium", 15F);
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(845, 53);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(142, 53);
            btnProduto.TabIndex = 9;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProduto_Click;
            // 
            // btnMeses
            // 
            btnMeses.BackColor = SystemColors.Highlight;
            btnMeses.Cursor = Cursors.Hand;
            btnMeses.FlatStyle = FlatStyle.Popup;
            btnMeses.Font = new Font("Franklin Gothic Medium", 15F);
            btnMeses.ForeColor = Color.White;
            btnMeses.Location = new Point(490, 46);
            btnMeses.Name = "btnMeses";
            btnMeses.Size = new Size(142, 53);
            btnMeses.TabIndex = 11;
            btnMeses.Text = "Vendas";
            btnMeses.UseVisualStyleBackColor = false;
            btnMeses.Click += btnMeses_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1124, 53);
            button1.Name = "button1";
            button1.Size = new Size(159, 53);
            button1.TabIndex = 12;
            button1.Text = "Comparação";
            button1.UseVisualStyleBackColor = false;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1515, 915);
            Controls.Add(button1);
            Controls.Add(btnMeses);
            Controls.Add(btnProduto);
            Controls.Add(comboPeriodo_dash);
            Controls.Add(grafico2_dash);
            Controls.Add(grafico1_dash);
            Controls.Add(Info2_dash);
            Controls.Add(Info3_dash);
            Controls.Add(Info4_dash);
            Controls.Add(Info1_dash);
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
        private ComboBox comboPeriodo_dash;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnProduto;
        private Button btnMeses;
        private Button button1;
    }
}