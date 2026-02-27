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
            panel1 = new Panel();
            button2 = new Button();
            btnLogOut = new Button();
            label5 = new Label();
            button1 = new Button();
            dtgEmpresas = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelTop = new Panel();
            btnMinimizar = new Button();
            btnSair = new Button();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).BeginInit();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dtgEmpresas);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(20, 20);
            panel1.Margin = new Padding(20);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 939);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Medium", 18F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(553, 688);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(370, 84);
            button2.TabIndex = 9;
            button2.Text = "Gerenciar\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(20, 816);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(207, 47);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Sair";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Microsoft Sans Serif", 18F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(219, 191);
            label5.Name = "label5";
            label5.Size = new Size(514, 36);
            label5.TabIndex = 7;
            label5.Text = "Selecione o Comercio desejado";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 18F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 688);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(527, 84);
            button1.TabIndex = 6;
            button1.Text = "Adicionar Empresa +";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            dtgEmpresas.EnableHeadersVisualStyles = false;
            dtgEmpresas.GridColor = Color.FromArgb(60, 60, 80);
            dtgEmpresas.Location = new Point(20, 231);
            dtgEmpresas.Margin = new Padding(3, 4, 3, 4);
            dtgEmpresas.MultiSelect = false;
            dtgEmpresas.Name = "dtgEmpresas";
            dtgEmpresas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgEmpresas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgEmpresas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dtgEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgEmpresas.RowTemplate.Height = 35;
            dtgEmpresas.Size = new Size(903, 449);
            dtgEmpresas.TabIndex = 5;
            dtgEmpresas.CellClick += dtgEmpresas_CellClick;
            dtgEmpresas.CellMouseEnter += dtgEmpresas_CellMouseEnter_1;
            dtgEmpresas.CellMouseLeave += dtgEmpresas_CellMouseLeave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Microsoft Sans Serif", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(198, 32);
            label4.Name = "label4";
            label4.Size = new Size(555, 58);
            label4.TabIndex = 4;
            label4.Text = "Bem vindo, Usuario!";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 30F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 399);
            label1.Name = "label1";
            label1.Size = new Size(562, 58);
            label1.TabIndex = 1;
            label1.Text = "Gerencie com facilidade";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 50F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 461);
            label2.Name = "label2";
            label2.Size = new Size(628, 190);
            label2.TabIndex = 2;
            label2.Text = "Transforme sua\r\nEm resultados.";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 50F);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(633, 461);
            label3.Name = "label3";
            label3.Size = new Size(311, 95);
            label3.TabIndex = 3;
            label3.Text = "Gestao";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(30, 30, 40);
            panelTop.Controls.Add(btnMinimizar);
            panelTop.Controls.Add(btnSair);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1942, 43);
            panelTop.TabIndex = 4;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(1818, 0);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(62, 43);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.Dock = DockStyle.Right;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(1880, 0);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(62, 43);
            btnSair.TabIndex = 1;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(956, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(983, 979);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 989F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1942, 985);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(947, 979);
            panel3.TabIndex = 6;
            // 
            // frmEmpresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(1942, 1028);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadastroEmpresa";
            WindowState = FormWindowState.Maximized;
            Load += frmEmpresa_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).EndInit();
            panelTop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private DataGridView dtgEmpresas;
        private Label label5;
        private Panel panelTop;
        private Button btnMinimizar;
        private Button btnSair;
        private Button btnLogOut;
        private Button button2;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
    }
}