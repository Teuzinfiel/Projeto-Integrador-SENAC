namespace ProjetoIntegradorSENAC.Main
{
    partial class mainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            brrTarefaPanel = new Panel();
            btnMinimizar = new Button();
            btnDimension = new Button();
            btnSair = new Button();
            mainPanel = new Panel();
            brrTarefaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // brrTarefaPanel
            // 
            brrTarefaPanel.BackColor = Color.FromArgb(25, 25, 30);
            brrTarefaPanel.Controls.Add(btnMinimizar);
            brrTarefaPanel.Controls.Add(btnDimension);
            brrTarefaPanel.Controls.Add(btnSair);
            brrTarefaPanel.Dock = DockStyle.Top;
            brrTarefaPanel.Location = new Point(0, 0);
            brrTarefaPanel.Name = "brrTarefaPanel";
            brrTarefaPanel.Size = new Size(1280, 40);
            brrTarefaPanel.TabIndex = 1;
            brrTarefaPanel.MouseDown += panel1_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(1088, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(64, 40);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Text = "—";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnDimension
            // 
            btnDimension.BackColor = Color.Transparent;
            btnDimension.Dock = DockStyle.Right;
            btnDimension.FlatStyle = FlatStyle.Popup;
            btnDimension.ForeColor = Color.White;
            btnDimension.Location = new Point(1152, 0);
            btnDimension.Name = "btnDimension";
            btnDimension.Size = new Size(64, 40);
            btnDimension.TabIndex = 0;
            btnDimension.Text = "▢";
            btnDimension.UseVisualStyleBackColor = false;
            btnDimension.Click += btnDimension_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.Dock = DockStyle.Right;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(1216, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(64, 40);
            btnSair.TabIndex = 1;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            btnSair.MouseEnter += btnSair_MouseEnter;
            btnSair.MouseLeave += btnSair_MouseLeave;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(35, 35, 45);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1280, 680);
            mainPanel.TabIndex = 2;
            // 
            // mainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(mainPanel);
            Controls.Add(brrTarefaPanel);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "mainFrm";
            Text = "Form1";
            Load += Form1_Load;
            brrTarefaPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel brrTarefaPanel;
        private Panel mainPanel;
        private Button btnDimension;
        private Button btnMinimizar;
        private Button btnSair;
    }
}