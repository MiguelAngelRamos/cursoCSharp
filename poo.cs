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
        this.Radio = radio; // Llamamos al set del metodo Radio
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

class Rectangulo : IFigura
{   
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public Rectangulo(double largoRectangulo, double anchoRectangulo)
    {
        Largo = largoRectangulo;
        Ancho = anchoRectangulo;
    }
    public double CalcularArea()
    {
        return Largo * Ancho;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Largo + Ancho);
    }
}

class Program
{
    static void Main()
    {
        
        Circulo circulo = new Circulo(10); // Primera instancia
        Console.WriteLine($"Circulo - Área: { circulo.CalcularArea()}, Perímetro: {circulo.CalcularPerimetro()}");
        Circulo circulo2 = new Circulo(15); // Segunda instancia
        Console.WriteLine($"Circulo - Área: {circulo2.CalcularArea()}, Perímetro: {circulo2.CalcularPerimetro()}");

        Rectangulo rectangulo = new Rectangulo(4, 7);
        Console.WriteLine($"Rectángulo - Área: {rectangulo.CalcularArea()}, Perímetro: {rectangulo.CalcularPerimetro()}");

        Rectangulo rectangulo2 = new Rectangulo(5, 8);
        Console.WriteLine($"Rectángulo - Área: {rectangulo2.CalcularArea()}, Perímetro: {rectangulo2.CalcularPerimetro()}");

        Rectangulo rectangulo3 = new Rectangulo(6, 9);
        Console.WriteLine($"Rectángulo - Área: {rectangulo3.CalcularArea()}, Perímetro: {rectangulo3.CalcularPerimetro()}");

    }


    /* static void Main()
    {

        Circulo circulo = new Circulo(10); // Primera instancia
        Imprimir(circulo);
        Circulo circulo2 = new Circulo(15); // Segunda instancia
        Imprimir(circulo2);
        Rectangulo rectangulo = new Rectangulo(4, 7);
        Imprimir(rectangulo);
        Rectangulo rectangulo2 = new Rectangulo(5, 8);
        Imprimir(rectangulo2);
        Rectangulo rectangulo3 = new Rectangulo(6, 9);
        Imprimir(rectangulo3);

    }

    static void Imprimir(IFigura figura)
    {
        Console.WriteLine($"Área: {figura.CalcularArea()}, Perímetro: {figura.CalcularPerimetro()}");
    } 
    */
}

