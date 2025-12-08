namespace ProjetoIntegradorSENAC.Estoque
{
    partial class MovimentacaoProdutos
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
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.Highlight;
            btnPesquisar.FlatStyle = FlatStyle.Popup;
            btnPesquisar.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(763, 12);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(112, 38);
            btnPesquisar.TabIndex = 46;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BackColor = Color.White;
            txtPesquisa.Font = new Font("Franklin Gothic Book", 20.25F);
            txtPesquisa.ForeColor = Color.FromArgb(40, 40, 50);
            txtPesquisa.Location = new Point(214, 12);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "  Digite nome ou código do Produto";
            txtPesquisa.Size = new Size(535, 38);
            txtPesquisa.TabIndex = 45;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(214, 56);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(661, 571);
            flowLayoutPanel1.TabIndex = 44;
            // 
            // MovimentacaoProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 682);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisa);
            Controls.Add(flowLayoutPanel1);
            Name = "MovimentacaoProdutos";
            Text = "MovimentacaoProdutos";
            Load += MovimentacaoProdutos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}