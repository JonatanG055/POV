namespace Ejercico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBaseMayor.Text, out double baseMayor) &&
                double.TryParse(txtBaseMenor.Text, out double baseMenor) &&
                double.TryParse(txtAltura.Text, out double altura) &&
                double.TryParse(txtLado1.Text, out double lado1) &&
                double.TryParse(txtLado2.Text, out double lado2))
            {
                Trapecio trapecio = new Trapecio(baseMayor, baseMenor, altura, lado1, lado2);

                double area = trapecio.CalcularArea();
                double perimetro = trapecio.CalcularPerimetro();

                lblResultadoArea.Text = $"Área: {area:F2}";
                lblResultadoPerimetro.Text = $"Perímetro: {perimetro:F2}";
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBaseMayor.Clear();
            txtBaseMenor.Clear();
            txtAltura.Clear();
            txtLado1.Clear();
            txtLado2.Clear();
            lblResultadoArea.Text = "";
            lblResultadoPerimetro.Text = "";
        }


    }
}