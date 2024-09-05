using System;

class Menu
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            // Mostrar un menú de opciones
            Console.WriteLine("Menú de Opciones:");
            Console.WriteLine("1. Opción 1 - Saludar");
            Console.WriteLine("2. Opción 2 - Mostrar Fecha Actual");
            Console.WriteLine("3. Opción 3 - Salir");
            Console.WriteLine("Por favor, selecciona una opción (1-3): ");

            // Validar la entrada del usuario
            //            "2"  true 2       "hola"  false 0
            //            "4"  true 4

            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entre 1 y 3");
                Console.Write("Selecciona una opción válida: ");
            }
            // Ejecutar la opción seleccionada
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Hola, ¿cómo estás?");
                    break;
                case 2:
                    Console.WriteLine("La fecha actual es: " + DateTime.Now.ToString("dd/MM/yyyy"));
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
            }

            // Pausa antes de repetir el Menú
            if(opcion != 3)
            {
                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

        } while (opcion != 3);

        Console.WriteLine("Programa finalizado.");
    }
}
