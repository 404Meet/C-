// using System;

// namespace BasicConcepts;

// public class Soring{

//     public static void Selection_sort(ref int[] arr, int n){ //Select the minimum one by one and iterate and swap. 
//         for(int i=0;i<=n-2;i++){
//             int min=i;
//             for(int j=i;j<=n-1;j++){
//                 if(arr[j]<arr[min]) min=j;
//             }
//             int temp=arr[min];
//             arr[min]=arr[i];
//             arr[i]=temp;
//         }
//     }//Time Complexity: O(n^2)

//     public static void Bubble_sort(ref int[] arr, int n){ //Push the max number to the last by adjacent swaps in each iteration. Make bubbles.
//         for(int i=n-1;i>=0;i--){
//             for(int j=0;j<=n-2;j++){
//                 if(arr[j]>arr[j+1]){
//                 int temp=arr[j];
//                 arr[j]=arr[j+1];
//                 arr[j+1]=temp;
//                 }
//             }
//         }
//     }//Time Complexity: O(n^2)

//     public static void Bubble_sort_optimized(ref int[] arr, int n){//If array is sorted, it will break after one iteration.
//         for(int i=n-1;i>=0;i--){
//             int didSwap=0;
//             for(int j=0;j<=n-2;j++){
//                 if(arr[j]>arr[j+1]){
//                 int temp=arr[j];
//                 arr[j]=arr[j+1];
//                 arr[j+1]=temp;
//                 didSwap=1;
//                 }
//             if(didSwap==0) break;
//             }
//         }
//     }//Time Complexity:WorstCase: O(n^2) BestCase:O(n)

//     public static void Insertion_sort(ref int[] arr, int n){//Take all the elements and place it to its correct place.
//         for(int i=0;i<=n-1;i++){
//             int j=i;
//             while(j>0 && arr[j-1]>arr[j]){
//                 int temp = arr[j-1];
//                 arr[j-1]=arr[j];
//                 arr[j]=temp;
//                 j--;
//             }
//         }
//     }//Time Complexity:WorstCase: O(n^2) BestCase:O(n)

//     public static void Merge_sort(ref int[] arr,int n){//First Divide the array in smaller units and then merge.
//         Merge_div(ref arr,0,n-1);
//     }//Time Complexity:nlog2n (n is used for merge and log2n is used to divide). Space Complexity: O(N) uses an extra temp array
//     public static void Merge_div(ref int[] arr, int low, int high){
//         if(low==high) return;
//         int mid = (low+high)/2;
//         Merge_div(ref arr,low,mid);
//         Merge_div(ref arr, mid+1,high);
//         Merge_merge(ref arr, low, mid, high);
//     }
//     public static void Merge_merge(ref int[] arr, int low, int mid, int high){
//         int left=low; //Take two index left & right to compare with each other.
//         int right=mid+1;
//         List<int> temp = new List<int>(); 
//         while(left<=mid && right<=high){
//             if(arr[left]<=arr[right])
//             {
//                 temp.Add(arr[left]);
//                 left++;
//             }
//             else{
//                 temp.Add(arr[right]);
//                 right++;
//             }
//         }
//         while(left<=mid){
//             temp.Add(arr[left]);
//             left++;
//         }
//         while(right<=mid){
//             temp.Add(arr[right]);
//             right++;
//         }
//         for(int i=low; i<=high; i++){
//             arr[i]=temp[i-low];
//         }

//     }

//     public static void Quick_sort(ref int[] arr, int n){//Divide and Conquer. Take a pivot. Place it in it correct place. Resort
//         qsort(ref arr,0,n-1);
//     }//Time Complexity: O(NLogN) Space Complexity: O(1) No extra ds used.
//     public static void qsort(ref int[] arr, int low, int high){
//         if(low<high){
//             int partitionIndex=partition(ref arr,low, high);
//             qsort(ref arr,low,partitionIndex-1);
//             qsort(ref arr,partitionIndex+1,high);
//         }
//     }
//     public static int partition(ref int[] arr, int low, int high){
//         int i=low;
//         int j=high;
//         int pivot = arr[low];
//         while(i<j){
//             while(arr[i]<=pivot && i<= high-1){
//                 i++;
//             }
//             while(arr[j]>pivot && j>= low+1){
//                 j--;
//             }
//             if(i<j){
//                 int temp =arr[i];
//                 arr[i]=arr[j];
//                 arr[j]=temp;
//             } 
//         }
//         int temp2=arr[low];
//         arr[low]=arr[j];
//         arr[j]=temp2;
//         return j;
//     }
//     public static void Main(String[] args){
//         Console.WriteLine("Enter the Array Size: ");
//         int size=Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[size];
//         Console.WriteLine("Enter Array inputs: ");
//         for(int i=0;i<size;i++){
//             arr[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         //Selection_sort(ref arr,size);
//         //Bubble_sort(ref arr, size);
//         //Bubble_sort_optimized(ref arr, size);
//         //Insertion_sort(ref arr,size);
//         //Merge_sort(ref arr, size);
//         //Quick_sort(ref arr, size);
//         for(int i=0;i<arr.Length;i++){
//             Console.Write(arr[i]);
//         }
//     }
// }