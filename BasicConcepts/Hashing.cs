// using System;

// namespace BasicConcepts;

// public class Hashing
// {
//   //Hashing is used to pre storing data & fetching, so that it can be used later.
//   //If we use 2 fors, one to pick the input index and other to loop around the array then it will take N^2 time complexity.
//   //And if the input size is 10^5 and array size is 10^5, then total operations will be 10^10.
//   //10^8 operations takes 1 sec. so 10^10 operations will take 100 seconds.
//   //which is why we use hashing.

//   public static void HashingNumbersUsingArray(){
//     Console.WriteLine("Enter ArraySize:");
//     int Arrsize = Convert.ToInt32(Console.ReadLine());
//     int[] arr=new int[Arrsize];
//     Console.WriteLine("Enter Array:");
//     for(int i=0;i<Arrsize;i++){
//         arr[i]=Convert.ToInt32(Console.ReadLine());
//     }
//     //Pre Compute/Pre store
//     int[] hash = new int[13];
//     for(int i=0;i<Arrsize;i++)
//     {
//         hash[arr[i]]+=1;
//     }


//     Console.WriteLine("Enter InputArraySize:");
//     int inpsize = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter Input Array:");
//     while(inpsize!=0)
//     {
//         int num =Convert.ToInt32(Console.ReadLine());
//         inpsize--;
//         //fetch
//         Console.WriteLine($"Count: {hash[num]}");
//     }
//   }
//   public static void HashingCharactersUsingArray()//only for smaller case letters...
//   {
//     Console.WriteLine("Enter string: ");
//     char[] arr = Console.ReadLine().ToCharArray(); 
//     //Pre Compute/Pre store
//     int[] hash = new int[26];
//     for(int i=0;i<arr.Length;i++)
//     {
//         hash[arr[i]-'a']+=1;//we did -a as to take the proper value from 0 due to ASCII standards.
//     }


//     Console.WriteLine("Enter InputArraySize:");
//     int inpsize = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter Input Array:");
//     while(inpsize!=0)
//     {
//         char ch =Convert.ToChar(Console.ReadLine());
//         inpsize--;
//         //fetch
//         Console.WriteLine($"Count: {hash[ch-'a']}");
//     }
//   }
// public static void HashingAllCharactersUsingArray()
//   {
//     Console.WriteLine("Enter string: ");
//     char[] arr = Console.ReadLine().ToCharArray(); 
//     //Pre Compute/Pre store
//     int[] hash = new int[256];
//     for(int i=0;i<arr.Length;i++)
//     {
//         hash[arr[i]]+=1;//Since there are 256 ASCII values 0-255, we declared the hash size as 256.
//     }


//     Console.WriteLine("Enter InputArraySize:");
//     int inpsize = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter Input Array:");
//     while(inpsize!=0)
//     {
//         char ch =Convert.ToChar(Console.ReadLine());
//         inpsize--;
//         //fetch
//         Console.WriteLine($"Count: {hash[ch]}");
//     }
//   }
//     public static void HashingNumbersUsingDictionaries(){  //In C# we use dictionaries to implement HashMap
//     Console.WriteLine("Enter ArraySize:");
//     int Arrsize = Convert.ToInt32(Console.ReadLine());
//     int[] arr=new int[Arrsize];
//     Console.WriteLine("Enter Array:");
//     for(int i=0;i<Arrsize;i++)
//     {
//         arr[i]=Convert.ToInt32(Console.ReadLine());
//     }
//     //Pre Compute/Pre store
//     Dictionary<int,int> HashMap = new Dictionary<int,int>();
//     for(int i=0;i<Arrsize;i++)
//     {
//       if(HashMap.ContainsKey(arr[i]))
//       {
//         HashMap[arr[i]]++;
//       }
//       else  HashMap.Add(arr[i],1);
//     }


//     Console.WriteLine("Enter InputArraySize:");
//     int inpsize = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter Input Array:");
//     while(inpsize!=0)
//     {
//         int num =Convert.ToInt32(Console.ReadLine());
//         inpsize--;
//         //fetch
//         //Console.WriteLine($"Count: {HashMap[num]}");
//         Console.WriteLine($"Count: {HashMap.GetValueOrDefault(num)}");
//     }
//     foreach(var iterate in HashMap){
//         Console.WriteLine(iterate.ToString());
//         Console.WriteLine(iterate.Key);
//         Console.WriteLine(iterate.Value);
//         Console.WriteLine(iterate.GetHashCode());
//     }
//     }

//     public static void HashingCharactersUsingDictionaries()
//   {
//     Console.WriteLine("Enter string: ");
//     char[] arr = Console.ReadLine().ToCharArray(); 
//     //Pre Compute/Pre store
//     Dictionary<char, int> HashMap = new Dictionary<char, int>();
//     for(int i=0;i<arr.Length;i++)
//     {
//         if(HashMap.ContainsKey(arr[i])){
//           HashMap[arr[i]]++;
//         }
//         else HashMap.Add(arr[i],1);
//     }

//     Console.WriteLine("Enter InputArraySize:");
//     int inpsize = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter Input Array:");
//     while(inpsize!=0)
//     {
//         char ch =Convert.ToChar(Console.ReadLine());
//         inpsize--;
//         //fetch
//         Console.WriteLine($"Count: {HashMap.GetValueOrDefault(ch)}");
//     }
//   }
//   public static void Main(string[] args){

//     //HashingNumbersUsingArray();
//     //HashingCharactersUsingArray();
//     //HashingAllCharactersUsingArray();
//     //HashingNumbersUsingDictionaries();
//     //HashingCharactersUsingDictionaries();
//   }
// }
