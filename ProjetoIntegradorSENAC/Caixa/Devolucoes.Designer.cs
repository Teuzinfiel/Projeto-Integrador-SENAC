namespace ProjetoIntegradorSENAC.Caixa
{
    partial class Devolucoes
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
            panelTop = new Panel();
            btnMinimizar = new Button();
            btnFechar = new Button();
            panelBody = new Panel();
            labelTitulo = new Label();
            labelSub = new Label();
            labelCodigo = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            btnCancelar = new Button();
            panelTop.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(30, 30, 40);
            panelTop.Controls.Add(btnMinimizar);
            panelTop.Controls.Add(btnFechar);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(434, 43);
            panelTop.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(343, 0);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(46, 40);
            btnMinimizar.TabIndex = 0;
            btnMinimizar.Text = "-";
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnFechar
            // 
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(389, 0);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(46, 40);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.Click += btnFechar_Click;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.FromArgb(40, 40, 50);
            panelBody.Controls.Add(labelTitulo);
            panelBody.Controls.Add(labelSub);
            panelBody.Controls.Add(labelCodigo);
            panelBody.Controls.Add(textBox1);
            panelBody.Controls.Add(button1);
            panelBody.Controls.Add(btnCancelar);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 43);
            panelBody.Margin = new Padding(3, 4, 3, 4);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(23, 27, 23, 27);
            panelBody.Size = new Size(434, 437);
            panelBody.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Microsoft Sans Serif", 26F);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(6, 27);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(425, 52);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Devolução de Venda";
            // 
            // labelSub
            // 
            labelSub.AutoSize = true;
            labelSub.Font = new Font("Microsoft Sans Serif", 12F);
            labelSub.ForeColor = Color.Gainsboro;
            labelSub.Location = new Point(62, 89);
            labelSub.Name = "labelSub";
            labelSub.Size = new Size(294, 50);
            labelSub.TabIndex = 1;
            labelSub.Text = "Informe o código do consumidor \r\npara estornar a venda";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Franklin Gothic Medium", 14F);
            labelCodigo.ForeColor = Color.White;
            labelCodigo.Location = new Point(46, 160);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(187, 30);
            labelCodigo.TabIndex = 2;
            labelCodigo.Text = "Código da Venda";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(46, 200);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 39);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(46, 280);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(343, 67);
            button1.TabIndex = 4;
            button1.Text = "Confirmar Devolução";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(80, 80, 100);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Franklin Gothic Medium", 12F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(46, 360);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(343, 53);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Devolucoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(434, 480);
            Controls.Add(panelBody);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Devolucoes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Devoluções";
            Load += Devolucoes_Load;
            panelTop.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnMinimizar;
        private Button btnFechar;

        private Panel panelBody;
        private Label labelTitulo;
        private Label labelSub;
        private Label labelCodigo;
        private TextBox textBox1;
        private Button button1;
        private Button btnCancelar;
    }
}