using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
 
            int c = 0;
            int j = 10;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");

            if (cpf == "00000000000")
            {
                return false;
            }

            int cpfD1 = int.Parse(cpf[9].ToString());
            int cpfD2 = int.Parse(cpf[10].ToString());

            int[] val = new int[11];

            while (c < 9 && j > 1)
            {
                val[c] = int.Parse(cpf[c].ToString()) * j;
                c++;
                j--;
            }

            for (int i = 0; i < 9; i++)

            {
                val[9] += val[i];
            }

            if (val[9] % 11 <= 1)

            {
                val[9] = 0;
            }

            else

            {
                val[9] = 11 - val[9] % 11;
            }

            int d1 = val[9];

            c = 0; j = 11;

            while (c < 11 && j > 1)
            {
                val[c] = int.Parse(cpf[c].ToString()) * j;
                c++;
                j--;
            }

            for (int i = 0; i < 10; i++)
            {
                val[10] += val[i];
            }

            if (val[10] % 11 <= 1)
            {
                val[10] = 0;
            }
            else
            {
                val[10] = 11 - val[10] % 11;
            }

            int d2 = val[10];

            if (d1 == cpfD1 && d2 == cpfD2)

                return true;

            else

                return false;

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

        public static List<string> prencheer(DataTable consulta)
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < consulta.Rows.Count; i++)
            {
                lista.Add(consulta.Rows[i][0].ToString());
            }

            return lista;
        }
    }
}
