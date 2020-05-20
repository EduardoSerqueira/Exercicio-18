using System;

namespace Exercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());
            int y = 0;
            int z = 0;

            for (int a = 0; a < n; a++)
            {
                Console.WriteLine("Digite um valor para o intervalo: ");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    y = y + 1;
                }
                else
                {
                    z = z + 1;
                }
            }

            Console.WriteLine(y + " in");
            Console.WriteLine(z + " out");

            //Exemplo
            //Entrada
            //5
            //14
            //123
            //10
            //-25
            //32
            //Saída
            //2 in
            //4 out
        }
    }
}
