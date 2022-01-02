using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 3, 44, 38, 5, 47, 15 };
            selectionSort(arr);
            Console.WriteLine(string.Join(' ', arr));
        }

        static int[] selectionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var temp = arr[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (temp < arr[j])
                    {
                        arr[j + 1] = arr[j];
                    }
                    else
                    {
                        arr[j + 1] = temp;
                        break;
                    }
                }
            }
            return arr;
        }
    }
}
