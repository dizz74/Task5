using System;

namespace Task5
{
    class Program
    {

            static void Main(string[] args)
        {

            Console.WriteLine("Введите 7 элементов");

            int[] arr = new int[7];
            int sum=0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("Ср.ариф:{0}",sum/arr.Length);
            Console.ReadKey();
        }
    }
}
