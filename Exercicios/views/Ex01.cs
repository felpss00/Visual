using System;
namespace primeiroApp.views
{
    public class Ex01
    {
        public static void Renderizar()
        {
            int altura, largura, area;
            Console.WriteLine("### Calcular area do retangulo ###");
            Console.WriteLine("Digite a altura do retangulo em CM:");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a largura do retangulo em CM:");
            largura = Convert.ToInt32(Console.ReadLine());
            area = altura * largura;
            Console.WriteLine($"O retangulo de altura: { altura } CM e largura: { largura } CM, tem a area de { area } CM²");
        }
    }
}