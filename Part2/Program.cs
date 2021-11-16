using System;

namespace Part2
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Random r = new Random();
            
            for (int i = 0; i < arr.Length; i++)//init
            {
                arr[i] = r.Next(0, 50);
                Console.Write("{0} ", arr[i]);
            }

            int max = arr[0];
            int min = arr[0];
            foreach (int a in arr)
            {
                if (a > max) max = a;
                if (a < min) min = a;
            }

            Console.WriteLine("Max:{0} Min:{1} Sum:{2}", max, min, max + min);
            Console.ReadKey();

            /*
             или в одном цикле
            arr[0] = r.Next(0, 50);
            max = arr[0];
            min = arr[0];

            for (int i = 1; i < arr.Length; i++)//init
            {
                arr[i] = r.Next(0, 50);
                Console.Write("{0} ", arr[i]);
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
             */
        }
    }
}
