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

      // Ejecutar la opción seleccionada
      switch(opcion)
      {
        case 1: 
            Console.WriteLine("Hola, ¿cómo estás?");
            break;
        case 2:
            Console.WriteLine("La fecha actual es: " + DateTime.Now.toString("dd/MM/yyyy"));
            break;
        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;
      }
    } while(opcion != 3);

    Console.WriteLine("Programa finalizado.")
  }
}
