// using System;

// namespace BaicConcepts;

// public class Hashing
// {
//     public static void HashingNumbersUsingArrays()
//     {
//         Console.WriteLine("Enter Array Size: ");
//         int Arrsize= Convert.ToInt32(Console.ReadLine());
//         int[] arr= new int[Arrsize];
//         Console.WriteLine("Enter Array Inputs: ");
//         for(int i = 0; i < Arrsize; i++)
//         {
//             arr[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         //pre compute
//         int[] hash = new int[Arrsize];
//         for(int i = 0; i < Arrsize; i++)
//         {
//             hash[arr[i]]++;
//         }

//         //fetch
//         Console.WriteLine("Enter Input Size: ");
//         int size=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter inputs to see their frequency: ");
//         while (size != 0)
//         {
//             int num=Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine($"Count: {hash[num]}");
//             size--;
//         }
//     }

//      public static void HashingCharactersUsingArrays()
//     {
//         Console.WriteLine("Enter String: ");
//         char[] arr= Console.ReadLine().ToCharArray();

//         //pre compute
//         int[] hash = new int[26];
//         for(int i = 0; i < arr.Length; i++)
//         {
//             hash[arr[i]-'a']++;
//         }

//         //fetch
//         Console.WriteLine("Enter Input Size: ");
//         int size=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter inputs to see their frequency: ");
//         while (size != 0)
//         {
//             char ch= Convert.ToChar(Console.ReadLine());
//             Console.WriteLine($"Count: {hash[ch-'a']}");
//             size--;
//         }
//     }

//      public static void HashingNumbersUsingHashMap()
//     {
//         Console.WriteLine("Enter Array Size: ");
//         int Arrsize= Convert.ToInt32(Console.ReadLine());
//         int[] arr= new int[Arrsize];
//         Console.WriteLine("Enter Array Inputs: ");
//         for(int i = 0; i < Arrsize; i++)
//         {
//             arr[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         //pre compute
//         Dictionary<int,int> HashMap = new Dictionary<int, int>();
//         for(int i = 0; i < Arrsize; i++)
//         {
//             if(HashMap.ContainsKey(arr[i])){
//                 HashMap[arr[i]]++;
//             }
//             else
//             {
//                 HashMap.Add(arr[i],1);
//             }
//         }

//         //fetch
//         Console.WriteLine("Enter Input Size: ");
//         int size=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter inputs to see their frequency: ");
//         while (size != 0)
//         {
//             int num=Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine($"Count: {HashMap.GetValueOrDefault(num)}");
//             size--;
//         }
//         foreach(var iterate in HashMap){
//             Console.WriteLine(iterate.ToString());
//             Console.WriteLine(iterate.Key);
//             Console.WriteLine(iterate.Value);
//             Console.WriteLine(iterate.GetHashCode());
//         }
//     }
//     public static void HashingCharactersUsingHashMap()
//     {
//         Console.WriteLine("Enter String: ");
//         char[] arr= Console.ReadLine().ToCharArray();

//         //pre compute
//         Dictionary<char,int> HashMap = new Dictionary<char, int>();
//         for(int i = 0; i < arr.Length; i++)
//         {
//             if(HashMap.ContainsKey(arr[i])){
//                 HashMap[arr[i]]++;
//             }
//             else
//             {
//                 HashMap.Add(arr[i],1);
//             }
//         }
//         //fetch
//         Console.WriteLine("Enter Input Size: ");
//         int size=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter inputs to see their frequency: ");
//         while (size != 0)
//         {
//             char ch= Convert.ToChar(Console.ReadLine());
//             Console.WriteLine($"Count: {HashMap.GetValueOrDefault(ch)}");
//             size--;
//         }
//     }
//     public static void Main(string[] args)
//     {
//         //HashingNumbersUsingArrays();
//         //HashingCharactersUsingArrays();
//         //HashingNumbersUsingHashMap();
//         //HashingCharactersUsingHashMap();
//     }
// }