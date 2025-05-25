// using System;
// using System.Numerics;
// namespace BasicConcepts;

// public class Math
// {
//   public static void Main(String[] args)
//   {
//     int num = 11;
//     int num1=50, num2=20;
//     countDigits(num);
//     reverseNumber(num);
//     Palindrome(num);
//     Armstrong(num);
//     printDivisors(num);
//     prime(num);
//     GCDHCF(num1, num2);
//   }

//   public static void countDigits(int n)
//   {
//     int counter =0;
//      while(n > 0)
//      {
//         int lastDigit=n%10;
//         counter++;
//         n=n/10;
//      }
//      Console.WriteLine("Number of Digits are: "+counter);//Time Complexity O(log10(n))
//   }
//   public static void reverseNumber(int n)
//   {
//         int rev=0;
//         while(n>0)
//         {
//         int lastDigit=n%10;
//         n=n/10;
//         rev=(rev * 10) + lastDigit;
//         }
//         Console.WriteLine($"Reverse of Number {n}: "+rev);//Time Complexity O(log10(n))
//   }
//   public static void Palindrome(int n)
//   {
//         int num=n;
//         int rev=0;
//         while(n>0)
//         {
//         int lastDigit=n%10;
//         n=n/10;
//         rev=(rev * 10) + lastDigit;
//         }
//         if(num==rev) Console.WriteLine($"{num} : {rev} A Plaindrome number");
//         else Console.WriteLine($"{num} : {rev} Not a Plaindrome number");//Time Complexity O(log10(n))
//   }
//   public static void Armstrong(int n)
//   {
//         int sum =0;
//         int num=n;
//         while(n>0)
//         {
//         int lastDigit=n%10;
//         n=n/10;
//         sum=sum+(lastDigit*lastDigit*lastDigit);
//         }
//         if(num==sum) Console.WriteLine($"{num} An Armstrong number");
//         else Console.WriteLine($"{num} Not an Armstrong  number");  //Time Complexity O(log10(n))
//   }
// public static void printDivisors(int n)
// {    Console.Write("Divisors of {0} are ",n);
//     for(int i=1; i<=n;i++)
//     {
//         if(n%i==0)
//         {
//             Console.Write(i + ",");
//         }
//     }
//     Console.WriteLine();
//     Console.Write("Divisors of {0} are ",n);//Time Complexity O(n)
//     //for(int i=1;i<=System.Math.Sqrt(n);i++)
//     for(int i=1;i*i<=n;i++)
//     {
//         if(n%i==0)
//         {
//             Console.Write(i + ",");
//             if(n/i!=i)
//             Console.Write(n/i + ",");
//         }
//     }
//     Console.WriteLine();//Time Complexity O(sqrt(n))
// }
// public static void prime(int n){
//     int counter =0;
//     for(int i=1;i*i<=n;i++)
//     {
//         if(n%i==0)
//         {
//             counter++;
//             if(n/i!=i) counter++;
//         }
//     }
//     if(counter==2) Console.Write("{0} is a Prime Number", n);
//     else Console.Write("{0} is not a Prime Number", n);
//     Console.WriteLine(); //Time Complexity O(sqrt(n))
// }
// public static void GCDHCF(int n1, int n2){
//     int gcd=1;
//     for(int i=1;i<=System.Math.Min(n1,n2);i++)
//     {
//         if(n1%i==0 && n2%i==0)
//         {
//             gcd=i;
//         }
//     }
//     Console.Write($"GCD of {n1} and {n2} is {gcd}");
//     Console.WriteLine(); //Time complexity O(min(n1,n2)) 

//     while(n1>0 && n2>0)
//     {
//         if(n1>n2) n1=n1%n2;
//         else n2=n2%n1;
//     }
//     if (n1==0) Console.Write($"GCD of {n1} and {n2} is {n2}");
//     else Console.Write($"GCD of {n1} and {n2} is {n1}");  //Time Complexity O(log (Phi) (min a, b))
// }
// }
  