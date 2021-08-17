using System;
namespace primeiroApp.views
{
    public class Ex02
    {
        public static void Renderizar()
        {
            double real, dolar, euro, peso;
            Console.WriteLine("### Conversões monetárias ###");
            Console.WriteLine("Digite o valor em reais:");
            real = Convert.ToDouble(Console.ReadLine());
            dolar = real / 5.17;
            euro = real / 6.14;
            peso = real / 0.05;
            Console.WriteLine($"O valor digitado foi R${ real }\nDolar: ${ dolar.ToString("F2") }\nEuro: ${ euro.ToString("F2") }\nPeso: ${ peso.ToString("F2") }");
        }

    }
}