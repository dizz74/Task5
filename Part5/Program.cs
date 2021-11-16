using System;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] arr2 = new int[N, N];
            bool sw = false;
            for (int i = 0; i < N; i++)
            {
                Console.Write("[");
                for (int j = 0; j < N; j++)
                {
                    sw = !sw;
                    arr2[i, j] = sw ? 1 : 0;
                    Console.Write(" {0} ", arr2[i, j]);
                }
                Console.WriteLine("]");
            }

            Console.ReadKey();


        }
    }
}
