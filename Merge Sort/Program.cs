using System;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 38, 6, 21, 25, 20, 26, 51, 13, 9, 12, 26 };
            arr = MergeSort(arr);
            Console.WriteLine(string.Join(' ', arr));
        }

        private static int[] MergeSort(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }

            int midIndex = (int)Math.Ceiling((double)arr.Length / 2.0);

            int[] leftPartition = new int[midIndex];
            int[] rightPartition = new int[arr.Length - midIndex];

            for (var i = 0; i < arr.Length; i++)
            {
                if (i < leftPartition.Length)
                {
                    leftPartition[i] = arr[i];
                }
                else
                {
                    rightPartition[i - leftPartition.Length] = arr[i];
                }
            }

            var SortedLeftPartition = MergeSort(leftPartition);
            var SortedRightPartition = MergeSort(rightPartition);

            return Merge(SortedLeftPartition, SortedRightPartition);
        }

        private static int[] Merge(int[] LeftPartition, int[] RightPartition)
        {
            var leftHeadIdx = 0;
            var RightHeadIdx = 0;

            int[] MergeSortReult = new int[LeftPartition.Length + RightPartition.Length];

            for (var i = 0; i < MergeSortReult.Length; i++)
            {

                if (leftHeadIdx < LeftPartition.Length && RightHeadIdx < RightPartition.Length)
                {
                    if (LeftPartition[leftHeadIdx] <= RightPartition[RightHeadIdx])
                    {
                        MergeSortReult[i] = LeftPartition[leftHeadIdx];
                        leftHeadIdx++;
                    }
                    else
                    {
                        MergeSortReult[i] = RightPartition[RightHeadIdx];
                        RightHeadIdx++;
                    }
                }
                else if (leftHeadIdx < LeftPartition.Length)
                {
                    MergeSortReult[i] = LeftPartition[leftHeadIdx];
                    leftHeadIdx++;
                }
                else if (RightHeadIdx < RightPartition.Length)
                {
                    MergeSortReult[i] = RightPartition[RightHeadIdx];
                    RightHeadIdx++;
                }
            }
            return MergeSortReult;
        }
    }
}
