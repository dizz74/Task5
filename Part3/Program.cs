using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)//init
            {
                arr[i] = r.Next(-50, 50);
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            /*for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr[i] < arr[j]){
                    int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            for (int i = 5; i < 9; i++)
            {
                for (int j = i+1; j < 10; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }

            }*/
            for (int i = 0; i < 9; i++)
            {
                if (i == 4) continue;
                int k = 5;
                if (i > 4) k = 10;
                for (int j = i + 1; j < k; j++)
                {
                    if (arr[i] > arr[j] && i < 5)
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                    else
                        if (arr[i] < arr[j] && i > 4)
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }

            }

            Console.Write("Sorted arr: ");
            foreach (int a in arr) Console.Write("{0} ", a);
            Console.ReadKey();
        }
    }
}
