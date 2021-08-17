using System;
namespace primeiroApp.views
{
    public class Ex05
    {
        public static void Renderizar()
        {
            int num;
            Console.WriteLine("### Imprimir sequencia Fibonacci até o valor lido ### ");
            Console.WriteLine("informe um numero:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine($"O valor lido foi { num }\nSendo assim a sequia de Fibonacci até este numero é 0");
            }
            if (num == 1)
            {
                Console.WriteLine($"O valor lido foi { num }\nSendo assim a sequia de Fibonacci até este numero é 0, 1, 1");
            }
            if (num == 2)
            {
                Console.WriteLine($"O valor lido foi { num }\nSendo assim a sequia de Fibonacci até este numero é 0, 1, 1, 2");
            }
            if (num >= 3 && num <= 4)
            {
                Console.WriteLine($"O valor lido foi { num }\nSendo assim a sequia de Fibonacci até este numero é 0, 1, 1, 2, 3");
            }
            if (num == 5)
            {
                Console.WriteLine($"O valor lido foi { num }\nSendo assim a sequia de Fibonacci até este numero é 0, 1, 1, 2, 3, 5");
            }
            if (num > 5 && num < 8)
            {
                Console.WriteLine($"O valor lido foi { num }\nSendo assim a sequia de Fibonacci até este numero é 0, 1, 1, 2, 3, 5");
            }
            if (num >= 8 && num < 13)
            {
                Console.WriteLine($"O valor lido foi { num }\nSendo assim a sequia de Fibonacci até este numero é 0, 1, 1, 2, 3, 5, 8");
            }
            if (num >= 13)
            {
                Console.WriteLine($"O valor lido foi { num }\nSendo assim a sequia de Fibonacci até este numero é 0, 1, 1, 2, 3, 5, 8, 13");
            }
        }
    }
}