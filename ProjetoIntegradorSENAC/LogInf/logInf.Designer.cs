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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            labelTitulo = new Label();
            dgvLogs = new DataGridView();
            txtPesquisar = new TextBox();
            btnExportar = new Button();
            dtInicio = new DateTimePicker();
            dtFim = new DateTimePicker();
            lbPesquisar = new Label();
            lbPeriodo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.Top;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Franklin Gothic Medium", 24F);
            labelTitulo.ForeColor = SystemColors.Highlight;
            labelTitulo.Location = new Point(354, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(258, 37);
            labelTitulo.TabIndex = 7;
            labelTitulo.Text = "Logs Da Empresa";
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dgvLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = Color.FromArgb(30, 30, 40);
            dgvLogs.BorderStyle = BorderStyle.None;
            dgvLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle10.Font = new Font("Franklin Gothic Medium", 16F);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvLogs.DefaultCellStyle = dataGridViewCellStyle11;
            dgvLogs.EnableHeadersVisualStyles = false;
            dgvLogs.GridColor = Color.FromArgb(60, 60, 80);
            dgvLogs.Location = new Point(12, 161);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle12.Font = new Font("Franklin Gothic Medium", 16F);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dgvLogs.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvLogs.RowTemplate.Height = 36;
            dgvLogs.Size = new Size(940, 439);
            dgvLogs.TabIndex = 0;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top;
            txtPesquisar.Font = new Font("Franklin Gothic Book", 14F);
            txtPesquisar.Location = new Point(12, 120);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar por usuário ou descrição";
            txtPesquisar.Size = new Size(364, 29);
            txtPesquisar.TabIndex = 1;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top;
            btnExportar.BackColor = Color.FromArgb(80, 80, 120);
            btnExportar.FlatStyle = FlatStyle.Popup;
            btnExportar.Font = new Font("Franklin Gothic Medium", 14F);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(806, 118);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(146, 30);
            btnExportar.TabIndex = 4;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // dtInicio
            // 
            dtInicio.Anchor = AnchorStyles.Top;
            dtInicio.Font = new Font("Franklin Gothic Book", 14F);
            dtInicio.Location = new Point(388, 119);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(190, 29);
            dtInicio.TabIndex = 5;
            // 
            // dtFim
            // 
            dtFim.Anchor = AnchorStyles.Top;
            dtFim.Font = new Font("Franklin Gothic Book", 14F);
            dtFim.Location = new Point(598, 119);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(192, 29);
            dtFim.TabIndex = 6;
            // 
            // lbPesquisar
            // 
            lbPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbPesquisar.AutoSize = true;
            lbPesquisar.Font = new Font("Franklin Gothic Medium", 12F);
            lbPesquisar.ForeColor = Color.FromArgb(180, 180, 190);
            lbPesquisar.Location = new Point(12, 96);
            lbPesquisar.Name = "lbPesquisar";
            lbPesquisar.Size = new Size(109, 21);
            lbPesquisar.TabIndex = 8;
            lbPesquisar.Text = "Pesquisar logs";
            // 
            // lbPeriodo
            // 
            lbPeriodo.Anchor = AnchorStyles.Top;
            lbPeriodo.AutoSize = true;
            lbPeriodo.Font = new Font("Franklin Gothic Medium", 12F);
            lbPeriodo.ForeColor = Color.FromArgb(180, 180, 190);
            lbPeriodo.Location = new Point(388, 95);
            lbPeriodo.Name = "lbPeriodo";
            lbPeriodo.Size = new Size(62, 21);
            lbPeriodo.TabIndex = 9;
            lbPeriodo.Text = "Período";
            // 
            // logInf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(989, 622);
            Controls.Add(dgvLogs);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExportar);
            Controls.Add(dtInicio);
            Controls.Add(dtFim);
            Controls.Add(labelTitulo);
            Controls.Add(lbPesquisar);
            Controls.Add(lbPeriodo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "logInf";
            Text = "loginf";
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}