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
            int valorDado1 = 0;
            int valorDado2 = 0;
            Random rand = new Random();
            int contador = 0;

            while(valorDado1 != 6 || valorDado2 != 6)
            {
                valorDado1 = rand.Next(1,7);
                valorDado2 = rand.Next(1,7);
                Console.WriteLine("Dado 1 - Dado 2");
                Console.WriteLine("  " + valorDado1 + "        " + valorDado2);
                contador++;
            }
            Console.WriteLine("Número de tiradas: " + contador);
        }
    }
}
