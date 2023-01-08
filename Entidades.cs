using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Positivos.Entidades
{
    public class Entrada
    {
        List<int> Numeros = new List<int>();
        public void EntradaNumeros()
        {
            Console.WriteLine("###################################\n");
            Console.WriteLine("######## NÚMEROS POSITIVOS ########\n");
            Console.WriteLine("###################################\n");

            for (int todosNumeros = 0; todosNumeros < 15; todosNumeros++)
            {
       
                Console.Write($"\nDigite o  {todosNumeros + 1}° número: ");
                var numero = Convert.ToInt32(Console.ReadLine());

                Numeros.Add(numero);
            }

            SaidaNumeros();
        }

        public void SaidaNumeros()
        {
            Console.Clear();
            Console.WriteLine("###################################\n");
            Console.WriteLine("######## NÚMEROS POSITIVOS ########\n");
            Console.WriteLine("###################################\n");
            Console.WriteLine("Números positivos: ");

            for (int todosNumeros = 0; todosNumeros < 15; todosNumeros++)
            {
                if (Numeros[todosNumeros] > 0)
                {
                    var positivo = Numeros[todosNumeros];
                    Console.Write(positivo + "  ||  ");
                }
            }
        }
    }
}