namespace ProjetoIntegradorSENAC.Configurações
{
    partial class configEmpresa
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dtgEmpresas = new DataGridView();
            label4 = new Label();
            mkTelefone = new MaskedTextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            btnSalvar = new Button();
            btnVoltar = new Button();
            label8 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            label9 = new Label();
            txtNomeFantasia = new TextBox();
            label10 = new Label();
            txtRazaoSocial = new TextBox();
            label5 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            btnExcluir = new Button();
            label12 = new Label();
            label18 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            button2 = new Button();
            panel2 = new Panel();
            label19 = new Label();
            label2 = new Label();
            label7 = new Label();
            mkCep = new MaskedTextBox();
            txtBairro = new TextBox();
            txtMunicipio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgEmpresas
            // 
            dtgEmpresas.AllowUserToAddRows = false;
            dtgEmpresas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(80, 80, 110);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dtgEmpresas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgEmpresas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtgEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEmpresas.BackgroundColor = Color.FromArgb(30, 30, 40);
            dtgEmpresas.BorderStyle = BorderStyle.None;
            dtgEmpresas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 20F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5, 10, 5, 10);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 60, 85);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgEmpresas.ColumnHeadersHeight = 60;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 14.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgEmpresas.DefaultCellStyle = dataGridViewCellStyle3;
            dtgEmpresas.EnableHeadersVisualStyles = false;
            dtgEmpresas.GridColor = Color.FromArgb(60, 60, 80);
            dtgEmpresas.Location = new Point(12, 172);
            dtgEmpresas.MultiSelect = false;
            dtgEmpresas.Name = "dtgEmpresas";
            dtgEmpresas.ReadOnly = true;
            dtgEmpresas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 16F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(90, 90, 120);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dtgEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgEmpresas.RowTemplate.Height = 45;
            dtgEmpresas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEmpresas.Size = new Size(510, 458);
            dtgEmpresas.TabIndex = 11;
            dtgEmpresas.CellClick += dtgEmpresas_CellClick;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi Cond", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(716, 9);
            label4.Name = "label4";
            label4.Size = new Size(350, 47);
            label4.TabIndex = 10;
            label4.Text = "Gerenciar Comercios!";
            label4.Click += label4_Click;
            // 
            // mkTelefone
            // 
            mkTelefone.BackColor = Color.White;
            mkTelefone.Font = new Font("Franklin Gothic Book", 20.25F);
            mkTelefone.ForeColor = Color.FromArgb(40, 40, 50);
            mkTelefone.Location = new Point(30, 281);
            mkTelefone.Mask = "(00) 00000-0000";
            mkTelefone.Name = "mkTelefone";
            mkTelefone.Size = new Size(596, 38);
            mkTelefone.TabIndex = 57;
            mkTelefone.TextChanged += mkTelefone_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(192, 0, 0);
            label16.Location = new Point(220, 254);
            label16.Name = "label16";
            label16.Size = new Size(16, 24);
            label16.TabIndex = 55;
            label16.Text = "*";
            label16.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(192, 0, 0);
            label15.Location = new Point(201, 172);
            label15.Name = "label15";
            label15.Size = new Size(16, 24);
            label15.TabIndex = 54;
            label15.Text = "*";
            label15.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(192, 0, 0);
            label14.Location = new Point(178, 95);
            label14.Name = "label14";
            label14.Size = new Size(16, 24);
            label14.TabIndex = 53;
            label14.Text = "*";
            label14.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(192, 0, 0);
            label13.Location = new Point(156, 19);
            label13.Name = "label13";
            label13.Size = new Size(16, 24);
            label13.TabIndex = 52;
            label13.Text = "*";
            label13.Visible = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = SystemColors.Highlight;
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(1058, 618);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(181, 35);
            btnSalvar.TabIndex = 51;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(612, 618);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(129, 35);
            btnVoltar.TabIndex = 50;
            btnVoltar.Text = "Sair";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 25F);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(1292, 149);
            label8.Name = "label8";
            label8.Size = new Size(0, 39);
            label8.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 172);
            label6.Name = "label6";
            label6.Size = new Size(169, 25);
            label6.TabIndex = 47;
            label6.Text = "Email da Empresa";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Franklin Gothic Book", 20.25F);
            txtEmail.ForeColor = Color.FromArgb(40, 40, 50);
            txtEmail.Location = new Point(30, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "  seuemail@gmail.com";
            txtEmail.Size = new Size(596, 38);
            txtEmail.TabIndex = 46;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 253);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 45;
            label1.Text = "Numero de Telefone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Medium", 15F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(30, 94);
            label9.Name = "label9";
            label9.Size = new Size(142, 25);
            label9.TabIndex = 39;
            label9.Text = "Nome Fantasia";
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.BackColor = Color.White;
            txtNomeFantasia.Font = new Font("Franklin Gothic Book", 20.25F);
            txtNomeFantasia.ForeColor = Color.FromArgb(40, 40, 50);
            txtNomeFantasia.Location = new Point(30, 122);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.PlaceholderText = "  Digite aqui o nome Fantasia";
            txtNomeFantasia.Size = new Size(596, 38);
            txtNomeFantasia.TabIndex = 38;
            txtNomeFantasia.TextChanged += txtNomeFantasia_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium", 15F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(30, 18);
            label10.Name = "label10";
            label10.Size = new Size(123, 25);
            label10.TabIndex = 37;
            label10.Text = "Razao Social";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.BackColor = Color.White;
            txtRazaoSocial.Font = new Font("Franklin Gothic Book", 20.25F);
            txtRazaoSocial.ForeColor = Color.FromArgb(40, 40, 50);
            txtRazaoSocial.Location = new Point(30, 46);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.PlaceholderText = "  Digite aqui a Razao Social";
            txtRazaoSocial.Size = new Size(596, 38);
            txtRazaoSocial.TabIndex = 36;
            txtRazaoSocial.TextChanged += txtRazaoSocial_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(9, 120);
            label5.Name = "label5";
            label5.Size = new Size(487, 39);
            label5.TabIndex = 58;
            label5.Text = "Selecione o                  desejado!";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Franklin Gothic Medium", 25F);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(188, 120);
            label11.Name = "label11";
            label11.Size = new Size(156, 39);
            label11.TabIndex = 59;
            label11.Text = "Comercio";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 30, 40);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(mkTelefone);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtNomeFantasia);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtRazaoSocial);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(582, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 379);
            panel1.TabIndex = 60;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(530, 336);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 59;
            button1.Text = "→";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.Maroon;
            btnExcluir.Location = new Point(854, 618);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(181, 35);
            btnExcluir.TabIndex = 52;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(192, 0, 0);
            label12.Location = new Point(664, 158);
            label12.Name = "label12";
            label12.Size = new Size(16, 24);
            label12.TabIndex = 64;
            label12.Text = "*";
            label12.Visible = false;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Franklin Gothic Medium", 15F);
            label18.ForeColor = Color.White;
            label18.Location = new Point(612, 157);
            label18.Name = "label18";
            label18.Size = new Size(56, 25);
            label18.TabIndex = 63;
            label18.Text = "CNPJ";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maskedTextBox1.BackColor = Color.White;
            maskedTextBox1.Enabled = false;
            maskedTextBox1.Font = new Font("Franklin Gothic Book", 20.25F);
            maskedTextBox1.ForeColor = Color.FromArgb(40, 40, 50);
            maskedTextBox1.Location = new Point(612, 187);
            maskedTextBox1.Mask = "  00,000,000/0000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(324, 38);
            maskedTextBox1.TabIndex = 62;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maskedTextBox2.BackColor = Color.White;
            maskedTextBox2.Enabled = false;
            maskedTextBox2.Font = new Font("Franklin Gothic Book", 20.25F);
            maskedTextBox2.ForeColor = Color.FromArgb(40, 40, 50);
            maskedTextBox2.Location = new Point(612, 187);
            maskedTextBox2.Mask = "  000,000,000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(324, 38);
            maskedTextBox2.TabIndex = 61;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Medium", 14F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(33, 336);
            button2.Name = "button2";
            button2.Size = new Size(96, 32);
            button2.TabIndex = 58;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(mkCep);
            panel2.Controls.Add(txtBairro);
            panel2.Controls.Add(txtMunicipio);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(582, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 379);
            panel2.TabIndex = 65;
            panel2.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Franklin Gothic Medium", 15F);
            label19.ForeColor = Color.White;
            label19.Location = new Point(30, 171);
            label19.Name = "label19";
            label19.Size = new Size(65, 25);
            label19.TabIndex = 64;
            label19.Text = "Bairro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 94);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 63;
            label2.Text = "Munícipio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 15F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 19);
            label7.Name = "label7";
            label7.Size = new Size(47, 25);
            label7.TabIndex = 62;
            label7.Text = "CEP";
            // 
            // mkCep
            // 
            mkCep.BackColor = Color.White;
            mkCep.Font = new Font("Franklin Gothic Book", 20.25F);
            mkCep.ForeColor = Color.FromArgb(40, 40, 50);
            mkCep.Location = new Point(30, 46);
            mkCep.Mask = "00000-000";
            mkCep.Name = "mkCep";
            mkCep.Size = new Size(619, 38);
            mkCep.TabIndex = 61;
            mkCep.TextChanged += mkCep_TextChanged;
            // 
            // txtBairro
            // 
            txtBairro.BackColor = Color.White;
            txtBairro.Font = new Font("Franklin Gothic Book", 20.25F);
            txtBairro.ForeColor = Color.FromArgb(40, 40, 50);
            txtBairro.Location = new Point(30, 199);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "  Digite aqui o Bairro do seu Comércio";
            txtBairro.Size = new Size(622, 38);
            txtBairro.TabIndex = 60;
            // 
            // txtMunicipio
            // 
            txtMunicipio.BackColor = Color.White;
            txtMunicipio.Font = new Font("Franklin Gothic Book", 20.25F);
            txtMunicipio.ForeColor = Color.FromArgb(40, 40, 50);
            txtMunicipio.Location = new Point(30, 122);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.PlaceholderText = "  Digite aqui o Municipio do seu Comércio";
            txtMunicipio.Size = new Size(622, 38);
            txtMunicipio.TabIndex = 59;
            // 
            // configEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(1280, 680);
            Controls.Add(btnExcluir);
            Controls.Add(label12);
            Controls.Add(label18);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(dtgEmpresas);
            Controls.Add(label4);
            Controls.Add(maskedTextBox1);
            Controls.Add(maskedTextBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "configEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "configEmpresa";
            Load += configEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgEmpresas;
        private Label label4;
        private MaskedTextBox mkTelefone;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button btnSalvar;
        private Button btnVoltar;
        private Label label8;
        private Label label6;
        private TextBox txtEmail;
        private Label label1;
        private Label label9;
        private TextBox txtNomeFantasia;
        private Label label10;
        private TextBox txtRazaoSocial;
        private Label label5;
        private Label label11;
        private Panel panel1;
        private Button btnExcluir;
        private Label label12;
        private Label label18;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label19;
        private Label label2;
        private Label label7;
        private MaskedTextBox mkCep;
        private TextBox txtBairro;
        private TextBox txtMunicipio;
    }
}