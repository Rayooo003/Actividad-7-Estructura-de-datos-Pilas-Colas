//ACT 7-PILAS COLAS-ESTRUCTURA DE DATOS

using System;

//Importa el espacio de nombres System.Collections.Generic, que contiene definiciones para colecciones genéricas como List y Queue.
using System.Collections.Generic;

//Define un espacio de nombres llamado ColaNumerosAleatorios.
namespace ColaNumerosAleatorios
{
    class Program
    {
        //Define el método principal del programa, que es el punto de entrada del programa.
        static void Main(string[] args)
        {
            // Crear una cola circular para almacenar los números aleatorios con una capacidad inicial de 100.
            Queue<int> colaNumeros = new Queue<int>(100);

            // Generar 100 números aleatorios en el rango [-25, 25]
            //Crea una nueva instancia de la clase Random.
            Random random = new Random();

            //Inicia un bucle que se ejecuta 100 veces.
            for (int i = 0; i < 100; i++)
            {
                //Genera un número aleatorio entre -25 y 25.
                int numeroAleatorio = random.Next(-25, 26);

                //Agrega el número aleatorio a la cola.
                colaNumeros.Enqueue(numeroAleatorio);
            }

            // Mostrar los números aleatorios generados
            //Imprime un mensaje en la consola.
            Console.WriteLine("Números aleatorios generados:");

            //Inicia un bucle que recorre cada número en la cola.
            foreach (int numero in colaNumeros)
            {
                //Imprime el número actual y un espacio en la consola.
                Console.Write(numero + " ");
            }
            //Imprime una nueva línea en la consola.
            Console.WriteLine();

            // Crear una nueva cola con los números negativos
            //Crea una nueva cola para almacenar los números negativos.
            Queue<int> colaNegativos = new Queue<int>();

            //Inicia un bucle que recorre cada número en la cola original.
            foreach (int numero in colaNumeros)
            {
                //Comprueba si el número actual es negativo.
                if (numero < 0)
                {
                    //Si el número es negativo, lo agrega a la cola de números negativos.
                    colaNegativos.Enqueue(numero);
                }
            }

            // Mostrar los números negativos
            //Imprime en consola el mensje "Números negativos en la cola original:"
            Console.WriteLine("Números negativos en la cola original:");

            //Inicia un bucle que recorre cada número en la cola de números negativos.
            foreach (int numero in colaNegativos)
            {
                //Imprime el número actual y un espacio en la consola.
                Console.Write(numero + " ");
            }
            //Imprime una nueva línea en la consola.
            Console.WriteLine();
        }
    }
}
