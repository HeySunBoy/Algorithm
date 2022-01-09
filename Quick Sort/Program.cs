using System;

namespace Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 38, 6, 21, 25, 20, 26, 51, 13, 9, 12, 26 };
            arr = QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine(string.Join(' ', arr));
        }

        private static int[] QuickSort(int[] arr, int left, int right)
        {

            if (left >= right)
            {
                return arr;
            }

            var pivotIdx = left;

            var storeIdx = pivotIdx + 1;

            for (var i = storeIdx; i <= right; i++)
            {
                if (arr[i] <= arr[pivotIdx])
                {
                    //swap
                    swap(arr, i, storeIdx);
                    //move store index
                    storeIdx++;
                }
            }
            //move pivot
            var newPivotIdx = storeIdx - 1;
            swap(arr, pivotIdx, newPivotIdx);

            QuickSort(arr, left, newPivotIdx - 1);
            QuickSort(arr, newPivotIdx + 1, right);

            return arr;
        }

        private static int[] swap(int[] arr, int left, int right)
        {
            if (left != right)
            {
                var temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            return arr;
        }

    }
}
