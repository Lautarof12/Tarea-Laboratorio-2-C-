using System;

namespace Eje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAleatorio, numAleatorio2;
            Console.WriteLine("Programa para mostrar un numero al azar, desde el 1 hasta el 100.");
            Random creador = new Random();
            numAleatorio = creador.Next(1, 100);
            Console.WriteLine("El numero generado aleatoriamente es: {0}", numAleatorio);
            Console.WriteLine("Ahora vamos a generar dos numeros aleatorios, el primero desde el 1 hasta el 10 y el segundo desde el 11 hasta el 20");
            numAleatorio = creador.Next(1, 10);
            Console.WriteLine("El primer numero generado aleatoriamente es: {0}", numAleatorio);
            numAleatorio2 = creador.Next(11, 20);
            Console.WriteLine("El primer numero generado aleatoriamente es: {0}", numAleatorio2);


            Console.ReadKey();

        }
    }
}
