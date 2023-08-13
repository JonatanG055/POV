using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labUno.ejer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contarpalabrasbtn_Click(object sender, EventArgs e)
        {

            string input = textobox.Text;
            int cantidadPalabras = ContarPalabras(input);

            MessageBox.Show($"Cantidad de palabras: {cantidadPalabras}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int ContarPalabras(string texto)
        {
            string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }
    }
}
