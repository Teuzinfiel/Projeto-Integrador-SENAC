namespace ProjetoIntegradorSENAC.Estoque
{
    partial class frmPreviewMovimentacoes
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
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTitulo;

        private void InitializeComponent()
        {
            preview = new System.Windows.Forms.PrintPreviewControl();
            btnImprimir = new System.Windows.Forms.Button();
            btnFechar = new System.Windows.Forms.Button();
            lblTitulo = new System.Windows.Forms.Label();

            SuspendLayout();

            // Label título
            lblTitulo.Text = "PRÉ-VISUALIZAÇÃO - MOVIMENTAÇÕES";
            lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 22F);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new System.Drawing.Point(20, 15);

            // PrintPreview
            preview.Location = new System.Drawing.Point(20, 70);
            preview.Size = new System.Drawing.Size(900, 500);
            preview.Zoom = 1;

            // Botão imprimir
            btnImprimir.Text = "Imprimir";
            btnImprimir.BackColor = System.Drawing.Color.RoyalBlue;
            btnImprimir.ForeColor = System.Drawing.Color.White;
            btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnImprimir.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F);
            btnImprimir.Location = new System.Drawing.Point(20, 585);
            btnImprimir.Size = new System.Drawing.Size(140, 40);

            // Botão fechar
            btnFechar.Text = "Fechar";
            btnFechar.BackColor = System.Drawing.Color.FromArgb(80, 80, 120);
            btnFechar.ForeColor = System.Drawing.Color.White;
            btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnFechar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F);
            btnFechar.Location = new System.Drawing.Point(180, 585);
            btnFechar.Size = new System.Drawing.Size(140, 40);

            // Form
            BackColor = System.Drawing.Color.FromArgb(45, 45, 60);
            Controls.Add(lblTitulo);
            Controls.Add(preview);
            Controls.Add(btnImprimir);
            Controls.Add(btnFechar);

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ClientSize = new System.Drawing.Size(950, 650);
            Name = "frmPreviewMovimentacoes";
            Text = "Preview Movimentações";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}