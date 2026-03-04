using Microsoft.VisualBasic;
using ProjetoIntegradorSENAC.LogInf;
using ProjetoIntegradorSENAC.Logins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSENAC.Main
{
    public partial class mainFrm : Form
    {
        // Captura do mouse para permitir arrastar a janela.
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // Envio de mensagem para o windows para mover a janela.
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes da mensagem.

        // WM_NCLBUTTONDOWN é a mensagem enviada quando o botão esquerdo do mouse é pressionado na borda não cliente da janela.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        // HTCAPTION é o código que indica que a área clicada é a barra de título da janela.
        public const int HTCAPTION = 0x2;

        loginUsuario login;
        public mainFrm()
        {
            InitializeComponent();
            login = new loginUsuario(this);
        }

        public async void Form1_Load(object sender, EventArgs e)
        {
            this.AbrirFormNoPanel(login);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnDimension.Text = "▢";
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                
            }
        }

        public void AbrirFormNoPanel(Form form)
        {
            // Lista para armazenar as janelas abertas.
            foreach (Control control in mainPanel.Controls)
            {
                if (control is Form f)
                {
                    f.Close();
                    f.Dispose();
                }
            }


            mainPanel.Controls.Clear(); // limpa o painel

            form.TopLevel = false; // MUITO IMPORTANTE
            form.FormBorderStyle = FormBorderStyle.None; // remove borda
            form.Dock = DockStyle.Fill; // ocupa todo o painel

            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnDimension_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnDimension.Text = "▢"; // texto quando está normal
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnDimension.Text = "🗗"; // texto quando está maximizado
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.Red;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.Transparent;
        }
    }
}
