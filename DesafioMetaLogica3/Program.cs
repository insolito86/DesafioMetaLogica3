using System;
class Program
{
    static void Main(string[] args)
    {
        int[] dias = new int[] { 7, 1, 5, 3, 6, 4 };
        int diacompra = 0, diavenda = 0, lucro = 0;
        Console.WriteLine(String.Format("Os valores das ações que serão avaliadas são {0}", String.Join(", ", dias)));
        for (int x = 0; x < dias.Length; x++)
        {
            for (int y = x + 1; y < dias.Length; y++)
            {
                if (dias[y] - dias[x] > lucro)
                {
                    diacompra = x;
                    diavenda = y;
                    lucro = dias[diavenda] - dias[diacompra];
                }
            }
        }
        if (lucro > 0) Console.WriteLine(String.Format("Melhor lucro é de {0}, comprando no dia {1} e vendendo no dia {2} ({3} - {4} = {0})", lucro, diacompra + 1, diavenda + 1, dias[diavenda], dias[diacompra]));
        else Console.WriteLine("Nenhuma transação deve ser feita, lucro máximo igual a 0");
        Console.ReadKey();
    }
}