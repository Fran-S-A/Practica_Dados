using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Dados
{
    public class Program
    {
        static void Main(string[] args)
        {
            /**
            * Se crean dos variables que almacenan los valores de los dados.
            */
            int valorDado1 = 0;
            int valorDado2 = 0;
            Random rand = new Random(); // Random que se utiliza para generar los valores.
            int tiradas = 0; // Contador para las tiradas

            /**
            * Se utiliza un bucle para realizar tiradas hasta que ambos valores sean 6.
            */
            while (valorDado1 != 6 || valorDado2 != 6)
            {
                valorDado1 = Program.tiradas(rand);
                valorDado2 = Program.tiradas(rand);
                Console.WriteLine("Dado 1 - Dado 2");
                Console.WriteLine("  " + valorDado1 + "        " + valorDado2);
                tiradas++;
            }
            // Al terminar se imprimen las tiradas.
            Console.WriteLine("Número de tiradas: " + tiradas);
        }
        /// <summary>
        /// Metodo que genera el valor entre 1 y 6.
        /// </summary>
        /// <param name="rand">Objeto Random que genera el número.</param>
        /// <returns></returns>
        private static int tiradas(Random rand)
        {
            return rand.Next(1, 7);
        }
    }
}