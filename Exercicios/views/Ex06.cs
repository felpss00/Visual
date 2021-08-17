using System;
using primeiroApp.controllers;

namespace primeiroApp.views
{
    public class Ex06
    {
        public static void Renderizar()
        {
            int Limite, Final, Inicial;
            int[] resultado;
            Ex06Controller co = new Ex06Controller();
            Console.WriteLine("### Ordenar numeros ### ");
            Random aleatorio = new Random();
            Console.WriteLine("Digite o 1° numero para gerar os numeros aleatorios:");
            Inicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2° numero para gerar os numeros aleatorios:");
            Final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Limite:");
            Limite = Convert.ToInt32(Console.ReadLine());
            resultado = new int[Limite];
            Console.WriteLine("Array antes de ordenar");
            for (int i = 0; i <= Limite - 1; i++)
            {
                resultado[i] = aleatorio.Next(Inicial, Final + 1);
                Console.Write(resultado[i] + " ");
            }
            Console.Write("\n");
            co.BubbleSort(resultado);
            Console.WriteLine("Array depois de ordenar");

            for (int i = 0; i < resultado.Length; i++)
            {

                Console.Write(resultado[i] + " ");
            }
        }
    }
}