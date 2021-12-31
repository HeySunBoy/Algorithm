using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 3, 44, 38, 5, 47, 15 };
            bubbleSort(arr);
            Console.WriteLine(string.Join(' ', arr));
        }

        static int[] bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
