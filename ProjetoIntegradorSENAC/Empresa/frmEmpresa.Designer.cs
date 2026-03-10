namespace ProjetoIntegradorSENAC.Empresa
{
    partial class frmEmpresa
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
            label4 = new Label();
            dtgEmpresas = new DataGridView();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            voltarBtn = new Button();
            logoPic = new PictureBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPic).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.Font = new Font("Microsoft Sans Serif", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(164, 24);
            label4.Name = "label4";
            label4.Size = new Size(399, 44);
            label4.TabIndex = 4;
            label4.Text = "Bem vindo, Usuario!";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgEmpresas
            // 
            dtgEmpresas.AllowUserToAddRows = false;
            dtgEmpresas.AllowUserToDeleteRows = false;
            dtgEmpresas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgEmpresas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgEmpresas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEmpresas.BackgroundColor = Color.FromArgb(30, 30, 40);
            dtgEmpresas.BorderStyle = BorderStyle.None;
            dtgEmpresas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgEmpresas.DefaultCellStyle = dataGridViewCellStyle3;
            dtgEmpresas.EnableHeadersVisualStyles = false;
            dtgEmpresas.GridColor = Color.FromArgb(60, 60, 80);
            dtgEmpresas.Location = new Point(9, 173);
            dtgEmpresas.MultiSelect = false;
            dtgEmpresas.Name = "dtgEmpresas";
            dtgEmpresas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 12F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgEmpresas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgEmpresas.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle5.Font = new Font("Franklin Gothic Medium", 12F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dtgEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgEmpresas.RowTemplate.Height = 35;
            dtgEmpresas.Size = new Size(703, 346);
            dtgEmpresas.TabIndex = 5;
            dtgEmpresas.CellClick += dtgEmpresas_CellClick;
            dtgEmpresas.CellContentClick += dtgEmpresas_CellContentClick;
            dtgEmpresas.CellMouseEnter += dtgEmpresas_CellMouseEnter_1;
            dtgEmpresas.CellMouseLeave += dtgEmpresas_CellMouseLeave;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 18F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(396, 57);
            button1.TabIndex = 6;
            button1.Text = "Adicionar Empresa +";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.Font = new Font("Microsoft Sans Serif", 18F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(176, 127);
            label5.Name = "label5";
            label5.Size = new Size(363, 27);
            label5.TabIndex = 7;
            label5.Text = "Selecione o Comercio desejado";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Medium", 18F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(405, 3);
            button2.Name = "button2";
            button2.Size = new Size(295, 57);
            button2.TabIndex = 9;
            button2.Text = "Gerenciar\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtgEmpresas);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(541, 15);
            panel1.Margin = new Padding(18, 15, 18, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 650);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.1835F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8165F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Location = new Point(9, 525);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(703, 63);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // voltarBtn
            // 
            voltarBtn.BackColor = Color.Transparent;
            voltarBtn.FlatAppearance.BorderSize = 0;
            voltarBtn.FlatStyle = FlatStyle.Flat;
            voltarBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            voltarBtn.ForeColor = SystemColors.Highlight;
            voltarBtn.Location = new Point(15, 10);
            voltarBtn.Name = "voltarBtn";
            voltarBtn.Size = new Size(60, 50);
            voltarBtn.TabIndex = 11;
            voltarBtn.Text = "←";
            voltarBtn.UseVisualStyleBackColor = false;
            voltarBtn.Click += voltarBtn_Click;
            // 
            // logoPic
            // 
            logoPic.BackColor = Color.Transparent;
            logoPic.Image = Properties.Resources.logo;
            logoPic.Location = new Point(81, 10);
            logoPic.Name = "logoPic";
            logoPic.Size = new Size(120, 50);
            logoPic.SizeMode = PictureBoxSizeMode.Zoom;
            logoPic.TabIndex = 12;
            logoPic.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Franklin Gothic Demi Cond", 40F);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(343, 288);
            label3.Name = "label3";
            label3.Size = new Size(175, 68);
            label3.TabIndex = 15;
            label3.Text = "Gestão";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Demi Cond", 40F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 286);
            label6.Name = "label6";
            label6.Size = new Size(346, 136);
            label6.TabIndex = 14;
            label6.Text = "Transforme sua\r\nEm resultados.";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium Cond", 20F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 252);
            label7.Name = "label7";
            label7.Size = new Size(252, 34);
            label7.TabIndex = 13;
            label7.Text = "Gerencie com facilidade";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.859375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.140625F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1280, 680);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(logoPic);
            panel2.Controls.Add(voltarBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(517, 674);
            panel2.TabIndex = 0;
            // 
            // frmEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(1280, 680);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadastroEmpresa";
            Load += frmEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPic).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private DataGridView dtgEmpresas;
        private Button button1;
        private Label label5;
        private Button button2;
        private Panel panel1;
        private Button voltarBtn;
        private PictureBox logoPic;
        private Label label3;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
    }
}