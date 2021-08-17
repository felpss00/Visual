using System;
namespace primeiroApp.views
{
    public class Ex03
    {
        public static void Renderizar()
        {
            int a, b;

            Console.WriteLine("### Informar Maior e menor ###");
            Console.WriteLine("Digite o primeiro numero:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Os numeros são iguais.");
            }
            if (a < b)
            {
                Console.WriteLine($"Os numeros digitados foram { a } e { b }\nSendo o maior deles o numero { b } e o menor { a }.");
            }
            else
            {
                Console.WriteLine($"Os numeros digitados foram { a } e { b }\nSendo o maior deles o numero { a } e o menor { b }.");
            }
        }
    }
}