using System;

interface ILibro
{
    void Prestar();
    void Devolver();
    Boolean ConsultarDisponibilidad();
}
class Libro: ILibro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AñoPublicacion { get; set; }
    public string Genero { get; set; }
    public int NumPaginas { get; set; }
    public bool Disponible { get; set; }

    public Libro(string titulo, string autor, int añoPublicacion, string genero, int numPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        AñoPublicacion = añoPublicacion;
        Genero = genero;
        NumPaginas = numPaginas;
        Disponible = true; // Por defecto el libro esta disponible
    }
    public void Devolver()
    {
        Disponible = true;
        Console.WriteLine($"{Titulo} ha sido devuelto");
    }

    public void Prestar()
    {
        if(Disponible)
        {
            // true
            Disponible = false;
            Console.WriteLine($"{Titulo} ha sido prestado");
        } else
        {
            // false
            Console.WriteLine($"{Titulo} no esta disponible para prestamo");
        }
    }
    public Boolean ConsultarDisponibilidad()
    {
        return Disponible;
    }
}

class Program
{
    static void Main()
    {
        // Libro(string titulo, string autor, int añoPublicacion, string genero, int numPaginas)
        Libro libro1 = new Libro("El principito", "Antoine de Saint-Exupéry", 1943, "Fábula", 96);
        Libro libro2 = new Libro("El señor de los anillos", "J.R.R. Tolkien", 1954, "Fantasía", 1200);

        Console.WriteLine($"Disponibilidad de {libro1.Titulo}: {libro1.ConsultarDisponibilidad()}");
        // Libro1 principito
        libro1.Prestar(); // fue prestado
        libro1.Prestar(); // No esta disponible
        libro1.Devolver(); // fue de vuelto y esta disponible
        libro1.Prestar(); // fue prestado y no esta disponible

        // Libro2 señor de los anillos

        libro2.Prestar();
        libro2.Prestar();
        libro2.Devolver();
        libro2.Prestar();
    }
}
