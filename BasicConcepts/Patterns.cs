// using System.ComponentModel;
// using System.ComponentModel.DataAnnotations;
// using System.Data;
// using BasicConcepts;

// public class Patterns{
    
//     public static void Main(string[] args)
//     {
//       int num = Convert.ToInt32(Console.ReadLine());
//       Pattern1(num);
//       Pattern2(num);
//       Pattern3(num);
//       Pattern4(num);
//       Pattern5(num);
//       Pattern6(num);
//       Pattern7(num);
//       Pattern8(num);
//       pattern9(num);
//       pattern10(num);
//       pattern11(num);
//       pattern12(num);
//       pattern13(num);
//       pattern14(num);
//       pattern15(num);
//       pattern16(num);
//       pattern17(num);
//       pattern18(num);
//       pattern19(num);
//       pattern20(num);
//       pattern21(num);
//       pattern22(num);
//     }

//     public static void Pattern1(int num){
//         for(int i =0; i<num; i++)
//         {
//             for(int j=0; j<num; j++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine("\n");
//         }

//     }
//     public static void Pattern2(int num){
//         for(int i = 0; i<num; i ++)
//         {
//             for(int j = 0; j<=i; j++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine("\n");
//         }
//     }
    
//     public static void Pattern3(int num){
//         for(int i =1; i<=num; i++){
//             for(int j=1; j<=i; j++)
//             {
//                 Console.Write(j);
//             }
//             Console.WriteLine("\n");
//         }
//     }

//     public static void Pattern4(int num){
//         for(int i=1; i<=num; i++)
//         {
//             for(int j = 1; j<=i; j++){
//                 Console.Write(i);
//             }
//         Console.WriteLine("\n");
//         }
//     }
//     public static void Pattern5(int num){
//         for(int i =0; i<num; i++){
//             for(int j=num; j>i; j--){
//                 Console.Write("*");
//             }
//         Console.WriteLine("\n");  
//         }
//     }
//     public static void Pattern6(int num){
//         int innernum = num;
//         for(int i =1; i<=num; i++){
//             for(int j=1; j<=num-i+1; j++)
//             {
//                 Console.Write(j);
//             }
//         Console.WriteLine("\n");  
//         //innernum--;
//         }
//     }

//     public static void Pattern7(int num){
//         int star=1;
//         int space=0;
//         // for(int i =1;i<num;i++)
//         // {
//         //     star=star+2;
//         // }
//         // for(int j = 0; j<num; j++)
//         // {
//         //   for(int k=0; k<star; k++)
//         //   {
//         //     Console.Write("*");
//         //   }
//         //   if(star!=1)
//         //   {
//         //   Console.WriteLine("\n");
//         //   space++;
//         //   for(int h=0; h<space; h++)
//         //   {
//         //     Console.Write(" ");
//         //   }
//         //   star=star-2;
//         //   }
//         // }
//             for(int i=0; i<num;i++){
//             for(int j =0;j<i;j++){
//                 Console.Write(" ");
//             }
//             for(int j =0;j<2*num-(2*i+1);j++)
//             {
//                 Console.Write("*");
//             }
//             for(int j =0;j<i;j++){
//                 Console.Write(" ");
//             }
//             Console.WriteLine("\n");
//         }
//     }


//         public static void Pattern8(int num){
//         int star=1;
//         int newspace=num-1;
//         Console.WriteLine("\n");
//         // for(int j = 0; j<num; j++)
//         // {
//         //   for(int h=0; h<newspace; h++)
//         //   {
//         //     Console.Write(" ");
//         //   }
//         //   for(int k=0; k<star; k++)
//         //   {
//         //     Console.Write("*");
//         //   }
//         //   Console.WriteLine("\n");
//         //   newspace--;
//         //   star=star+2;  
//         // }

//         for(int i=0; i<num;i++){
//             for(int j =0;j<num-i-1;j++){
//                 Console.Write(" ");
//             }
//             for(int j =0;j<2*i+1;j++)
//             {
//                 Console.Write("*");
//             }
//             for(int j =0;j<num-i-1;j++){
//                 Console.Write(" ");
//             }
//             Console.WriteLine("\n");
//         }
//     }

//     public static void pattern9(int num){
//         Pattern8(num);
//         Pattern7(num);
//         Console.WriteLine("\n");
//     }

//     public static void pattern10(int num){
//         int star=1;
//         int flag =1;
//         for(int i =1; i<= num + (num-1);i++)
//         {
//           for(int j=1;j<=star;j++)
//           {
//             Console.Write("*");
//           }
//           if(star<num && flag ==1){
//            star++;
//           }
//           else
//           {
//             star--;
//             flag=0;
//           }
//           Console.WriteLine("\n");
//         }
//     }

//     public static void pattern11(int num)
//     {
//         int start=1;
//         for(int i = 0; i<num; i++)
//         {
//             if(i%2==0){
//                 start=1;
//             }
//             else{
//                 start=0;
//             }
//             for(int j = 0; j<=i; j++)
//             {
//                 Console.Write(start);
//                 start=1-start;
                    
