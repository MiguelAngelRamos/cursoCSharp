using System;
using System.Globalization; // Importa el espacio de nombres System

class Program { 
    // propiedad
    
    static void Main(string[] args) { // Método principal

        // Varialbes para almacenar las calificaciones
        double examen = 0, proyecto = 0, tareas = 0;
        // Solicitar las calificaciones al usuario (Entradas)

        Console.WriteLine("Por Favor, ingresa tu calificación del examen: ");
        while(!double.TryParse(Console.ReadLine(), out examen) || examen < 10 || examen > 70)
        {
            Console.WriteLine("Por Favor, ingresa una nota valida entre 10 y 70 ");
        }

        Console.WriteLine("Por Favor, ingresa tu calificación del proyecto: ");
        while (!double.TryParse(Console.ReadLine(), out proyecto) || proyecto < 10 || proyecto > 70)
        {
            Console.WriteLine("Por Favor, ingresa una nota valida entre 10 y 70 ");
        }

        Console.WriteLine("Por Favor, ingresa tu calificación de las tareas: ");

        while (!double.TryParse(Console.ReadLine(), out tareas) || tareas < 10 || tareas > 70)
        {
            Console.WriteLine("Por Favor, ingresa una nota valida entre 10 y 70 ");
        }

        // Calcular la nota final (Proceso)
        // Console.WriteLine(examen);
        // Console.WriteLine(proyecto);
        // Console.WriteLine(tareas);

        

        double notaFinal = (examen * 0.50) + (proyecto * 0.30) + (tareas * 0.20);
        // float tiene una precisión de 7 digitos decimales
        // double tiene una precisión de 15 digitos decimales
        // decimal tiene una precisión de 28 digitos decimales
        // Mostrar la nota final (Salida)

        if (notaFinal >= 40)
        {
            Console.WriteLine("Felicidades, has aprobado el curso con una nota de: " + notaFinal);
            // Console.WriteLine($"Felicidades, has aprobado el curso con una nota: {notaFinal:F2}");

        } else
        {
            Console.WriteLine("Lo siento, has reprobado el curso con una nota de: " + notaFinal);
        }
        
       
    }
 
    
}
