// using System;
// using System.Collections;
// using System.Globalization;

// namespace BasicConcepts;

// public class ArrayClass
// {
//     public static void largestElement(int[] arr,int n){
//         int largest=arr[0];
//         for(int i=0;i<n;i++){
//             if(largest<arr[i]){
//                 largest=arr[i];
//             }
//         }
//         Console.WriteLine("Largest Element:"+largest);
//     }
//     public static void SecondLargestSmallest(int[] arr, int n){
//         int largest = arr[0];
//         int smallest = arr[0];
//         int secondLargest = -1;
//         int secondSmallest = int.MaxValue;
//         for(int i = 1; i<n; i++){
//             if(arr[i]>largest){
//                 secondLargest=largest;
//                 largest=arr[i];
//             }
//             if(arr[i]<largest && arr[i]>secondLargest){
//                 secondLargest=arr[i];
//             }
//             if(arr[i]<smallest){
//                 secondSmallest=smallest;
//                 smallest=arr[i];
//             }
//             if(arr[i]!=smallest && arr[i]<secondSmallest){
//                 secondSmallest=arr[i];
//             }
//         }
//         Console.WriteLine($"SecondLargest: {secondLargest} SecondSmallest: {secondSmallest}");
//     }
//     public static void checkSorted(int[] arr, int n){
//         int flag=0;
//         for(int i=1;i<n;i++){
//             if(arr[i]>=arr[i-1]){
//                 flag=1;
//             }
//             else flag=0;
//         }
//         if(flag==1) Console.WriteLine("Array is Sorted");
//         else Console.WriteLine("Array is not Sorted");
//     }
//     public static void RemoveDuplicates(int[] arr, int n){
//         int i =0;
//         for(int j =1;j<n;j++){
//             if(arr[i]!=arr[j]){
//                 arr[i+1]=arr[j];
//                 i++;
//             }
//         }
//         Console.WriteLine($"Unique Elements: {i+1}");
//     }

//     public static void LeftRotateArrayByOne(int[] arr, int n){
//         int temp = arr[0];
//         for(int i=1;i<n;i++){
//             arr[i-1]=arr[i];
//         }
//         arr[n-1]=temp;
//         for(int i=0;i<n;i++){
//             Console.Write(arr[i]);
//         }
//         Console.WriteLine();
//     }
//     public static void LeftRotateArrayByNumber(int[] arr, int n, int shift){ //123456
//         shift=shift%n;
//         //Array.Reveree(arr,start,length);
//         Array.Reverse(arr,0,shift); //Reverses the element 0 to shift 321456
//         Array.Reverse(arr,shift,n-shift);//Reverses the element shift to end 321654
//         Array.Reverse(arr,0,n);// Reverses the element 0 to n 456123
//         for(int i=0;i<n;i++){
//             Console.Write(arr[i]);
//         }
//         Console.WriteLine();
//     }
//     public static void MoveZeroToEnd(int[] arr, int n){
//         int j=-1;
//         for(int i=0;i<n;i++){
//             if(arr[i]==0){
//              j=i;
//              break;   
//             }
//         }
//         for(int i=j+1;i<n;i++){
//             if(arr[i]!=0){
//                 int temp=arr[i];
//                 arr[i]=arr[j];
//                 arr[j]=temp;
//                 j++;
//             }
//         }
//         for(int i=0;i<n;i++){
//             Console.Write(arr[i]);
//         }
//         Console.WriteLine();
//     }
//     public static int LinearSearch(int[] arr, int n, int index){
        
//         for(int i=0;i<n;i++){
//             if(arr[i]==index){
//                 return i;
//             }
//         }
//         return -1;
//     }

//     public static void UnionOfTwoSortedArrays(ref int[] arrA, ref int[] arrB, int sizeA, int sizeB){
//         int i=0;
//         int j=0;
        
//         List<int> Union= new List<int>(); 
//         while(i<sizeA && j<sizeB){
//             if(arrA[i]<=arrB[j]){
//                 if(Union.Count()==0||Union.Last()!=arrA[i]){
//                     Union.Add(arrA[i]);
//                 }
//                 i++;
//             }
//             else if(arrB[j]<=arrA[i]){
//                 if(Union.Count()==0||Union.Last()!=arrB[j]){
//                     Union.Add(arrB[j]);
//                 }
//                 j++;
//             }
//         }
//         while(i<sizeA){
//             if(Union.Count()==0||Union.Last()!=arrA[i]){
//                 Union.Add(arrA[i]);
//             }
//             i++;
//         }
//         while(j<sizeB){
//             if(Union.Count()==0||Union.Last()!=arrB[j]){
//                 Union.Add(arrB[j]);
//             }
//             j++;
//         }
//         foreach(var u in Union){
//             Console.Write(u);
//         }
//         Console.WriteLine();
//     }//Time Complexity:O(A+B) Space Complexity:O(A+B)for returning the ans, or else O(1).

//     public static void IntersectionOfTwoSortedArrays(ref int[] arrA, ref int[] arrB, int sizeA, int sizeB){
//         int i=0;
//         int j=0;
//         List<int> Intersection= new List<int>();
//         while(i<sizeA && j<sizeB){
//             if(arrA[i]<arrB[j]){
//                 i++;
//             }
//             else if(arrB[j]<arrA[i]){
//                 j++;
//             }
//             else{
//                 Intersection.Add(arrA[i]);
//                 i++;
//                 j++;
//             }
//         }
//         foreach(var it in Intersection){
//             Console.Write(it);
//         }
//         Console.WriteLine();
//     }//Time Complexity:O(A+B) Space Complexity:O(A+B)for returning the ans, or else O(1).

