using System;
namespace primeiroApp.views
{
    public class Ex04
    {
        public static void Renderizar()
        {
            int idade;

            Console.WriteLine("### Informar se Criança,Adolescente,Adulto ou Idoso ### ");
            Console.WriteLine("informe a idade da pessoa:");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade <= 13)
            {
                Console.WriteLine($"A idade digita foi { idade } então a pessoa é uma Criança");
            }
            if (idade > 13 && idade <= 18)
            {
                Console.WriteLine($"A idade digita foi { idade } então a pessoa é um Adolescente");
            }
            if (idade > 18 && idade <= 60)
            {
                Console.WriteLine($"A idade digita foi { idade } então a pessoa é um Adulto");
            }
            if (idade > 60)
            {
                Console.WriteLine($"A idade digita foi { idade } então a pessoa é um Idoso");
            }
        }
    }
}