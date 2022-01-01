using System;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 3, 44, 38, 5, 47, 15 };
            SelectionSort(arr);
            Console.WriteLine(string.Join(' ', arr));
        }

        static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var minnumindex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minnumindex])
                    {
                        minnumindex = j;
                    }
                }
                if (i != minnumindex)
                {
                    var temp = arr[i];
                    arr[i] = arr[minnumindex];
                    arr[minnumindex] = temp;
                }
            }
            return arr;
        }
    }
}
