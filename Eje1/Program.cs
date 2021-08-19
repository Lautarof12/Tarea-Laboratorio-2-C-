using System;

namespace Eje1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAleatorio;
            Console.WriteLine("Programa para mostrar un numero al azar, desde el 1 hasta el 100.");
            Random creador = new Random();
            numAleatorio = creador.Next(1, 100);
            Console.WriteLine("El numero generado aleatoriamente es: {0}", numAleatorio);
            Console.ReadKey();

        }
    }
}
