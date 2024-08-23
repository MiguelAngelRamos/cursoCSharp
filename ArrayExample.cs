/*
* Un Array es una colección de elementos del mismo tipo, en C# se declaran especificando el tipo de datos seguidos de corchetes []
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo 1: Declaración e inicialización de un Array
        int[] numeros = { 10, 20, 30, 40, 50 };
        string[] frutas = { "Manzana", "Sandia", "Melón" };

        // numeros.Length -> imprimir 5 "por que son 5 elementos"

        // Ejemplo 2: Acceso a los elementos de un Array
        Console.WriteLine("Primer elemento del array: " + numeros[0]); // Acceder al primer elemento del array
        Console.WriteLine("Segundo elemento del array: " + numeros[1]); // Acceder al segundo elemento del array
        Console.WriteLine("Tercer elemento del array: " + numeros[2]); // Acceder al tercer elemento del array
        Console.WriteLine("Cuarto elemento del array: " + numeros[3]); // Acceder al cuarto elemento del array
        Console.WriteLine("Quinto elemento del array: " + numeros[4]); // Acceder al quinto elemento del array

        // Ejemplo 3: Modificar un elemento del Array
        numeros[1] = 25; // Vamos a cambiar el segundo elemento (indice 1) a 25
        Console.WriteLine("Segundo elemento modificado: " + numeros[1]);

        // Ejemplo 4: Uso del Ciclo for para recorrer un Array
        Console.WriteLine("\nRecorriendo el array con un ciclo for tradicional: ");

        //* i++ abreviado, la forma explicita es: i = i + 1
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Elemento del array en la posición " + i + " = " + numeros[i]);
        }

        // Ejemplo 5: Uso del Ciclo foreach para recorrer un array
        Console.WriteLine("\nRecorriendo el array con un ciclo foreach: ");
        int indice = 0;
        foreach (int numero in numeros)
        {
            Console.WriteLine($"Indice: {indice}, Valor: {numero}");
            indice++;
        }

        //* Solucion
        Console.WriteLine("\nRecorriendo el array de frutas con un ciclo foreach: ");
        foreach (string fruta in frutas)
        {
            Console.WriteLine($"Fruta: {fruta}");
        }

        // Ejemplo 6: Uso del ciclo while para recorrer un array (while)
        Console.WriteLine("\nRecorriendo el array con un ciclo while: ");
        int ind = 0; // indice para usarlo con el while
               
        while (ind < numeros.Length)
        {
            // int[] numeros = { 10, 20, 30, 40, 50 }; // length = 5
            //                   0 , 1,  2,   3,  4
            Console.WriteLine($"Valor en la posición {ind}: {numeros[ind]}");
            ind++;
        }

        // Ejemplo 7: Uso del ciclo do-while para recorrer un array
        Console.WriteLine("\nRecorriendo el array con un ciclo do-while: ");
        int index = 0; // indice para usarlo con el do-while
        do
        {
            Console.WriteLine($"Valor en la posición {index}: {numeros[index]}");
            index++;
        } while (index < numeros.Length);


    }
}
