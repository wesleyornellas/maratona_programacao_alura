using System;

namespace maratona_programacao_alura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                sum += x;
            }
            Console.WriteLine(sum);
        }
    }
}
