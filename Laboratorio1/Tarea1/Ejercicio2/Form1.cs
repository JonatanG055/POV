using System;
using System.Linq;
using System.Windows.Forms;

namespace Ejecicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckAnagram_Click(object sender, EventArgs e)
        {
            errorProvider.Clear(); // Limpiar los errores anteriores

            string input1 = txtInput1.Text.Trim();
            string input2 = txtInput2.Text.Trim();

            // Validar que los TextBox no estén vacíos
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
            {
                lblResult.Text = "Ingresa ambos strings.";
                return;
            }

            // Validar longitud mínima y máxima
            if (input1.Length < 2 || input2.Length < 2)
            {
                lblResult.Text = "Cada string debe tener al menos 2 caracteres.";
                return;
            }
            if (input1.Length > 100 || input2.Length > 100)
            {
                lblResult.Text = "Cada string no debe tener más de 100 caracteres.";
                return;
            }

            // Verificar si son anagramas
            bool areAnagrams = AreAnagrams(input1, input2);

            if (areAnagrams)
            {
                lblResult.Text = "Son anagramas.";
            }
            else
            {
                lblResult.Text = "No son anagramas.";
            }
        }

        private bool AreAnagrams(string str1, string str2)
        {
            return string.Concat(str1.OrderBy(c => c)) == string.Concat(str2.OrderBy(c => c));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtInput1.Text = "";
            txtInput2.Text = "";
            lblResult.Text = "";
            errorProvider.Clear();
        }

        private void txtInput1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "Este campo es requerido.");
            }
            else if (textBox.Text.Length < 2 || textBox.Text.Length > 100)
            {
                errorProvider.SetError(textBox, "El campo debe tener entre 2 y 100 caracteres.");
            }
            else
            {
                errorProvider.Clear();
            }
        }
    }
}
