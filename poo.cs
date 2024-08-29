using System;

interface IFigura
{ 
    double CalcularArea();
    double CalcularPerimetro();
}
class Circulo : IFigura
{ 
    private double radio;
    public Circulo(double radio)
    {
        this.Radio = radio;
    }
    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }
    public double CalcularArea()
    {
        return Math.PI * Math.Pow(radio, 2);
        // return 3.1416 * radio * radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }

 
}

class Program
{
    static void Main()
    {
        Circulo circulo = new Circulo(-5);
       
        // circulo.Radio = 777;
        Console.WriteLine(circulo.Radio);

    }
}
