using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorioUno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VerificarButton_Click(object sender, EventArgs e)
        {
            string input = NumeroTextBox.Text;

            if (!int.TryParse(input, out int numero))
            {
                MessageBox.Show("Error: Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numero % 11 == 0)
            {
                MessageBox.Show($"El número {numero} es divisible entre 11.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"El número {numero} NO es divisible entre 11.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NumeroTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
