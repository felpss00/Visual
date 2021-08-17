namespace primeiroApp.controllers
{
    public class Ex06Controller
    {
        public void BubbleSort(int[] resultado)
        {
            for (int i = 1; i < resultado.Length; i++)
            {
                for (int j = 0; j < resultado.Length - 1; j++)
                {
                    if (resultado[j] > resultado[j + 1])
                    {
                        Troca(resultado, j);
                    }
                }
            }
        }
        public void Troca(int[] g, int primeiro)
        {
            int aux;
            aux = g[primeiro];
            g[primeiro] = g[primeiro + 1];
            g[primeiro + 1] = aux;
        }
    }
}