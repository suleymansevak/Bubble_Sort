using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Lütfen sayı giriniz : ");
                var a = Convert.ToInt32(Console.ReadLine());
                arr[i] = a;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");

            }
            BubbleSort(arr);
            Console.Write("Buuble   :   ");
            foreach (var item in arr)
            {

                Console.Write(item+"  ");
            }
            Console.WriteLine();
            Array.Sort(arr);
            Console.Write("Array   :    ");
            foreach (var item in arr)
            {
                Console.Write(item + "  ");

            }


            Console.ReadLine();
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }
        }

    }
}
