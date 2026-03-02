using System;

namespace Basics;

public class Class1
{
  public void CallHello()
  {
    Console.WriteLine("Hello World, First Program");
    Thread.Sleep(1000);
    Console.WriteLine("Thread wait of 1000ms");
    Thread.Sleep(2000);
    Console.WriteLine("Thread wait of 2000ms");
   }
}