//             }
//             Console.WriteLine("\n");
//         }
      
//     }
//     public static void pattern12(int num){
//         int space=2*(num-1);
//         for(int i=1;i<=num;i++)
//         {
//             for(int j=1; j<=i;j++)
//             {
//                 Console.Write(j);
//             }
//             for(int j=1; j<=space;j++)
//             {
//                 Console.Write(" ");
//             }
//             for(int j=i; j>=1;j--)
//             {
//                 Console.Write(j);
//             }
//             Console.WriteLine("\n");
//             space-=2;
//         }
//     }

//     public static void pattern13(int num){
//         int nums =1;
//         for(int i=1;i<=num;i++)
//         {
//             for(int j=1;j<=i;j++)
//             {
//               Console.Write(nums);
//               nums=nums+1;
//             }
//             Console.WriteLine("\n");
//         }
//     }

//     public static void pattern14(int num){
//         for(int i=0;i<num;i++)
//         {
//             for(char c ='A'; c<='A'+i;c++)
//             {
//                 Console.Write(c);
//             }
//             Console.WriteLine("\n");
//         }
//     }

//     public static void pattern15(int num){
//         for(int i=0;i<num;i++){
//             for(char c='A';c<='A'+(num-i-1);c++)
//             {
//               Console.Write(c);
//             }
//             Console.WriteLine("\n");
//         }
//     }

//     public static void pattern16(int num){
//         for(int i=0;i<num;i++)
//         {
//             char ch=Convert.ToChar('A'+i);
//             for(int j =0;j<=i;j++)
//             {
//                Console.Write(ch);
//             } 
//             Console.WriteLine("\n");
//         }
//     }

//     public static void pattern17(int num){
//         for(int i=0;i<num;i++)
//         {
//             char ch='A';
//             int breakpoint=(2*i+1)/2;  
//            for(int j =0;j<num-i-1;j++){
//                 Console.Write(" ");
//             }
//             for(int j =1;j<=2*i+1;j++){
//                 Console.Write(ch);
//                 if(j<=breakpoint) ch++;
//                 else ch--;
//             }
//            for(int j =0;j<num-i-1;j++){
//                 Console.Write(" ");
//             }
//             Console.WriteLine("\n");
//         }
//     }
//     public static void pattern18(int num){
//         for(int i=0;i<num;i++)
//         {
//            for(char ch=Convert.ToChar('E'-i);ch<='E';ch++)     
//            {
//             Console.Write(ch);
//            }
//            Console.WriteLine("\n");
//         }
//     }

//     public static void pattern19(int num){
//         int Inispace=0;
//         for(int i =0;i<num;i++)
//         {
//             for(int j =0;j<num-i;j++)
//             {
//                 Console.Write("*");
//             }
//             for(int j =0;j<Inispace;j++)
//             {
//                 Console.Write(" ");
//             }
//             for(int j =0;j<num-i;j++)
//             {
//                 Console.Write("*");
//             }
//             Inispace+=2;
//             Console.WriteLine("\n");
//         }
//         Inispace=2*num-2;
//         for(int i =1; i<=num; i++)
//         {
//             for(int j=1; j<=i; j++)
//             {
//                 Console.Write("*");
//             }
//             for(int j=0; j<Inispace; j++)
//             {
//                 Console.Write(" ");
//             }
//             for(int j=1; j<=i; j++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine("\n");
//             Inispace-=2;
//         }
//     }
//     public static void pattern20(int num){
//         int spaces=2*num-2;
//         for(int i=1; i<=2*num-1;i++){
//             int stars=i;
//             if (i>num) stars=2*num-i;
//             for(int j=1;j<=stars;j++)
//             {
//                 Console.Write("*");
//             }
//             for(int j=1;j<=spaces; j++)
//             {
//                 Console.Write(" ");
//             }
//             for(int j=1;j<=stars;j++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine("\n"); 
//             if(i<num) spaces -=2;
//             else spaces+=2;
//         }
//     }
//     public static void pattern21(int num){
//         for(int i =0;i<num;i++)
//         {
//             for(int j=0;j<num;j++)
//             {
//                 if(i==0||j==0||i==num-1||j==num-1)
//                 {
//                     Console.Write("*");
//                 }
//                 else{
//                     Console.Write(" ");
//                 }
//             }
//             Console.WriteLine("\n");
//         }
//     }
//     public static void pattern22(int num)
//     {
//     for(int i=0;i<2*num-1;i++)
//     {
//         for(int j=0;j<2*num-1;j++)
//         {
//             int top=i;
//             int left=j;
//             int right=(2*num-2)-j;
//             int bottom=(2*num-2)-i;
//             Console.Write(num-Math.Min(Math.Min(top,left),Math.Min(bottom,right)));
//         }
//         Console.WriteLine("\n");
//     }
//     }
// }