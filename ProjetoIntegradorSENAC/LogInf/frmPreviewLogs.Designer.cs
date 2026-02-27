namespace ProjetoIntegradorSENAC.LogInf
{
    partial class frmPreviewLogs
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.PrintPreviewControl preview;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFechar;

        private void InitializeComponent()
        {
            preview = new System.Windows.Forms.PrintPreviewControl();
            btnImprimir = new System.Windows.Forms.Button();
            lblTitulo = new System.Windows.Forms.Label();
            SuspendLayout();

            lblTitulo.Text = "PRÉ-VISUALIZAÇÃO DOS LOGS";
            lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new System.Drawing.Point(20, 15);

            preview.Location = new System.Drawing.Point(20, 70);
            preview.Size = new System.Drawing.Size(900, 500);
            preview.Zoom = 1;

            btnImprimir.Text = "Imprimir";
            btnImprimir.BackColor = System.Drawing.Color.RoyalBlue;
            btnImprimir.ForeColor = System.Drawing.Color.White;
            btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnImprimir.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F);
            btnImprimir.Location = new System.Drawing.Point(20, 585);
            btnImprimir.Size = new System.Drawing.Size(140, 40);

            btnFechar = new System.Windows.Forms.Button();

            btnFechar.Text = "Fechar";
            btnFechar.BackColor = System.Drawing.Color.FromArgb(80, 80, 120);
            btnFechar.ForeColor = System.Drawing.Color.White;
            btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnFechar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F);
            btnFechar.Location = new System.Drawing.Point(180, 585);
            btnFechar.Size = new System.Drawing.Size(140, 40);

            Controls.Add(btnFechar);

            BackColor = System.Drawing.Color.FromArgb(45, 45, 60);
            Controls.Add(lblTitulo);
            Controls.Add(preview);
            Controls.Add(btnImprimir);

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ClientSize = new System.Drawing.Size(950, 650);
            Name = "frmPreviewLogs";
            Text = "Preview Logs";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}