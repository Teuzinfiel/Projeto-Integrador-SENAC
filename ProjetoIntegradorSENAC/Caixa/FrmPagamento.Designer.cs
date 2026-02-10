namespace ProjetoIntegradorSENAC.Caixa
{
    partial class FrmPagamento
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
            btnDinheiro = new Button();
            btnCredito = new Button();
            btnDebito = new Button();
            btnPix = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnDinheiro
            // 
            btnDinheiro.Location = new Point(333, 59);
            btnDinheiro.Name = "btnDinheiro";
            btnDinheiro.Size = new Size(75, 23);
            btnDinheiro.TabIndex = 0;
            btnDinheiro.Text = "button1";
            btnDinheiro.UseVisualStyleBackColor = true;
            btnDinheiro.Click += btnDinheiro_Click_1;
            // 
            // btnCredito
            // 
            btnCredito.Location = new Point(333, 101);
            btnCredito.Name = "btnCredito";
            btnCredito.Size = new Size(75, 23);
            btnCredito.TabIndex = 1;
            btnCredito.Text = "button2";
            btnCredito.UseVisualStyleBackColor = true;
            btnCredito.Click += btnCredito_Click_1;
            // 
            // btnDebito
            // 
            btnDebito.Location = new Point(333, 155);
            btnDebito.Name = "btnDebito";
            btnDebito.Size = new Size(75, 23);
            btnDebito.TabIndex = 2;
            btnDebito.Text = "button3";
            btnDebito.UseVisualStyleBackColor = true;
            btnDebito.Click += btnDebito_Click_1;
            // 
            // btnPix
            // 
            btnPix.Location = new Point(333, 204);
            btnPix.Name = "btnPix";
            btnPix.Size = new Size(75, 23);
            btnPix.TabIndex = 3;
            btnPix.Text = "button4";
            btnPix.UseVisualStyleBackColor = true;
            btnPix.Click += btnPix_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(333, 281);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "button1";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // FrmPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnPix);
            Controls.Add(btnDebito);
            Controls.Add(btnCredito);
            Controls.Add(btnDinheiro);
            Name = "FrmPagamento";
            Text = "FrmPagamento";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDinheiro;
        private Button btnCredito;
        private Button btnDebito;
        private Button btnPix;
        private Button btnCancelar;
    }
}