//     public static void FindOneMissingNumber(ref int[] arr, int n){//For sorted array elements only, no duplicates.
//         int xor1=0;
//         int xor2=0;
//         for(int i=0;i<n-1;i++){
//             xor1=xor1^(i+1);
//             xor2=xor2^arr[i];
//         }
//         xor1=xor1^n;//To add Last Element
//         int result=xor1^xor2;
//         Console.WriteLine("Missing Element: "+result);
//     }

//     public static void FindMaxConsecutiveOne(int[] arr){
//         int max=0;
//         int cnt=0;
//         for(int i=0;i<arr.Length;i++){
//             if(arr[i]==1){
//                 cnt=cnt+1;
//                 max=Math.Max(max,cnt);
//             }
//             else{
//                 cnt=0;
//             }
//         }
//         Console.WriteLine($"Max One's: {max}");
//     }

//     public static void FindNumAppearOnceOtherTwice(int[] num){
//         int xor=0;
//         for(int i=0;i<num.Length;i++){
//             xor=xor^num[i];
//         }
//         Console.WriteLine("Number appearing once: "+xor);
//     }

//     public static void LongestSubarrayWithSumK(List<int> arr, long k) {
//         Dictionary<long, int> preSumMap = new Dictionary<long, int>();
//         long sum = 0;
//         int maxLen = 0;

//         for (int i = 0; i < arr.Count; i++) {
//             sum += arr[i];

//             if (sum == k) {
//                 maxLen = Math.Max(maxLen, i + 1);
//             }

//             long rem = sum - k;
//             if (preSumMap.ContainsKey(rem)) {
//                 int len = i - preSumMap[rem];
//                 maxLen = Math.Max(maxLen, len);
//             }

//             // Store current prefix sum in dictionary if not already present
//             if (!preSumMap.ContainsKey(sum)) {
//                 preSumMap.Add(sum, i); // Using Add() instead of index assignment
//             }
//         }

//         Console.WriteLine("Longest SubArray Length with Positive , Negative elements: "+maxLen);
//     }

//     public static void LongestPositiveSubArrayWithSumk(List<int> arr, long k){
//         int left=0;
//         int right=0;
//         int n=arr.Count();
//         int maxlen=0;
//         int sum=0;
//         while(right<n){
//             if(right<n){
//                 sum+=arr[right];
//             }
//             while(left<=right && sum>k){
//                 sum-=arr[left];
//                 left++;
//             }
//             if(sum==k){
//                 maxlen=Math.Max(maxlen,right-left+1);
//             }
//             right++;
//         }
//         Console.WriteLine("Longest length of a positive Subarray is: "+maxlen);
//     }
//     public static void Main(string[] args){
//         Console.WriteLine("Enter the Array Size: ");
//         int size=Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[size];
//         Console.WriteLine("Enter Array inputs: ");
//         for(int i=0;i<size;i++){
//             arr[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         Console.WriteLine("Enter Shift: ");
//         int shift=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Find Index of : ");
//         int index=Convert.ToInt32(Console.ReadLine());
//         largestElement(arr,size);
//         SecondLargestSmallest(arr, size);
//         checkSorted(arr, size);
//         RemoveDuplicates(arr, size);
//         LeftRotateArrayByOne(arr, size);
//         LeftRotateArrayByNumber(arr, size, shift);//Arrays are taken by reference by default.
//         MoveZeroToEnd(arr, size);
//         Console.WriteLine(LinearSearch(arr, size, index));

//         Console.WriteLine("Enter the Array Size for A: ");
//         int sizeA=Convert.ToInt32(Console.ReadLine());
//         int[] arrA = new int[sizeA];
//         Console.WriteLine("Enter Array inputs: ");
//         for(int i=0;i<sizeA;i++){
//             arrA[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         Console.WriteLine("Enter the Array Size for B: ");
//         int sizeB=Convert.ToInt32(Console.ReadLine());
//         int[] arrB = new int[sizeB];
//         Console.WriteLine("Enter Array inputs: ");
//         for(int i=0;i<sizeB;i++){
//             arrB[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         UnionOfTwoSortedArrays(ref arrA, ref arrB, sizeA, sizeB);
//         IntersectionOfTwoSortedArrays(ref arrA, ref arrB, sizeA, sizeB);

//         Console.WriteLine("Enter N");
//         int n=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine($"Enter {n-1} Array Elements: ");
//         int[] newarr = new int[n-1];
//         for(int i=0;i<n-1;i++){
//             newarr[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         FindOneMissingNumber(ref newarr,n);

//         int[] maxOne = new int[]{1,0,1,1,1,1,0,0,1,1,0,1,1,1,1,1}; //Five Max Consecutive One
//         FindMaxConsecutiveOne(maxOne);

//         int[] num = new int[]{1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10};
//         FindNumAppearOnceOtherTwice(num);

//         List<int> arr2 = new List<int>{1,2,3,1,1,1,1,1,4};//5 //Longest SubArray:1,1,1,1,1
//         List<int> arr1 = new List<int>{1,0,0,0,0,0,0,2,3,1,-1,1,1,1,1,1,4};//5 //Longest SubArray:0,0,0,0,0,0,2,3,1,-1
//         LongestSubarrayWithSumK(arr1,5);
//         LongestPositiveSubArrayWithSumk(arr2,5);
//     }

// }