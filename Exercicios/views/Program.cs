using System;
using primeiroApp.views;
namespace primeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("\n### Exercicios ###");
                Console.WriteLine("1 - Calcular area do Retangulo");
                Console.WriteLine("2 - Conversões Real para Dolar, Euro e Peso");
                Console.WriteLine("3 - Informar o Maior e Menor numero lido");
                Console.WriteLine("4 - Informar pela idade se Criança,Adolescente,Adulto ou Idoso");
                Console.WriteLine("5 - Imprimir sequencia de Fibonacci a partir do numero digitado");
                Console.WriteLine("6 - Ordenar numeros");
                Console.WriteLine("0 - Sair");

                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Ex01.Renderizar();
                        break;

                    case 2:
                        Ex02.Renderizar();
                        break;

                    case 3:
                        Ex03.Renderizar();

                        break;

                    case 4:
                        Ex04.Renderizar();
                        break;

                    case 5:
                        Ex05.Renderizar();
                        break;

                    case 6:
                        Ex06.Renderizar();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (op != 0);
        }
    }
}
