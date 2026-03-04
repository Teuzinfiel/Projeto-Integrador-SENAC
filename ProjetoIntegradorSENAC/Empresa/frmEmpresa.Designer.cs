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
            label4 = new Label();
            dtgEmpresas = new DataGridView();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            voltarBtn = new Button();
            logoPic = new PictureBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPic).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.Font = new Font("Microsoft Sans Serif", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(173, 24);
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
            dtgEmpresas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            dtgEmpresas.Location = new Point(18, 173);
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
            dtgEmpresas.Size = new Size(703, 312);
            dtgEmpresas.TabIndex = 5;
            dtgEmpresas.CellClick += dtgEmpresas_CellClick;
            dtgEmpresas.CellMouseEnter += dtgEmpresas_CellMouseEnter_1;
            dtgEmpresas.CellMouseLeave += dtgEmpresas_CellMouseLeave;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 18F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(18, 503);
            button1.Name = "button1";
            button1.Size = new Size(333, 63);
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
            label5.Location = new Point(185, 127);
            label5.Name = "label5";
            label5.Size = new Size(363, 27);
            label5.TabIndex = 7;
            label5.Text = "Selecione o Comercio desejado";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Medium", 18F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(397, 503);
            button2.Name = "button2";
            button2.Size = new Size(324, 63);
            button2.TabIndex = 9;
            button2.Text = "Gerenciar\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dtgEmpresas);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(530, 31);
            panel1.Margin = new Padding(18, 15, 18, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 616);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // voltarBtn
            // 
            voltarBtn.BackColor = Color.Transparent;
            voltarBtn.FlatAppearance.BorderSize = 0;
            voltarBtn.FlatStyle = FlatStyle.Flat;
            voltarBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            voltarBtn.ForeColor = SystemColors.Highlight;
            voltarBtn.Location = new Point(12, 12);
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
            logoPic.Location = new Point(78, 12);
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
            label3.Location = new Point(349, 301);
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
            label6.Location = new Point(20, 299);
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
            label7.Location = new Point(31, 265);
            label7.Name = "label7";
            label7.Size = new Size(252, 34);
            label7.TabIndex = 13;
            label7.Text = "Gerencie com facilidade";
            // 
            // frmEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(1280, 680);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(logoPic);
            Controls.Add(voltarBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadastroEmpresa";
            Load += frmEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}