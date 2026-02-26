namespace ProjetoIntegradorSENAC.Caixa
{
    partial class frmImprimirVenda
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnImprimir = new Button();
            btnPreview = new Button();
            lblTitulo = new Label();
            lblSub = new Label();
            panelTopo = new Panel();
            button1 = new Button();
            panelTopo.SuspendLayout();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(45, 115, 210);
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 135, 230);
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(40, 105);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(150, 42);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "🖨  Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnPreview
            // 
            btnPreview.BackColor = Color.FromArgb(35, 95, 180);
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 120, 205);
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(210, 105);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(150, 42);
            btnPreview.TabIndex = 1;
            btnPreview.Text = "👁  Prévia";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Franklin Gothic Medium", 25F);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(16, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(220, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "IMPRIMIR";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSub
            // 
            lblSub.Font = new Font("Segoe UI", 10F);
            lblSub.ForeColor = Color.Gainsboro;
            lblSub.Location = new Point(240, 16);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(140, 20);
            lblSub.TabIndex = 1;
            lblSub.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTopo
            // 
            panelTopo.BackColor = Color.FromArgb(35, 95, 180);
            panelTopo.Controls.Add(button1);
            panelTopo.Controls.Add(lblTitulo);
            panelTopo.Controls.Add(lblSub);
            panelTopo.Dock = DockStyle.Top;
            panelTopo.Location = new Point(0, 0);
            panelTopo.Name = "panelTopo";
            panelTopo.Size = new Size(400, 54);
            panelTopo.TabIndex = 2;
            panelTopo.MouseDown += panelTopo_MouseDown;
            // 
            // button1
            // 
            button1.Location = new Point(305, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmImprimirVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(400, 185);
            Controls.Add(btnPreview);
            Controls.Add(btnImprimir);
            Controls.Add(panelTopo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmImprimirVenda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Impressão";
            panelTopo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Panel panelTopo;
        private Button button1;
    }
}