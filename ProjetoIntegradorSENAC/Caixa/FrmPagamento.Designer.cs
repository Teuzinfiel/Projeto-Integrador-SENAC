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
            panel1 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 40);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(29, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 309);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Medium", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(125, 234);
            button1.Name = "button1";
            button1.Size = new Size(107, 36);
            button1.TabIndex = 1;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(20, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(129, 50);
            panel3.TabIndex = 1;
            panel3.Click += panel3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(72, 17);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 8;
            label5.Text = "Dinheiro";
            label5.Click += panel3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = Properties.Resources.fotoDinheiro;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += panel3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(207, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(129, 50);
            panel2.TabIndex = 0;
            panel2.Click += panel2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 17);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Crédito";
            label4.Click += panel2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.fotoCartao;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += panel2_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(pictureBox3);
            panel5.ForeColor = Color.Transparent;
            panel5.Location = new Point(20, 49);
            panel5.Name = "panel5";
            panel5.Size = new Size(129, 50);
            panel5.TabIndex = 3;
            panel5.Click += panel5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label3.Location = new Point(72, 17);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 7;
            label3.Text = "Débito";
            label3.Click += panel5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.fotoCartao;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += panel5_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(207, 142);
            panel4.Name = "panel4";
            panel4.Size = new Size(129, 50);
            panel4.TabIndex = 2;
            panel4.Click += panel4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium Cond", 11F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(76, 16);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 5;
            label6.Text = "Pix";
            label6.Click += panel4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.logo_pix_1024;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox2.Click += panel4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Demi Cond", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(232, 34);
            label1.TabIndex = 4;
            label1.Text = "Escolha sua forma de";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 18F);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(256, 37);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 5;
            label2.Text = "Pagamento";
            // 
            // FrmPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(413, 441);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPagamento";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Button button1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
    }
}