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
            panel2 = new Panel();
            btnMinimizar = new Button();
            btnSair = new Button();
            dtgEmpresas = new DataGridView();
            label4 = new Label();
            mkTelefone = new MaskedTextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            btnSalvar = new Button();
            btnVoltar = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            mkCNPJ = new MaskedTextBox();
            mkCPF = new MaskedTextBox();
            label9 = new Label();
            txtNomeFantasia = new TextBox();
            label10 = new Label();
            txtRazaoSocial = new TextBox();
            label5 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnSair);
            panel2.Location = new Point(2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1807, 32);
            panel2.TabIndex = 5;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(1691, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(54, 33);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(1741, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(54, 33);
            btnSair.TabIndex = 1;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            dtgEmpresas.AllowUserToAddRows = false;
            dtgEmpresas.AllowUserToDeleteRows = false;
            dtgEmpresas.AllowUserToOrderColumns = false;
            dtgEmpresas.ReadOnly = true;
            dtgEmpresas.MultiSelect = false;
            dtgEmpresas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtgEmpresas.BackgroundColor = Color.FromArgb(30, 30, 40);
            dtgEmpresas.BorderStyle = BorderStyle.None;
            dtgEmpresas.GridColor = Color.FromArgb(60, 60, 80);

            dtgEmpresas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgEmpresas.RowHeadersVisible = false;

            // Alternating rows
            DataGridViewCellStyle alt = new DataGridViewCellStyle();
            alt.BackColor = Color.FromArgb(35, 35, 45);
            alt.ForeColor = Color.White;
            alt.SelectionBackColor = Color.FromArgb(80, 80, 110);
            alt.SelectionForeColor = Color.White;
            dtgEmpresas.AlternatingRowsDefaultCellStyle = alt;

            // Default rows
            DataGridViewCellStyle rows = new DataGridViewCellStyle();
            rows.BackColor = Color.FromArgb(40, 40, 50);
            rows.Font = new Font("Franklin Gothic Medium", 16F, FontStyle.Regular);
            rows.ForeColor = Color.White;
            rows.Padding = new Padding(5);
            rows.SelectionBackColor = Color.FromArgb(90, 90, 120);
            rows.SelectionForeColor = Color.White;
            dtgEmpresas.RowsDefaultCellStyle = rows;

            // Column headers
            DataGridViewCellStyle header = new DataGridViewCellStyle();
            header.BackColor = Color.FromArgb(50, 50, 70);
            header.ForeColor = Color.White;
            header.Font = new Font("Franklin Gothic Medium", 20F, FontStyle.Bold);
            header.Alignment = DataGridViewContentAlignment.MiddleCenter;
            header.SelectionBackColor = Color.FromArgb(60, 60, 85);
            header.SelectionForeColor = Color.White;
            header.Padding = new Padding(5, 10, 5, 10);
            header.WrapMode = DataGridViewTriState.True;
            dtgEmpresas.ColumnHeadersDefaultCellStyle = header;

            dtgEmpresas.ColumnHeadersHeight = 60;
            dtgEmpresas.EnableHeadersVisualStyles = false;

            dtgEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgEmpresas.RowTemplate.Height = 45;

            dtgEmpresas.Location = new Point(41, 217);
            dtgEmpresas.Size = new Size(792, 458);

            dtgEmpresas.TabIndex = 11;
            dtgEmpresas.CellClick += dtgEmpresas_CellClick;
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi Cond", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(770, 56);
            label4.Name = "label4";
            label4.Size = new Size(323, 47);
            label4.TabIndex = 10;
            label4.Text = "Bem vindo, Usuario!";
            // 
            // mkTelefone
            // 
            mkTelefone.BackColor = Color.White;
            mkTelefone.Font = new Font("Franklin Gothic Book", 20.25F);
            mkTelefone.ForeColor = Color.FromArgb(40, 40, 50);
            mkTelefone.Location = new Point(890, 485);
            mkTelefone.Mask = "(00) 00000-0000";
            mkTelefone.Name = "mkTelefone";
            mkTelefone.Size = new Size(558, 38);
            mkTelefone.TabIndex = 57;
            mkTelefone.TextChanged += mkTelefone_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(192, 0, 0);
            label17.Location = new Point(1055, 532);
            label17.Name = "label17";
            label17.Size = new Size(16, 24);
            label17.TabIndex = 56;
            label17.Text = "*";
            label17.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(192, 0, 0);
            label16.Location = new Point(1068, 457);
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
            label15.Location = new Point(1241, 382);
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
            label14.Location = new Point(1027, 312);
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
            label13.Location = new Point(1008, 236);
            label13.Name = "label13";
            label13.Size = new Size(16, 24);
            label13.TabIndex = 52;
            label13.Text = "*";
            label13.Visible = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(1513, 613);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(234, 35);
            btnSalvar.TabIndex = 51;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(1303, 613);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(181, 35);
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
            label8.Size = new Size(156, 39);
            label8.TabIndex = 49;
            label8.Text = "Comercio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1102, 149);
            label7.Name = "label7";
            label7.Size = new Size(426, 39);
            label7.TabIndex = 48;
            label7.Text = "Atualize seu                  aqui!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(890, 532);
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
            txtEmail.Location = new Point(890, 560);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "  seuemail@gmail.com";
            txtEmail.Size = new Size(857, 38);
            txtEmail.TabIndex = 46;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(890, 457);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 45;
            label1.Text = "Numero de Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1189, 381);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 44;
            label2.Text = "CNPJ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(890, 383);
            label3.Name = "label3";
            label3.Size = new Size(194, 25);
            label3.TabIndex = 43;
            label3.Text = "Escolha CNPJ ou CPF";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 40);
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton1);
            panel3.Location = new Point(890, 411);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 31);
            panel3.TabIndex = 42;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.FlatStyle = FlatStyle.Popup;
            radioButton2.Font = new Font("Franklin Gothic Medium", 15F);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(26, 0);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 29);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "CNPJ";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.FlatAppearance.CheckedBackColor = Color.Lime;
            radioButton1.FlatStyle = FlatStyle.Popup;
            radioButton1.Font = new Font("Franklin Gothic Medium", 15F);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(158, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 29);
            radioButton1.TabIndex = 17;
            radioButton1.Text = "CPF";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // mkCNPJ
            // 
            mkCNPJ.BackColor = Color.White;
            mkCNPJ.Font = new Font("Franklin Gothic Book", 20.25F);
            mkCNPJ.ForeColor = Color.FromArgb(40, 40, 50);
            mkCNPJ.Location = new Point(329, 194);
            mkCNPJ.Mask = "  00.000.000/0000-00";
            mkCNPJ.Name = "mkCNPJ";
            mkCNPJ.Size = new Size(558, 38);
            mkCNPJ.TabIndex = 41;
            mkCNPJ.TextChanged += mkCNPJ_TextChanged;
            // 
            // mkCPF
            // 
            mkCPF.BackColor = Color.White;
            mkCPF.Font = new Font("Franklin Gothic Book", 20.25F);
            mkCPF.ForeColor = Color.FromArgb(40, 40, 50);
            mkCPF.Location = new Point(1189, 411);
            mkCPF.Mask = "  000.000.000-00";
            mkCPF.Name = "mkCPF";
            mkCPF.Size = new Size(558, 38);
            mkCPF.TabIndex = 40;
            mkCPF.TextChanged += mkCPF_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Medium", 15F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(890, 308);
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
            txtNomeFantasia.Location = new Point(890, 336);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.PlaceholderText = "  Digite aqui o nome Fantasia";
            txtNomeFantasia.Size = new Size(857, 38);
            txtNomeFantasia.TabIndex = 38;
            txtNomeFantasia.TextChanged += txtNomeFantasia_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium", 15F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(890, 236);
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
            txtRazaoSocial.Location = new Point(890, 264);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.PlaceholderText = "  Digite aqui a Razao Social";
            txtRazaoSocial.Size = new Size(857, 38);
            txtRazaoSocial.TabIndex = 36;
            txtRazaoSocial.TextChanged += txtRazaoSocial_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(170, 149);
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
            label11.Location = new Point(349, 149);
            label11.Name = "label11";
            label11.Size = new Size(156, 39);
            label11.TabIndex = 59;
            label11.Text = "Comercio";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 40);
            panel1.Controls.Add(mkCNPJ);
            panel1.Location = new Point(860, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 458);
            panel1.TabIndex = 60;
            // 
            // configEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 45);
            ClientSize = new Size(1798, 732);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(mkTelefone);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(mkCPF);
            Controls.Add(label9);
            Controls.Add(txtNomeFantasia);
            Controls.Add(label10);
            Controls.Add(txtRazaoSocial);
            Controls.Add(dtgEmpresas);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "configEmpresa";
            Text = "configEmpresa";
            Load += configEmpresa_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgEmpresas).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnMinimizar;
        private Button btnSair;
        private DataGridView dtgEmpresas;
        private Label label4;
        private MaskedTextBox mkTelefone;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button btnSalvar;
        private Button btnVoltar;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private MaskedTextBox mkCNPJ;
        private MaskedTextBox mkCPF;
        private Label label9;
        private TextBox txtNomeFantasia;
        private Label label10;
        private TextBox txtRazaoSocial;
        private Label label5;
        private Label label11;
        private Panel panel1;
    }
}