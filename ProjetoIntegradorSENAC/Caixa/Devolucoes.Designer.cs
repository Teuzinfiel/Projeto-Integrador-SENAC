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

            // panelTop
            panelTop.BackColor = Color.FromArgb(30, 30, 40);
            panelTop.Controls.Add(btnMinimizar);
            panelTop.Controls.Add(btnFechar);
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 32;

            // btnMinimizar
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Text = "-";
            btnMinimizar.Size = new Size(40, 30);
            btnMinimizar.Location = new Point(300, 0);
            btnMinimizar.Click += (s, e) => WindowState = FormWindowState.Minimized;

            // btnFechar
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.ForeColor = Color.White;
            btnFechar.Text = "X";
            btnFechar.Size = new Size(40, 30);
            btnFechar.Location = new Point(340, 0);
            btnFechar.Click += (s, e) => Close();

            // panelBody
            panelBody.BackColor = Color.FromArgb(40, 40, 50);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Padding = new Padding(20);

            // labelTitulo
            labelTitulo.Text = "Devolução de Venda";
            labelTitulo.Font = new Font("Franklin Gothic Demi Cond", 26F);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(40, 25);

            // labelSub
            labelSub.Text = "Informe o código do consumidor para estornar a venda";
            labelSub.Font = new Font("Franklin Gothic Book", 12F);
            labelSub.ForeColor = Color.Gainsboro;
            labelSub.AutoSize = true;
            labelSub.Location = new Point(40, 70);

            // labelCodigo
            labelCodigo.Text = "Código da Venda";
            labelCodigo.Font = new Font("Franklin Gothic Medium", 14F);
            labelCodigo.ForeColor = Color.White;
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(40, 120);

            // textBox1
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(40, 150);
            textBox1.Width = 300;
            textBox1.BorderStyle = BorderStyle.FixedSingle;

            // button1
            button1.Text = "Confirmar Devolução";
            button1.Font = new Font("Franklin Gothic Medium", 14F);
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Size = new Size(300, 50);
            button1.Location = new Point(40, 210);
            button1.Click += button1_Click;

            // btnCancelar
            btnCancelar.Text = "Cancelar";
            btnCancelar.Font = new Font("Franklin Gothic Medium", 12F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Size = new Size(300, 40);
            btnCancelar.Location = new Point(40, 270);
            btnCancelar.BackColor = Color.FromArgb(80, 80, 100);
            btnCancelar.Click += (s, e) => Close();

            // Devolucoes
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(380, 360);
            Controls.Add(panelBody);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Devoluções";

            panelBody.Controls.Add(labelTitulo);
            panelBody.Controls.Add(labelSub);
            panelBody.Controls.Add(labelCodigo);
            panelBody.Controls.Add(textBox1);
            panelBody.Controls.Add(button1);
            panelBody.Controls.Add(btnCancelar);

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