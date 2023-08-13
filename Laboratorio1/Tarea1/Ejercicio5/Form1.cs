namespace Lab_ContadorDePalabras__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string texto = oraciontxt.Text.ToLower();
            string palabraBuscar = palabratxtb.Text.ToLower();

            string[] palabras = texto.Split(' ');

            int i = 0;

            foreach (string palabra in palabras)
            {
                if (palabra == palabraBuscar)
                {
                    i++;
                }

            }

            resultadotxt.Text = $"La palabra: {palabraBuscar}, se repite {i} veces";
        }

       
    }
}
    
