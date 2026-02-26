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
            btnPesquisar = new Button();
            btnAtualizar = new Button();
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
            labelTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Franklin Gothic Medium", 36F);
            labelTitulo.ForeColor = Color.FromArgb(180, 180, 190);
            labelTitulo.Location = new Point(362, 7);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(409, 61);
            labelTitulo.TabIndex = 7;
            labelTitulo.Text = "LOGS DO SISTEMA";
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
            dgvLogs.BackgroundColor = Color.FromArgb(30, 30, 40);
            dgvLogs.BorderStyle = BorderStyle.None;
            dgvLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 16F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dgvLogs.Location = new Point(12, 140);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 16F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvLogs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvLogs.RowTemplate.Height = 36;
            dgvLogs.Size = new Size(1260, 560);
            dgvLogs.TabIndex = 0;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisar.Font = new Font("Franklin Gothic Book", 18F);
            txtPesquisar.Location = new Point(12, 88);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar por usuário ou descrição";
            txtPesquisar.Size = new Size(500, 35);
            txtPesquisar.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPesquisar.BackColor = SystemColors.Highlight;
            btnPesquisar.FlatStyle = FlatStyle.Popup;
            btnPesquisar.Font = new Font("Franklin Gothic Medium", 14F);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(522, 88);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(120, 35);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAtualizar.BackColor = SystemColors.Highlight;
            btnAtualizar.FlatStyle = FlatStyle.Popup;
            btnAtualizar.Font = new Font("Franklin Gothic Medium", 14F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(652, 88);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(120, 35);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnExportar.BackColor = Color.FromArgb(80, 80, 120);
            btnExportar.FlatStyle = FlatStyle.Popup;
            btnExportar.Font = new Font("Franklin Gothic Medium", 14F);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(782, 88);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(120, 35);
            btnExportar.TabIndex = 4;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // dtInicio
            // 
            dtInicio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtInicio.Font = new Font("Franklin Gothic Book", 14F);
            dtInicio.Location = new Point(912, 88);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(140, 29);
            dtInicio.TabIndex = 5;
            // 
            // dtFim
            // 
            dtFim.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtFim.Font = new Font("Franklin Gothic Book", 14F);
            dtFim.Location = new Point(1062, 88);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(140, 29);
            dtFim.TabIndex = 6;
            // 
            // lbPesquisar
            // 
            lbPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbPesquisar.AutoSize = true;
            lbPesquisar.Font = new Font("Franklin Gothic Medium", 12F);
            lbPesquisar.ForeColor = Color.FromArgb(180, 180, 190);
            lbPesquisar.Location = new Point(12, 63);
            lbPesquisar.Name = "lbPesquisar";
            lbPesquisar.Size = new Size(109, 21);
            lbPesquisar.TabIndex = 8;
            lbPesquisar.Text = "Pesquisar logs";
            // 
            // lbPeriodo
            // 
            lbPeriodo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbPeriodo.AutoSize = true;
            lbPeriodo.Font = new Font("Franklin Gothic Medium", 12F);
            lbPeriodo.ForeColor = Color.FromArgb(180, 180, 190);
            lbPeriodo.Location = new Point(912, 63);
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
            ClientSize = new Size(1283, 736);
            Controls.Add(dgvLogs);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnAtualizar);
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
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.Label lbPeriodo;
    }
}