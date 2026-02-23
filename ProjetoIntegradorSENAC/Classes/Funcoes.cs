using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ProjetoIntegradorSENAC.Classes
{
    internal class Funcoes
    {
        public static bool isCnpj(string cnpj)
        {

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");

            if (cnpj.Length != 14 || cnpj == "00000000000000")
                return false;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public static bool isCpf(string cpf)
        {

            cpf = cpf.Trim()
              .Replace(".", "")
              .Replace("-", "")
              .Replace("/", "")
              .Replace(",", "");

            // Se não tiver 11 dígitos → inválido
            if (cpf.Length != 11)
                return false;

            // Se tiver letras → inválido
            if (!cpf.All(char.IsDigit))
                return false;

            // Evita CPFs repetidos (00000000000, 11111111111 etc)
            string[] invalidos =
            {
        "00000000000", "11111111111", "22222222222", "33333333333",
        "44444444444", "55555555555", "66666666666", "77777777777",
        "88888888888", "99999999999"
    };

            if (invalidos.Contains(cpf))
                return false;

            // -------- CALCULAR CPF -------- //

            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            int dig1 = resto < 2 ? 0 : 11 - resto;

            tempCpf += dig1;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            int dig2 = resto < 2 ? 0 : 11 - resto;

            string digitos = dig1.ToString() + dig2.ToString();

            return cpf.EndsWith(digitos);
        }

        public static void Limpar(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = ""; //	((TextBox)c).Clear();
                else if (c is RichTextBox)
                    ((RichTextBox)c).Text = "";
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).MinDate = new DateTime(1900, 1, 1);
                    ((DateTimePicker)c).MaxDate = new DateTime(2100, 1, 1);
                    ((DateTimePicker)c).Value = DateTime.Now.Date < ((DateTimePicker)c).MinDate ? ((DateTimePicker)c).MinDate : DateTime.Now.Date > ((DateTimePicker)c).MaxDate ? ((DateTimePicker)c).MaxDate : DateTime.Now.Date;
                    if (((DateTimePicker)c).ShowCheckBox)
                        ((DateTimePicker)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0 < ((NumericUpDown)c).Minimum ? ((NumericUpDown)c).Minimum : 0 > ((NumericUpDown)c).Maximum ? ((NumericUpDown)c).Maximum : 0;// ((NumericUpDown)c).Minimum;
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = "";
                }


                //((Label)c).Text = "";

                else if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                }
                else if (c is TrackBar)
                    ((TrackBar)c).Value = ((TrackBar)c).Minimum;
                // else if (c is RichTextBoxExtended)
                // ((RichTextBoxExtended)c).ResetText();
                else if (c.HasChildren)
                {
                    if (c is TabControl)
                        ((TabControl)c).SelectedIndex = 0;

                    Limpar(c);

                }

            }

        }
        public static bool CampoVazio(Control c)
        {
            if (c is TextBox)
                return string.IsNullOrWhiteSpace(((TextBox)c).Text);

            if (c is MaskedTextBox)
                return string.IsNullOrWhiteSpace(((MaskedTextBox)c).Text.Replace(" ", "").Replace("_", ""));

            if (c is RichTextBox)
                return string.IsNullOrWhiteSpace(((RichTextBox)c).Text);

            if (c is ComboBox)
                return ((ComboBox)c).SelectedIndex < 0 || string.IsNullOrWhiteSpace(((ComboBox)c).Text);

            if (c is NumericUpDown)
                return ((NumericUpDown)c).Value == 0;

            if (c is DateTimePicker)
                return !((DateTimePicker)c).Checked; // só funciona se ShowCheckBox = true

            return false;
        }
        public static bool isEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao, RegexOptions.IgnoreCase);
        }

        public static bool isSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
                return false;

            Regex formatoSenha = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            return formatoSenha.IsMatch(senha);
        }

        public static bool isTelefone(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone))
                return false;

            // Pega só os números
            string digits = new string(telefone.Where(char.IsDigit).ToArray());

            // Telefone deve ter 10 (fixo) ou 11 (celular) dígitos
            if (digits.Length != 10 && digits.Length != 11)
                return false;

            // DDD (primeiros 2 dígitos)
            int ddd = int.Parse(digits.Substring(0, 2));

            // DDD no Brasil sempre 11–99
            if (ddd < 11 || ddd > 99)
                return false;

            // Se for celular (11 dígitos), obrigatoriamente começa com 9
            if (digits.Length == 11 && digits[2] != '9')
                return false;

            // Se passou por tudo → telefone válido
            return true;
        }

        public static List<string> prencheer(DataTable consulta)
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < consulta.Rows.Count; i++)
            {
                lista.Add(consulta.Rows[i][0].ToString());
            }

            return lista;
        }

        public static string CriptoSenha(string senha)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private static bool movendo = false;
        private static Point posicaoInicial;

        public static void AtivarMovimentoPanel(Form form, Control area)
        {
            area.MouseDown += MouseDown;
            area.MouseMove += (s, e) => MouseMove(form, e);
            area.MouseUp += MouseUp;

            foreach (Control c in area.Controls)
            {
                c.MouseDown += MouseDown;
                c.MouseMove += (s, e) => MouseMove(form, e);
                c.MouseUp += MouseUp;
            }
        }

        private static void MouseDown(object s, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                movendo = true;
                posicaoInicial = e.Location;
            }
        }

        private static void MouseMove(Form form, MouseEventArgs e)
        {
            if (movendo)
            {
                form.Left += e.X - posicaoInicial.X;
                form.Top += e.Y - posicaoInicial.Y;
            }
        }

        private static void MouseUp(object s, MouseEventArgs e)
        {
            movendo = false;
        }



    }
}
