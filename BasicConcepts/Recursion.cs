// using System;
// using System.Diagnostics.CodeAnalysis;
// using System.Security.Cryptography.X509Certificates;

// namespace BasicConcepts;

// public class Recursion
// {

//     public static void Recursion1(int One,int two)
//     {
       
//        Console.WriteLine(One++);
//        if(One==10)
//        {
//         return;
//        }
//        two++;
//        Recursion1(One,two);
//        Console.WriteLine(two++);
//     }

//     public static void PrintNameNTimes(int n)
//     {
//       if(n==0) return;
//       Console.WriteLine("My name is Meet");
//       PrintNameNTimes(n-1);
//     }

//     public static void PrintNumsLinearly(int i, int j)
//     {
//       if(j>i) return;
//       Console.WriteLine(j);
//       PrintNumsLinearly(i,j+1);
//     }

//     public static void PrintNumsDescending(int k)
//     {
//       if(k==0) return;
//       Console.WriteLine(k);
//       PrintNumsDescending(--k);  //remember .. if we did k--, then k will be decremented after function call, loop will end up being infinite recursive. (Alternative: k-1) 
//     }
//     public static void PrintSumofNumbersParameters(int l,int sum){ //easy for printing i.e. while using void return
//        if(l==0)
//        {
//         Console.WriteLine(sum);
//         return;
//        }
//        PrintSumofNumbersParameters(l-1,sum+l);
//     }
//     public static int PrintSumofNumbersFunction(int l){   //uses backtracking. we use function as sometimes we have to return int, string, float, etc.
//       if(l==0){
//         return l;
//       }
//       l=l+PrintSumofNumbersFunction(l-1);
//       return l;
//     }

//     public static int PrintNfactorial(int o){
//       if(o==1) return o;
//       return o*PrintNfactorial(o-1);
//     }
//     public static void ReverseArray(int i,ref int[] arr, int n)
//     {
//       if(i>=n/2) return;
//       (arr[i],arr[n-i-1])=(arr[n-i-1],arr[i]); //easy way to swap using tuples. can use a helper function as well
//       ReverseArray(i+1,ref arr,n-1);
//     }

//     public static bool CheckPalindrome(int i,char[] str){  //Time Complexity: n/2
//       if(i>=str.Length/2) return true;
//       if(str[i]!=str[str.Length-i-1]) return false;
//       return CheckPalindrome(i+1,str);
//     }

//     public static int fibonacci(int n){ //Time Complexity: 2^n
//       if(n<=1) return n;
//       return fibonacci(n-1)+fibonacci(n-2);
//     }
//     public static void SubsequencesUsingRecursion(int i, ref int[] arr,ref List<int> L,int n){
//      if(i==n){
//       for(int p=0;p<L.Count;p++){
//       Console.Write(L[p]);
//       }
//       if(L.Count==0){
//         Console.Write("_");
//       }
//       Console.WriteLine();
//       return;
//      }
//       L.Add(arr[i]); 
//       SubsequencesUsingRecursion(i+1,ref arr,ref L,n); //Take
//       L.Remove(arr[i]);
//       SubsequencesUsingRecursion(i+1,ref arr,ref L,n); //Not Take
//      }
//   //                     0,_
//   //           1,3                 1,_
//   //     2,31       2,3       2,1      2,_
//   // 3,312 3,31 3,32 3,3  3,12  3,1  3,2   3,_

//     public static void SubsequencesSumUsingRecursion(int i, ref int[] arr,ref List<int> L,int n, int sum, int Inis){
//      if(i==n){
//       if(Inis==sum)
//       {
//       for(int p=0;p<L.Count;p++){
//       Console.Write(L[p]);
//       }
//       }
//       Console.WriteLine();
//       return;
//      }
//       L.Add(arr[i]); 
//       Inis+=arr[i];
//       SubsequencesSumUsingRecursion(i+1,ref arr,ref L,n,sum,Inis); //Take
//       L.Remove(arr[i]);
//       Inis-=arr[i];
//       SubsequencesSumUsingRecursion(i+1,ref arr,ref L,n,sum,Inis); //Not Take
//      }

