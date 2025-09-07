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
            label5 = new Label();
            button1 = new Button();
            dtgEmpresas = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnMinimizar = new Button();
            btnSair = new Button();
            btnLogOut = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 50);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dtgEmpresas);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(799, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 672);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Book", 18F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(344, 140);
            label5.Name = "label5";
            label5.Size = new Size(331, 30);
            label5.TabIndex = 7;
            label5.Text = "Selecione a empresa desejada";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 18F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(60, 505);
            button1.Name = "button1";
            button1.Size = new Size(867, 63);
            button1.TabIndex = 6;
            button1.Text = "Adicionar Empresa +";
            button1.UseVisualStyleBackColor = false;
            // 
            // dtgEmpresas
            // 
            dtgEmpresas.AllowUserToAddRows = false;
            dtgEmpresas.AllowUserToDeleteRows = false;
            dtgEmpresas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgEmpresas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dtgEmpresas.Location = new Point(60, 173);
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
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dtgEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgEmpresas.RowTemplate.Height = 40;
            dtgEmpresas.Size = new Size(867, 337);
            dtgEmpresas.TabIndex = 5;
            dtgEmpresas.CellClick += dtgEmpresas_CellClick;
            dtgEmpresas.CellMouseEnter += dtgEmpresas_CellMouseEnter_1;
            dtgEmpresas.CellMouseLeave += dtgEmpresas_CellMouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi Cond", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(344, 25);
            label4.Name = "label4";
            label4.Size = new Size(323, 47);
            label4.TabIndex = 4;
            label4.Text = "Bem vindo, Usuario!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 30F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(107, 290);
            label1.Name = "label1";
            label1.Size = new Size(372, 47);
            label1.TabIndex = 1;
            label1.Text = "Gerencie com facilidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi Cond", 50F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(107, 337);
            label2.Name = "label2";
            label2.Size = new Size(428, 170);
            label2.TabIndex = 2;
            label2.Text = "Transforme sua\r\nEm resultados.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Franklin Gothic Demi Cond", 50F);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(514, 337);
            label3.Name = "label3";
            label3.Size = new Size(218, 85);
            label3.TabIndex = 3;
            label3.Text = "Gestao";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnSair);
            panel2.Location = new Point(-4, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1819, 32);
            panel2.TabIndex = 4;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(1715, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(54, 33);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(1765, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(54, 33);
            btnSair.TabIndex = 1;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(60, 609);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(177, 35);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Sair";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // frmEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(1814, 771);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadastroEmpresa";
            Load += frmEmpresa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panel2;
        private Button btnMinimizar;
        private Button btnSair;
        private Button btnLogOut;
    }
}