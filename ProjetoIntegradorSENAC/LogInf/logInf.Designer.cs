namespace ProjetoIntegradorSENAC.LogInf
{
    partial class logInf
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            labelTitulo = new Label();
            dgvLogs = new DataGridView();
            txtPesquisar = new TextBox();
            btnExportar = new Button();
            dtInicio = new DateTimePicker();
            dtFim = new DateTimePicker();
            lbPesquisar = new Label();
            lbPeriodo = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.Top;
            labelTitulo.Font = new Font("Franklin Gothic Medium", 24F);
            labelTitulo.ForeColor = SystemColors.Highlight;
            labelTitulo.Location = new Point(406, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(366, 63);
            labelTitulo.TabIndex = 7;
            labelTitulo.Text = "Logs Da Empresa";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dgvLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = Color.FromArgb(30, 35, 45);
            dgvLogs.BorderStyle = BorderStyle.None;
            dgvLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 16F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLogs.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLogs.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLogs.EnableHeadersVisualStyles = false;
            dgvLogs.GridColor = Color.FromArgb(60, 60, 80);
            dgvLogs.Location = new Point(26, 174);
            dgvLogs.Margin = new Padding(3, 4, 3, 4);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 16F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvLogs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvLogs.RowTemplate.Height = 36;
            dgvLogs.Size = new Size(1054, 622);
            dgvLogs.TabIndex = 0;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Microsoft Sans Serif", 14F);
            txtPesquisar.Location = new Point(26, 122);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar por usuário ou descrição";
            txtPesquisar.Size = new Size(415, 34);
            txtPesquisar.TabIndex = 1;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportar.BackColor = Color.FromArgb(80, 80, 120);
            btnExportar.FlatStyle = FlatStyle.Popup;
            btnExportar.Font = new Font("Franklin Gothic Medium", 14F);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(913, 116);
            btnExportar.Margin = new Padding(3, 4, 3, 4);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(167, 40);
            btnExportar.TabIndex = 4;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // dtInicio
            // 
            dtInicio.Font = new Font("Microsoft Sans Serif", 14F);
            dtInicio.Location = new Point(455, 121);
            dtInicio.Margin = new Padding(3, 4, 3, 4);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(217, 34);
            dtInicio.TabIndex = 5;
            // 
            // dtFim
            // 
            dtFim.Font = new Font("Microsoft Sans Serif", 14F);
            dtFim.Location = new Point(678, 121);
            dtFim.Margin = new Padding(3, 4, 3, 4);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(219, 34);
            dtFim.TabIndex = 6;
            // 
            // lbPesquisar
            // 
            lbPesquisar.AutoSize = true;
            lbPesquisar.Font = new Font("Franklin Gothic Medium", 12F);
            lbPesquisar.ForeColor = Color.FromArgb(180, 180, 190);
            lbPesquisar.Location = new Point(26, 90);
            lbPesquisar.Name = "lbPesquisar";
            lbPesquisar.Size = new Size(137, 25);
            lbPesquisar.TabIndex = 8;
            lbPesquisar.Text = "Pesquisar logs";
            // 
            // lbPeriodo
            // 
            lbPeriodo.AutoSize = true;
            lbPeriodo.Font = new Font("Franklin Gothic Medium", 12F);
            lbPeriodo.ForeColor = Color.FromArgb(180, 180, 190);
            lbPeriodo.Location = new Point(455, 89);
            lbPeriodo.Name = "lbPeriodo";
            lbPeriodo.Size = new Size(79, 25);
            lbPeriodo.TabIndex = 9;
            lbPeriodo.Text = "Período";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 45);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(dgvLogs);
            panel1.Controls.Add(dtInicio);
            panel1.Controls.Add(txtPesquisar);
            panel1.Controls.Add(lbPeriodo);
            panel1.Controls.Add(btnExportar);
            panel1.Controls.Add(lbPesquisar);
            panel1.Controls.Add(dtFim);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 809);
            panel1.TabIndex = 10;
            // 
            // logInf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1130, 829);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "logInf";
            Padding = new Padding(10);
            Text = "loginf";
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.Label lbPeriodo;
        private Panel panel1;
    }
}