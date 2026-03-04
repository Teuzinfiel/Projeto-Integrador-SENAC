namespace ProjetoIntegradorSENAC.Estoque
{
    partial class frmControleEstoque
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
            dtgProdutos = new DataGridView();
            label11 = new Label();
            panel2 = new Panel();
            panel14 = new Panel();
            astDescSaida = new Label();
            astTpSaida = new Label();
            astQtdSaida = new Label();
            btnEnviarSaida = new Button();
            label18 = new Label();
            txtDescSaida = new RichTextBox();
            panel18 = new Panel();
            label19 = new Label();
            lbSaldoAposSaida = new Label();
            label21 = new Label();
            cbTipoSaida = new ComboBox();
            label22 = new Label();
            mkQuantidadeSaida = new TextBox();
            label10 = new Label();
            label8 = new Label();
            panel13 = new Panel();
            astDescEntrada = new Label();
            astTpEntrada = new Label();
            astQtdEntrada = new Label();
            btnEnviarEntrada = new Button();
            label15 = new Label();
            txtDescEntrada = new RichTextBox();
            panel17 = new Panel();
            label16 = new Label();
            lbSaldoAposEntrada = new Label();
            label14 = new Label();
            cbTipoEntrada = new ComboBox();
            label13 = new Label();
            mkQuantidadeEntrada = new TextBox();
            label9 = new Label();
            label7 = new Label();
            panel15 = new Panel();
            button1 = new Button();
            btnPesquisar = new Button();
            label12 = new Label();
            panel16 = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            panel5 = new Panel();
            panel12 = new Panel();
            label5 = new Label();
            txtStatusPd = new TextBox();
            panel3 = new Panel();
            txtNomePd = new TextBox();
            panel8 = new Panel();
            label6 = new Label();
            label1 = new Label();
            panel6 = new Panel();
            txtUnidadePd = new TextBox();
            panel10 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            panel9 = new Panel();
            label2 = new Label();
            txtCatPd = new TextBox();
            panel7 = new Panel();
            panel11 = new Panel();
            label4 = new Label();
            TxtSaldoPd = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel21 = new Panel();
            panel22 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            panel2.SuspendLayout();
            panel14.SuspendLayout();
            panel18.SuspendLayout();
            panel13.SuspendLayout();
            panel17.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel5.SuspendLayout();
            panel12.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel11.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToAddRows = false;
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 45);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dtgProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProdutos.BackgroundColor = Color.FromArgb(30, 35, 45);
            dtgProdutos.BorderStyle = BorderStyle.None;
            dtgProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProdutos.Dock = DockStyle.Fill;
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.FromArgb(60, 60, 80);
            dtgProdutos.Location = new Point(0, 49);
            dtgProdutos.MultiSelect = false;
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 50);
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(70, 70, 90);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dtgProdutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgProdutos.RowTemplate.Height = 20;
            dtgProdutos.Size = new Size(609, 256);
            dtgProdutos.TabIndex = 45;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Franklin Gothic Demi", 18F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(42, 22);
            label11.Name = "label11";
            label11.Size = new Size(263, 60);
            label11.TabIndex = 4;
            label11.Text = "Informações do produto\r\n selecionado";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 40);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(377, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(609, 305);
            panel2.TabIndex = 47;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(40, 40, 50);
            panel14.Controls.Add(astDescSaida);
            panel14.Controls.Add(astTpSaida);
            panel14.Controls.Add(astQtdSaida);
            panel14.Controls.Add(btnEnviarSaida);
            panel14.Controls.Add(label18);
            panel14.Controls.Add(txtDescSaida);
            panel14.Controls.Add(panel18);
            panel14.Controls.Add(label21);
            panel14.Controls.Add(cbTipoSaida);
            panel14.Controls.Add(label22);
            panel14.Controls.Add(mkQuantidadeSaida);
            panel14.Controls.Add(label10);
            panel14.Controls.Add(label8);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(307, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(299, 299);
            panel14.TabIndex = 49;
            // 
            // astDescSaida
            // 
            astDescSaida.AutoSize = true;
            astDescSaida.FlatStyle = FlatStyle.System;
            astDescSaida.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astDescSaida.ForeColor = Color.FromArgb(192, 0, 0);
            astDescSaida.Location = new Point(119, 176);
            astDescSaida.Name = "astDescSaida";
            astDescSaida.Size = new Size(16, 24);
            astDescSaida.TabIndex = 76;
            astDescSaida.Text = "*";
            astDescSaida.Visible = false;
            // 
            // astTpSaida
            // 
            astTpSaida.AutoSize = true;
            astTpSaida.FlatStyle = FlatStyle.System;
            astTpSaida.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astTpSaida.ForeColor = Color.FromArgb(192, 0, 0);
            astTpSaida.Location = new Point(148, 113);
            astTpSaida.Name = "astTpSaida";
            astTpSaida.Size = new Size(16, 24);
            astTpSaida.TabIndex = 75;
            astTpSaida.Text = "*";
            astTpSaida.Visible = false;
            // 
            // astQtdSaida
            // 
            astQtdSaida.AutoSize = true;
            astQtdSaida.FlatStyle = FlatStyle.System;
            astQtdSaida.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astQtdSaida.ForeColor = Color.FromArgb(192, 0, 0);
            astQtdSaida.Location = new Point(201, 52);
            astQtdSaida.Name = "astQtdSaida";
            astQtdSaida.Size = new Size(16, 24);
            astQtdSaida.TabIndex = 74;
            astQtdSaida.Text = "*";
            astQtdSaida.Visible = false;
            // 
            // btnEnviarSaida
            // 
            btnEnviarSaida.BackColor = Color.Transparent;
            btnEnviarSaida.FlatStyle = FlatStyle.Flat;
            btnEnviarSaida.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviarSaida.ForeColor = Color.DarkRed;
            btnEnviarSaida.Location = new Point(148, 248);
            btnEnviarSaida.Name = "btnEnviarSaida";
            btnEnviarSaida.Size = new Size(124, 35);
            btnEnviarSaida.TabIndex = 61;
            btnEnviarSaida.Text = "Enviar";
            btnEnviarSaida.UseVisualStyleBackColor = false;
            btnEnviarSaida.Click += btnEnviarSaida_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Franklin Gothic Book", 14F);
            label18.ForeColor = Color.White;
            label18.Location = new Point(24, 177);
            label18.Name = "label18";
            label18.Size = new Size(89, 24);
            label18.TabIndex = 59;
            label18.Text = "Descrição";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescSaida
            // 
            txtDescSaida.Font = new Font("Segoe UI", 12F);
            txtDescSaida.Location = new Point(24, 204);
            txtDescSaida.Name = "txtDescSaida";
            txtDescSaida.Size = new Size(116, 79);
            txtDescSaida.TabIndex = 58;
            txtDescSaida.Text = "";
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(30, 30, 40);
            panel18.Controls.Add(label19);
            panel18.Controls.Add(lbSaldoAposSaida);
            panel18.Location = new Point(148, 204);
            panel18.Name = "panel18";
            panel18.Size = new Size(126, 37);
            panel18.TabIndex = 60;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Franklin Gothic Demi", 16F);
            label19.ForeColor = Color.White;
            label19.Location = new Point(0, 4);
            label19.Name = "label19";
            label19.Size = new Size(90, 28);
            label19.TabIndex = 54;
            label19.Text = "S/Após:";
            // 
            // lbSaldoAposSaida
            // 
            lbSaldoAposSaida.AutoSize = true;
            lbSaldoAposSaida.BackColor = Color.Transparent;
            lbSaldoAposSaida.Font = new Font("Franklin Gothic Demi", 14F);
            lbSaldoAposSaida.ForeColor = Color.White;
            lbSaldoAposSaida.Location = new Point(86, 6);
            lbSaldoAposSaida.Name = "lbSaldoAposSaida";
            lbSaldoAposSaida.Size = new Size(42, 24);
            lbSaldoAposSaida.TabIndex = 55;
            lbSaldoAposSaida.Text = "XYZ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Franklin Gothic Book", 14F);
            label21.ForeColor = Color.White;
            label21.Location = new Point(24, 114);
            label21.Name = "label21";
            label21.Size = new Size(118, 24);
            label21.TabIndex = 57;
            label21.Text = "Tipo de Saida";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbTipoSaida
            // 
            cbTipoSaida.FlatStyle = FlatStyle.Popup;
            cbTipoSaida.Font = new Font("Franklin Gothic Demi Cond", 14F);
            cbTipoSaida.FormattingEnabled = true;
            cbTipoSaida.Items.AddRange(new object[] { "DEVOLUCAO_CLIENTE", "AJUSTE_NEGATIVO", "OUTROS" });
            cbTipoSaida.Location = new Point(24, 141);
            cbTipoSaida.Name = "cbTipoSaida";
            cbTipoSaida.Size = new Size(248, 32);
            cbTipoSaida.TabIndex = 56;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Franklin Gothic Book", 14F);
            label22.ForeColor = Color.White;
            label22.Location = new Point(24, 53);
            label22.Name = "label22";
            label22.Size = new Size(177, 24);
            label22.TabIndex = 55;
            label22.Text = "Quantidade de Saida";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mkQuantidadeSaida
            // 
            mkQuantidadeSaida.BackColor = Color.White;
            mkQuantidadeSaida.Font = new Font("Franklin Gothic Book", 16F);
            mkQuantidadeSaida.ForeColor = Color.FromArgb(40, 40, 50);
            mkQuantidadeSaida.Location = new Point(24, 80);
            mkQuantidadeSaida.Name = "mkQuantidadeSaida";
            mkQuantidadeSaida.PlaceholderText = "Digite a quantidade";
            mkQuantidadeSaida.Size = new Size(248, 32);
            mkQuantidadeSaida.TabIndex = 54;
            mkQuantidadeSaida.TextChanged += mkQuantidadeSaida_TextChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Franklin Gothic Demi", 18F);
            label10.ForeColor = Color.DarkRed;
            label10.Location = new Point(56, 10);
            label10.Name = "label10";
            label10.Size = new Size(72, 30);
            label10.TabIndex = 3;
            label10.Text = "Saida";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Franklin Gothic Demi", 18F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(118, 10);
            label8.Name = "label8";
            label8.Size = new Size(137, 30);
            label8.TabIndex = 2;
            label8.Text = "do produto";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(40, 40, 50);
            panel13.Controls.Add(astDescEntrada);
            panel13.Controls.Add(astTpEntrada);
            panel13.Controls.Add(astQtdEntrada);
            panel13.Controls.Add(btnEnviarEntrada);
            panel13.Controls.Add(label15);
            panel13.Controls.Add(txtDescEntrada);
            panel13.Controls.Add(panel17);
            panel13.Controls.Add(label14);
            panel13.Controls.Add(cbTipoEntrada);
            panel13.Controls.Add(label13);
            panel13.Controls.Add(mkQuantidadeEntrada);
            panel13.Controls.Add(label9);
            panel13.Controls.Add(label7);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(3, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(298, 299);
            panel13.TabIndex = 48;
            // 
            // astDescEntrada
            // 
            astDescEntrada.AutoSize = true;
            astDescEntrada.FlatStyle = FlatStyle.System;
            astDescEntrada.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astDescEntrada.ForeColor = Color.FromArgb(192, 0, 0);
            astDescEntrada.Location = new Point(115, 177);
            astDescEntrada.Name = "astDescEntrada";
            astDescEntrada.Size = new Size(16, 24);
            astDescEntrada.TabIndex = 73;
            astDescEntrada.Text = "*";
            astDescEntrada.Visible = false;
            // 
            // astTpEntrada
            // 
            astTpEntrada.AutoSize = true;
            astTpEntrada.FlatStyle = FlatStyle.System;
            astTpEntrada.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astTpEntrada.ForeColor = Color.FromArgb(192, 0, 0);
            astTpEntrada.Location = new Point(164, 115);
            astTpEntrada.Name = "astTpEntrada";
            astTpEntrada.Size = new Size(16, 24);
            astTpEntrada.TabIndex = 72;
            astTpEntrada.Text = "*";
            astTpEntrada.Visible = false;
            // 
            // astQtdEntrada
            // 
            astQtdEntrada.AutoSize = true;
            astQtdEntrada.FlatStyle = FlatStyle.System;
            astQtdEntrada.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            astQtdEntrada.ForeColor = Color.FromArgb(192, 0, 0);
            astQtdEntrada.Location = new Point(217, 54);
            astQtdEntrada.Name = "astQtdEntrada";
            astQtdEntrada.Size = new Size(16, 24);
            astQtdEntrada.TabIndex = 71;
            astQtdEntrada.Text = "*";
            astQtdEntrada.Visible = false;
            // 
            // btnEnviarEntrada
            // 
            btnEnviarEntrada.BackColor = Color.Transparent;
            btnEnviarEntrada.FlatStyle = FlatStyle.Flat;
            btnEnviarEntrada.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviarEntrada.ForeColor = Color.ForestGreen;
            btnEnviarEntrada.Location = new Point(143, 248);
            btnEnviarEntrada.Name = "btnEnviarEntrada";
            btnEnviarEntrada.Size = new Size(126, 35);
            btnEnviarEntrada.TabIndex = 53;
            btnEnviarEntrada.Text = "Enviar";
            btnEnviarEntrada.UseVisualStyleBackColor = false;
            btnEnviarEntrada.Click += btnEnviarEntrada_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Franklin Gothic Book", 14F);
            label15.ForeColor = Color.White;
            label15.Location = new Point(21, 177);
            label15.Name = "label15";
            label15.Size = new Size(89, 24);
            label15.TabIndex = 51;
            label15.Text = "Descrição";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescEntrada
            // 
            txtDescEntrada.Font = new Font("Segoe UI", 12F);
            txtDescEntrada.Location = new Point(21, 204);
            txtDescEntrada.Name = "txtDescEntrada";
            txtDescEntrada.Size = new Size(116, 79);
            txtDescEntrada.TabIndex = 50;
            txtDescEntrada.Text = "";
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(30, 30, 40);
            panel17.Controls.Add(label16);
            panel17.Controls.Add(lbSaldoAposEntrada);
            panel17.Location = new Point(143, 204);
            panel17.Name = "panel17";
            panel17.Size = new Size(126, 37);
            panel17.TabIndex = 51;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Franklin Gothic Demi", 16F);
            label16.ForeColor = Color.White;
            label16.Location = new Point(0, 4);
            label16.Name = "label16";
            label16.Size = new Size(90, 28);
            label16.TabIndex = 54;
            label16.Text = "S/Após:";
            // 
            // lbSaldoAposEntrada
            // 
            lbSaldoAposEntrada.AutoSize = true;
            lbSaldoAposEntrada.BackColor = Color.Transparent;
            lbSaldoAposEntrada.Font = new Font("Franklin Gothic Demi", 14F);
            lbSaldoAposEntrada.ForeColor = Color.White;
            lbSaldoAposEntrada.Location = new Point(86, 6);
            lbSaldoAposEntrada.Name = "lbSaldoAposEntrada";
            lbSaldoAposEntrada.Size = new Size(42, 24);
            lbSaldoAposEntrada.TabIndex = 55;
            lbSaldoAposEntrada.Text = "XYZ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Franklin Gothic Book", 14F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(23, 115);
            label14.Name = "label14";
            label14.Size = new Size(135, 24);
            label14.TabIndex = 49;
            label14.Text = "Tipo de Entrada";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbTipoEntrada
            // 
            cbTipoEntrada.FlatStyle = FlatStyle.Popup;
            cbTipoEntrada.Font = new Font("Franklin Gothic Demi Cond", 14F);
            cbTipoEntrada.FormattingEnabled = true;
            cbTipoEntrada.Items.AddRange(new object[] { "DEVOLUCAO_CLIENTE", "AJUSTE_POSITIVO", "OUTROS" });
            cbTipoEntrada.Location = new Point(21, 141);
            cbTipoEntrada.Name = "cbTipoEntrada";
            cbTipoEntrada.Size = new Size(248, 32);
            cbTipoEntrada.TabIndex = 48;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Franklin Gothic Book", 14F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(23, 52);
            label13.Name = "label13";
            label13.Size = new Size(194, 24);
            label13.TabIndex = 47;
            label13.Text = "Quantidade de Entrada";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mkQuantidadeEntrada
            // 
            mkQuantidadeEntrada.BackColor = Color.White;
            mkQuantidadeEntrada.Font = new Font("Franklin Gothic Book", 16F);
            mkQuantidadeEntrada.ForeColor = Color.FromArgb(40, 40, 50);
            mkQuantidadeEntrada.Location = new Point(23, 80);
            mkQuantidadeEntrada.Name = "mkQuantidadeEntrada";
            mkQuantidadeEntrada.PlaceholderText = "Digite a quantidade";
            mkQuantidadeEntrada.Size = new Size(248, 32);
            mkQuantidadeEntrada.TabIndex = 46;
            mkQuantidadeEntrada.TextChanged += mkQuantidadeEntrada_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Franklin Gothic Demi", 18F);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(38, 10);
            label9.Name = "label9";
            label9.Size = new Size(95, 30);
            label9.TabIndex = 2;
            label9.Text = "Entrada";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Franklin Gothic Demi", 18F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(126, 10);
            label7.Name = "label7";
            label7.Size = new Size(133, 30);
            label7.TabIndex = 1;
            label7.Text = "do produto";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(30, 30, 40);
            panel15.Controls.Add(button1);
            panel15.Controls.Add(btnPesquisar);
            panel15.Dock = DockStyle.Bottom;
            panel15.Location = new Point(0, 518);
            panel15.Name = "panel15";
            panel15.Size = new Size(368, 98);
            panel15.TabIndex = 49;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(136, 26);
            button1.Name = "button1";
            button1.Size = new Size(210, 42);
            button1.TabIndex = 48;
            button1.Text = "Ver Movimentações";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top;
            btnPesquisar.BackColor = SystemColors.Highlight;
            btnPesquisar.FlatStyle = FlatStyle.Popup;
            btnPesquisar.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(27, 26);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(105, 42);
            btnPesquisar.TabIndex = 47;
            btnPesquisar.Text = "Voltar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Franklin Gothic Demi", 15F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(125, 12);
            label12.Name = "label12";
            label12.Size = new Size(363, 25);
            label12.TabIndex = 5;
            label12.Text = "Movimentações do produto selecionado";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(30, 30, 40);
            panel16.Controls.Add(label11);
            panel16.Dock = DockStyle.Top;
            panel16.Location = new Point(0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(368, 101);
            panel16.TabIndex = 50;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(30, 30, 40);
            panel19.Controls.Add(label12);
            panel19.Dock = DockStyle.Top;
            panel19.Location = new Point(0, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(609, 49);
            panel19.TabIndex = 51;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(30, 30, 40);
            panel20.Controls.Add(panel5);
            panel20.Controls.Add(panel3);
            panel20.Controls.Add(panel6);
            panel20.Controls.Add(panel4);
            panel20.Controls.Add(panel7);
            panel20.Dock = DockStyle.Fill;
            panel20.Location = new Point(0, 101);
            panel20.Name = "panel20";
            panel20.Size = new Size(368, 515);
            panel20.TabIndex = 52;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(45, 45, 60);
            panel5.Controls.Add(panel12);
            panel5.Controls.Add(txtStatusPd);
            panel5.Location = new Point(19, 338);
            panel5.Name = "panel5";
            panel5.Size = new Size(340, 37);
            panel5.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(35, 35, 50);
            panel12.Controls.Add(label5);
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(159, 37);
            panel12.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Franklin Gothic Demi", 18F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 3);
            label5.Name = "label5";
            label5.Size = new Size(86, 30);
            label5.TabIndex = 1;
            label5.Text = "Status:";
            // 
            // txtStatusPd
            // 
            txtStatusPd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatusPd.BackColor = Color.FromArgb(45, 45, 60);
            txtStatusPd.BorderStyle = BorderStyle.None;
            txtStatusPd.Font = new Font("Franklin Gothic Demi", 18F);
            txtStatusPd.ForeColor = Color.White;
            txtStatusPd.Location = new Point(162, 4);
            txtStatusPd.Name = "txtStatusPd";
            txtStatusPd.ReadOnly = true;
            txtStatusPd.Size = new Size(177, 28);
            txtStatusPd.TabIndex = 6;
            txtStatusPd.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(45, 45, 60);
            panel3.Controls.Add(txtNomePd);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(18, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 37);
            panel3.TabIndex = 0;
            // 
            // txtNomePd
            // 
            txtNomePd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomePd.BackColor = Color.FromArgb(45, 45, 60);
            txtNomePd.BorderStyle = BorderStyle.None;
            txtNomePd.Font = new Font("Franklin Gothic Demi", 18F);
            txtNomePd.ForeColor = Color.White;
            txtNomePd.Location = new Point(163, 4);
            txtNomePd.Name = "txtNomePd";
            txtNomePd.ReadOnly = true;
            txtNomePd.Size = new Size(174, 28);
            txtNomePd.TabIndex = 2;
            txtNomePd.TextAlign = HorizontalAlignment.Center;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(35, 35, 50);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(159, 37);
            panel8.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Franklin Gothic Demi", 18F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1, 3);
            label6.Name = "label6";
            label6.Size = new Size(81, 30);
            label6.TabIndex = 0;
            label6.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(45, 45, 60);
            label1.Font = new Font("Franklin Gothic Demi", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 7);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(45, 45, 60);
            panel6.Controls.Add(txtUnidadePd);
            panel6.Controls.Add(panel10);
            panel6.Location = new Point(19, 191);
            panel6.Name = "panel6";
            panel6.Size = new Size(340, 37);
            panel6.TabIndex = 1;
            // 
            // txtUnidadePd
            // 
            txtUnidadePd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUnidadePd.BackColor = Color.FromArgb(45, 45, 60);
            txtUnidadePd.BorderStyle = BorderStyle.None;
            txtUnidadePd.Font = new Font("Franklin Gothic Demi", 18F);
            txtUnidadePd.ForeColor = Color.White;
            txtUnidadePd.Location = new Point(163, 5);
            txtUnidadePd.Name = "txtUnidadePd";
            txtUnidadePd.ReadOnly = true;
            txtUnidadePd.Size = new Size(173, 28);
            txtUnidadePd.TabIndex = 4;
            txtUnidadePd.TextAlign = HorizontalAlignment.Center;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(35, 35, 50);
            panel10.Controls.Add(label3);
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(159, 37);
            panel10.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Franklin Gothic Demi", 18F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 4);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 1;
            label3.Text = "Unidade:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(45, 45, 60);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(txtCatPd);
            panel4.Location = new Point(18, 115);
            panel4.Name = "panel4";
            panel4.Size = new Size(340, 37);
            panel4.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(35, 35, 50);
            panel9.Controls.Add(label2);
            panel9.Location = new Point(1, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(157, 37);
            panel9.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Franklin Gothic Demi", 18F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 4);
            label2.Name = "label2";
            label2.Size = new Size(121, 30);
            label2.TabIndex = 1;
            label2.Text = "Categoria:";
            // 
            // txtCatPd
            // 
            txtCatPd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCatPd.BackColor = Color.FromArgb(45, 45, 60);
            txtCatPd.BorderStyle = BorderStyle.None;
            txtCatPd.Font = new Font("Franklin Gothic Demi", 18F);
            txtCatPd.ForeColor = Color.White;
            txtCatPd.Location = new Point(163, 5);
            txtCatPd.Name = "txtCatPd";
            txtCatPd.ReadOnly = true;
            txtCatPd.Size = new Size(174, 28);
            txtCatPd.TabIndex = 3;
            txtCatPd.TextAlign = HorizontalAlignment.Center;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(45, 45, 60);
            panel7.Controls.Add(panel11);
            panel7.Controls.Add(TxtSaldoPd);
            panel7.Location = new Point(19, 264);
            panel7.Name = "panel7";
            panel7.Size = new Size(340, 37);
            panel7.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(35, 35, 50);
            panel11.Controls.Add(label4);
            panel11.Location = new Point(1, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(158, 37);
            panel11.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Franklin Gothic Demi", 18F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 4);
            label4.Name = "label4";
            label4.Size = new Size(139, 30);
            label4.TabIndex = 1;
            label4.Text = "Quantidade:";
            // 
            // TxtSaldoPd
            // 
            TxtSaldoPd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSaldoPd.BackColor = Color.FromArgb(45, 45, 60);
            TxtSaldoPd.BorderStyle = BorderStyle.None;
            TxtSaldoPd.Font = new Font("Franklin Gothic Demi", 18F);
            TxtSaldoPd.ForeColor = Color.White;
            TxtSaldoPd.Location = new Point(162, 5);
            TxtSaldoPd.Name = "TxtSaldoPd";
            TxtSaldoPd.ReadOnly = true;
            TxtSaldoPd.Size = new Size(174, 28);
            TxtSaldoPd.TabIndex = 5;
            TxtSaldoPd.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 40);
            panel1.Controls.Add(panel15);
            panel1.Controls.Add(panel20);
            panel1.Controls.Add(panel16);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 2);
            panel1.Size = new Size(368, 616);
            panel1.TabIndex = 46;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.8159752F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.1840248F));
            tableLayoutPanel1.Controls.Add(panel21, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(989, 622);
            tableLayoutPanel1.TabIndex = 52;
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(30, 30, 40);
            panel21.Controls.Add(dtgProdutos);
            panel21.Controls.Add(panel19);
            panel21.Dock = DockStyle.Fill;
            panel21.Location = new Point(377, 3);
            panel21.Name = "panel21";
            panel21.Size = new Size(609, 305);
            panel21.TabIndex = 53;
            // 
            // panel22
            // 
            panel22.Controls.Add(tableLayoutPanel1);
            panel22.Dock = DockStyle.Fill;
            panel22.Location = new Point(0, 0);
            panel22.Name = "panel22";
            panel22.Size = new Size(989, 622);
            panel22.TabIndex = 53;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel14, 1, 0);
            tableLayoutPanel2.Controls.Add(panel13, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(609, 305);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // frmControleEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(989, 622);
            Controls.Add(panel22);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmControleEstoque";
            Text = "frmControleEstoque";
            Load += frmControleEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            panel2.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel22.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgProdutos;
        private Panel panel2;
        private Panel panel13;
        private Label label11;
        private Panel panel14;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label7;
        private Panel panel15;
        private Label label12;
        private Button btnPesquisar;
        private Button button1;
        private Panel panel16;
        private Label label13;
        private TextBox mkQuantidadeEntrada;
        private Label label15;
        private RichTextBox txtDescEntrada;
        private Label label14;
        private ComboBox cbTipoEntrada;
        private Button btnEnviarEntrada;
        private Panel panel17;
        private Label label16;
        private Label lbSaldoAposEntrada;
        private Button btnEnviarSaida;
        private Label label18;
        private RichTextBox txtDescSaida;
        private Panel panel18;
        private Label label19;
        private Label lbSaldoAposSaida;
        private Label label21;
        private ComboBox cbTipoSaida;
        private Label label22;
        private TextBox mkQuantidadeSaida;
        private Panel panel19;
        private Panel panel20;
        private Panel panel3;
        private TextBox txtNomePd;
        private Panel panel8;
        private Label label6;
        private Label label1;
        private Panel panel4;
        private TextBox txtCatPd;
        private Panel panel6;
        private TextBox txtUnidadePd;
        private Panel panel10;
        private Label label3;
        private Panel panel5;
        private Panel panel12;
        private Label label5;
        private TextBox txtStatusPd;
        private Panel panel7;
        private TextBox TxtSaldoPd;
        private Panel panel9;
        private Label label2;
        private Panel panel11;
        private Label label4;
        private Panel panel1;
        private Label astDescSaida;
        private Label astTpSaida;
        private Label astQtdSaida;
        private Label astDescEntrada;
        private Label astTpEntrada;
        private Label astQtdEntrada;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel21;
        private Panel panel22;
        private TableLayoutPanel tableLayoutPanel2;
    }
}