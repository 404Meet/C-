// using System;
// class Program
// {
//     static void Main()
//     {
//         int[] firstArray  = { 1, 3, 8, 13, 16 };
//         int[] secondArray = { 7, 9, 10, 11, 18, 19 };

//         double median = FindMedian(firstArray, secondArray);
//         Console.WriteLine("Median = " + median);
//     }

//     static double FindMedian(int[] firstArray, int[] secondArray)
//     {
//         // Always work on the smaller array first
//         int[] smaller = firstArray;
//         int[] larger  = secondArray;

//         if (smaller.Length > larger.Length)
//         {
//             smaller = secondArray;
//             larger  = firstArray;
//         }

//         int sizeSmaller = smaller.Length;
//         int sizeLarger  = larger.Length;
//         int totalSize   = sizeSmaller + sizeLarger;

//         int low  = 0;
//         int high = sizeSmaller;

//         while (low <= high)
//         {
//             int cutSmaller = (low + high) / 2;
//             int cutLarger  = (totalSize + 1) / 2 - cutSmaller;

//             int? leftOfSmaller  = GetLeft(smaller, cutSmaller);
//             int? rightOfSmaller = GetRight(smaller, cutSmaller);
//             int? leftOfLarger   = GetLeft(larger, cutLarger);
//             int? rightOfLarger  = GetRight(larger, cutLarger);

//             bool leftCheck  = LessOrEqual(leftOfSmaller, rightOfLarger);
//             bool rightCheck = LessOrEqual(leftOfLarger, rightOfSmaller);

//             if (leftCheck && rightCheck)
//             {
//                 if (totalSize % 2 == 1)
//                 {
//                     return MaxNullable(leftOfSmaller, leftOfLarger);
//                 }
//                 else
//                 {
//                     int leftMax  = MaxNullable(leftOfSmaller, leftOfLarger);
//                     int rightMin = MinNullable(rightOfSmaller, rightOfLarger);
//                     return (leftMax + rightMin) / 2.0;
//                 }
//             }

//             if (GreaterThan(leftOfSmaller, rightOfLarger))
//             {
//                 high = cutSmaller - 1;
//             }
//             else
//             {
//                 low = cutSmaller + 1;
//             }
//         }

//         throw new InvalidOperationException("Input arrays must be sorted.");
//     }

//     // ---------- Helper methods ----------

//     static int? GetLeft(int[] arr, int cutIndex)
//     {
//         if (cutIndex > 0) return arr[cutIndex - 1];
//         return null;
//     }

//     static int? GetRight(int[] arr, int cutIndex)
//     {
//         if (cutIndex < arr.Length) return arr[cutIndex];
//         return null;
//     }

//     static bool LessOrEqual(int? a, int? b)
//     {
//         if (a == null) return true;
//         if (b == null) return true;
//         return a.Value <= b.Value;
//     }

//     static bool GreaterThan(int? a, int? b)
//     {
//         if (a == null) return false;
//         if (b == null) return false;
//         return a.Value > b.Value;
//     }

//     static int MaxNullable(int? a, int? b)
//     {
//         if (a == null) return b.Value;
//         if (b == null) return a.Value;
//         return Math.Max(a.Value, b.Value);
//     }

//     static int MinNullable(int? a, int? b)
//     {
//         if (a == null) return b.Value;
//         if (b == null) return a.Value;
//         return Math.Min(a.Value, b.Value);
//     }
// }