//      public static bool SubsequencesFirstOccurenceUsingRecursion(int i, ref int[] arr,ref List<int> L,int n, int sum, int Inis){
//       if(i==n)
//       {
//         if(sum==Inis) 
//         {
//           for(int p=0;p<L.Count;p++){     
//           Console.Write(L[p]);
//           return true;}
//         }
//         return false;
//       }
//         L.Add(arr[i]);
//         Inis+=arr[i];
//         if (SubsequencesFirstOccurenceUsingRecursion(i+1,ref arr,ref L,n,sum,Inis) == true) return true;
//         L.Remove(arr[i]);
//         Inis-=arr[i];
//         if (SubsequencesFirstOccurenceUsingRecursion(i+1,ref arr,ref L,n,sum,Inis) == true) return true;
//         return false;
//      }
//      public static int SubsquencesCountUsingRecursion(int i, ref int[] arr,int n, int sum, int Inis, int count){
//      if(i==n)
//      {
//       if(sum==Inis)
//       {
//         return 1;
//         //++count;
//         //return count;
//       }
//       return 0;
//       //return count;
//      }
//      Inis+=arr[i];
//      int left = SubsquencesCountUsingRecursion(i+1,ref arr,n,sum,Inis,count);
//      Inis-=arr[i];
//      int right = SubsquencesCountUsingRecursion(i+1,ref arr,n,sum,Inis,count);
//      return left+right;
//      }
//   public static void Main(string[] args)
//   {
//     int One = 0;
//     int two = 10;
//     Recursion1(One,two);

//     int n=10;
//     PrintNameNTimes(n);
    
//     int i=5;
//     PrintNumsLinearly(i,1);

//     int k=5;
//     PrintNumsDescending(k);

//     int l=5;
//     int m=6;
//     PrintSumofNumbersParameters(l,0);
//     Console.WriteLine(PrintSumofNumbersFunction(m));

//     int o=5;
//     Console.WriteLine(PrintNfactorial(o));

//     Console.WriteLine("Enter Array Size: ");
//     int p = Convert.ToInt32(Console.ReadLine());
//     int[] arr = new int[p];
//     Console.WriteLine("Enter Array inputs: ");
//     for(int q=0; q<p;q++)
//     {
//       arr[q]=Convert.ToInt32(Console.ReadLine());
//     }
//     ReverseArray(0,ref arr,p);
//     for(int w=0;w<p;w++)
//     {
//       Console.Write(arr[w]);
//     }

//     char[] str = Console.ReadLine().ToCharArray();
//     bool check = CheckPalindrome(0,str);
//     for(int z=0;z<str.Length;z++)
//     {
//       Console.Write(str[z]);
//     }
//     if(check==true) Console.WriteLine(" Palindrome");
//     else Console.WriteLine(" Not a Palindrome");

//    Console.WriteLine("Enter the number to find fibonacci of: ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine($"Fibonacci Number of {num} is "+fibonacci(num));  //Time Complexity: 2^n

//    List<int> L = new List<int>();
//    int[] array = new int[]{3,1,2};
//    Console.WriteLine("Elements in our List");
//    for(int e=0;e<array.Length;e++)
//    {
//      Console.Write(array[e]);
//    }
//    Console.WriteLine();
//   SubsequencesUsingRecursion(0,ref array ,ref L, array.Length);
//   SubsequencesSumUsingRecursion(0,ref array ,ref L, array.Length,3,0); //Print all the subsequences whose sum is 3.
//   SubsequencesFirstOccurenceUsingRecursion(0,ref array ,ref L, array.Length,3,0); //Print the subsequence whose first occurence is total 3
//   Console.WriteLine(SubsquencesCountUsingRecursion(0,ref array, array.Length,3,0,0)); //Print the count number of subsequneces whose sum is 3.
  
//   }
// }
