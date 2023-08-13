public class Trapecio
{
    public double BaseMayor { get; set; }
    public double BaseMenor { get; set; }
    public double Altura { get; set; }
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }

    // Constructor
    public Trapecio(double baseMayor, double baseMenor, double altura, double lado1, double lado2)
    {
        BaseMayor = baseMayor;
        BaseMenor = baseMenor;
        Altura = altura;
        Lado1 = lado1;
        Lado2 = lado2;
    }

    public double CalcularArea()
    {
        return ((BaseMayor + BaseMenor) * Altura) / 2;
    }

    public double CalcularPerimetro()
    {
        return BaseMayor + BaseMenor + Lado1 + Lado2;
    }
}
