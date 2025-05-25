// using System;
// using System.Numerics;
// using System.Linq.Expressions;
// using System.Linq;
// using System.Runtime.InteropServices.Marshalling;
// using System.Text.Json.Serialization.Metadata;

// namespace BasicConcepts;

// public class Start
// {
// public void somemethod()
// {
//     Console.WriteLine("some method called");
// }
// public static void Main(string[] args)
// {
    
// int a = 9;
// int b = 123456789;
// int c = a+b;
// int x,y,z;
// x=y=z=50;
// string txt = "Hi";
// float ab = 18.19F;
// double ad = 232.11D;
// double d = 9D;
// const float fix = 3.14F;
// char ch='m';
// bool tf=true;

// //Implicit Cobersion
// double aa = a;
// Console.WriteLine(aa);
// //Explicit Conversion
// int dd = (int) d;
// Console.WriteLine(dd);

// Console.WriteLine(Convert.ToString(ch));
// Console.WriteLine(Convert.ToString(tf));
// Console.WriteLine(Convert.ToInt32(ab));
// Console.WriteLine(Convert.ToInt32(ad));
// Console.WriteLine(Convert.ToDouble(a));

// try{
// Console.WriteLine("Hello, World!");
// Console.Write("NAME: MEET");
// Console.WriteLine(" I will print on the same line.");
// Console.WriteLine("  "+ ab);
// Console.WriteLine("  "+ ad);
// Console.WriteLine(a+b);
// Console.WriteLine(txt);
// // Console.WriteLine("Enter your name : ");
// // string username = Console.ReadLine();
// // Console.WriteLine("Enter your age : ");
// // int age = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Name: "+username+" Age: "+age);

// //interpolation
// string firstName = "John";
// string lastName = "Doe";
// string name = $"My full name is: {firstName} {lastName}";
// Console.WriteLine(name);

// Console.WriteLine(lastName[0]);
// Console.WriteLine(lastName.IndexOf("e"));
// // Full name
// string Name = "John Doe";
// int charPos = Name.IndexOf("D");
// string lName = Name.Substring(charPos);
// Console.WriteLine(lName);

// int alphabet = 1;
// switch (alphabet)
// {
//     case 1:
//     Console.WriteLine("Alphabet is A");
//     break;
//     case 2:
//     Console.WriteLine("Alphabet is B");
//     break;
//     default:
//     Console.WriteLine("Diff Alphabet");
//     break;
// }

// int i=0;
// while(i<=5)
// {
//     Console.WriteLine(i);
//     i++;
// }


// do{
//   Console.WriteLine(i);
//   i++;
// }
// while(i<=10);

// for(int r = 0; r<=5; r++)
// {
//     Console.WriteLine(r);
// }

// for(int h =6; h<=10; h++)
// {
//     Console.WriteLine(h);
//     for(int p=1;p<=5;p++)
//     {
//         Console.WriteLine("\t"+h+"."+p);
//     }
// }


// string[] cars={"Audi","Porsche","Lamborghini","Merceddes","LandRover","Jaguer"};
// foreach(string s in  cars)
// {
//     Console.WriteLine(s);
// }

// for (int tens =10; tens<=100; tens+=10)
// {
//  Console.WriteLine(tens);
//  if(tens==50)
//  {
//     break;
//  }
// }

// for (int hth =100; hth<=1000; hth+=100)
// {
//  if(hth==500)
//  {
//     continue;
//  }
//  Console.WriteLine(hth);
// }

// foreach(string s in cars)
// {
//     Console.WriteLine(s);
//     Console.WriteLine(cars.Length);
// }
// string[] cardss = new string[5];
// string[] animals;
// animals = new string[]{"Lion","Tiger","Dog","Rabbit"};
// string[] birds = new string[]{};
// birds= birds.Append("Eagle").ToArray();
// foreach(string bird in  birds)
// {
//     Console.WriteLine(bird);
// }
// foreach(string ani in  animals)
// {
//     Console.WriteLine(ani);
// }


// string[] family = new string[]{};
// family = family.Append("Mother").ToArray();
// family = family.Append("Father").ToArray();
// family = family.Append("Son").ToArray();
// family = family.Append("Daughter").ToArray();
// foreach(var fam in family)
// {
//     Console.WriteLine(fam);
// }

// family= family.Concat(["Uncle","Aunt",]).ToArray();
// family= family.Concat(["siblings"]).ToArray();
// family=family.Take(5).ToArray();
// foreach(var fam in family)
// {
//     Console.WriteLine(fam);
// }

// bool f=family.Equals(animals);
// Console.WriteLine(f);

// Array.Sort(animals);
// foreach(string ani in  animals)
// {
//     Console.WriteLine(ani);
// }

// int[] arr = new int[]{};
// arr = arr.Concat(new int[] {1,2,3,4,5,6,7,8,9,10}).ToArray();

// string[] arrstr = new string[10];

// int [,] multiarr = new int[,]{{11,22,33},{44,55,66}};
// int [,] mrr ={{1,2,3},{4,5,6}};
// foreach(int m in mrr)
// {
//     Console.Write(m);
// }
// for(int hh = 0; hh<multiarr.GetLength(0); hh++)
// {
//     for(int jj = 0; jj<multiarr.GetLength(1); jj++)
//     {
//         Console.Write("\n"+multiarr[hh,jj]);
//     }
// }

// Firstmethod();
// int num = Secondmethod(a,b);
// int num2 = Thirdmethod(a,b);
// static void Firstmethod()
// {
//     Console.WriteLine("\nMethod Called");
// }
// static int Secondmethod(int a, int b)
// {
//  return a+b;
// }
// Console.WriteLine(num);
// Console.WriteLine(num2);
// static void Fourthmethod(string msg="Default Message")
// {
//     Console.WriteLine(msg);
// }
// Fourthmethod();
// Fourthmethod("Passed Message");

// static void Fifthmethod(string one, string two)
// {
//     Console.WriteLine(one+two);
// }
// Fifthmethod(two: lastName, one: firstName);//named argument

// Sixthmethod(10,20);
// Sixthmethod(10);

// Middle mid = new Middle();
// Console.WriteLine(mid.color);
// mid.midmethod();

// Middle2 mid2 = new Middle2();
// Console.WriteLine(mid2.color);
// mid2.midmethod();

// Middle3 mid3 = new Middle3();
// Console.WriteLine(((Middle)mid3).color); //use type cast to convert mid3 of Middle3 to Middle
// Console.WriteLine(mid3.color);
// mid3.midmethod();
// }


// catch(Exception e)
// {
// Console.WriteLine(e.Message);
// }
// }
// static int Thirdmethod(int a, int b)
// {
//  return b-a;
// }
// static int Sixthmethod(int x)
// {
//     Console.WriteLine(x);
//     return x;
// }
// static int Sixthmethod(int x, int y)
// {
//     Console.WriteLine(x+y);
//     return x+y;
// }
// }

// public class Middle{
//    public string color="Red"; 
   
//    public void midmethod()
//    {
//     Console.WriteLine("Middle Class Called");
//    }
// }
// public class Middle2 : Middle{
//     public new string color="Blue";
// }
// public class Middle3 : Middle{
//     public new string color="Orange";
// }
