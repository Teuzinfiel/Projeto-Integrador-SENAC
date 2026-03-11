namespace ProjetoIntegradorSENAC.Caixa
{
    partial class FrmParcelamento
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private Label lblTitulo;
        private NumericUpDown numParcelas;
        private Button btnConfirmar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            lblTitulo = new Label();
            numParcelas = new NumericUpDown();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numParcelas).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(40, 40, 50);
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mainLayout.Controls.Add(lblTitulo, 0, 0);
            mainLayout.Controls.Add(numParcelas, 0, 1);
            mainLayout.Controls.Add(btnConfirmar, 0, 2);
            mainLayout.Controls.Add(btnCancelar, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(25);
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.Size = new Size(400, 220);
            mainLayout.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(28, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(344, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Quantidade de Parcelas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numParcelas
            // 
            numParcelas.BackColor = Color.FromArgb(45, 45, 60);
            numParcelas.Dock = DockStyle.Fill;
            numParcelas.Font = new Font("Segoe UI", 14F);
            numParcelas.ForeColor = Color.White;
            numParcelas.Location = new Point(28, 68);
            numParcelas.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numParcelas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.Name = "numParcelas";
            numParcelas.Size = new Size(344, 39);
            numParcelas.TabIndex = 1;
            numParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(0, 150, 255);
            btnConfirmar.Dock = DockStyle.Fill;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(28, 118);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(344, 24);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(200, 50, 50);
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(28, 148);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(344, 44);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // FrmParcelamento
            // 
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(400, 220);
            Controls.Add(mainLayout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmParcelamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Parcelamento";
            mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numParcelas).EndInit();
            ResumeLayout(false);
        }
    }
}