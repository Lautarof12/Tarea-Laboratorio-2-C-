using System;

namespace Eje3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAleatorio, numAleatorio2, num1, numdado;
            Console.WriteLine("Programa para mostrar un numero al azar, desde el 1 hasta el 100.");
            Random creador = new Random();
            numAleatorio = creador.Next(1, 100);
            Console.WriteLine("El numero generado aleatoriamente es: {0}", numAleatorio);
            Console.WriteLine("Ahora vamos a generar dos numeros aleatorios, el primero desde el 1 hasta el 10 y el segundo desde el 11 hasta el 20");
            numAleatorio = creador.Next(1, 10);
            Console.WriteLine("El primer numero generado aleatoriamente es: {0}", numAleatorio);
            numAleatorio2 = creador.Next(11, 20);
            Console.WriteLine("El primer numero generado aleatoriamente es: {0}", numAleatorio2);
            Console.WriteLine("Ahora vamos a intentar adivinar el numero aleatorio desde el 1 hasta el 7");
            numdado = creador.Next(1, 7);
            Console.WriteLine("Indica el numero que creas que va a salir: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == numdado)
                Console.WriteLine("Has acertado el numero, felicitaciones.");
            else
            {
                if (numdado > num1)
                {
                    Console.WriteLine("Intente con un numero mas grande");
                    
                }
                if (numdado < num1)
                {
                    Console.WriteLine("Intente con un numero mas chico");
                }
                Console.WriteLine("Indica el numero que creas que va a salir: ");
                if (num1 == numdado)
                    Console.WriteLine("Has acertado el numero");
                else
                {
                    if (numdado > num1)
                    {
                        Console.WriteLine("Intente con un numero mas grande");

                    }
                    if (numdado < num1)
                    {
                        Console.WriteLine("Intente con un numero mas chico");
                    }
                    Console.WriteLine("Este es su ultimo intento");
                    Console.WriteLine("Indica el numero que creas que va a salir: ");
                    if (num1 == numdado)
                        Console.WriteLine("Has acertado el numero");
                    else
                        Console.WriteLine("No has podido adivinar el numero");





                }



                Console.ReadKey();
            }
        }
    }
}
