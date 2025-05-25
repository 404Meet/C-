// using System;
// using System.Diagnostics.Contracts;
// using System.Drawing;
// using System.Security.Authentication.ExtendedProtection;
// using System.Security.Cryptography.X509Certificates;

// namespace BasicConcepts;

// public class Inheritance
// {
//     public static string i1="one";
//     public string i2="two";
//     public int i3 = 3;
//     public string i4="";
//     public string i5,i6,i7;
//     public int Inheritancemethod()
//     {   
//         i4 = "four";
//         return i3;
//     }
//     public string i8{
//      get;set;    
//     }
//     public static string i9{
//      get;set;    
//     }
//     public Inheritance(){  
//        string i0 = "zero";
//        Console.WriteLine(i0);
//     }
//     public Inheritance(string five, string six, string seven){
//         i5=five;
//         i6=six;
//         i7=seven;
//         Console.WriteLine(i5+"\n"+i6+"\n"+i7);
//     }
//     public static void Main(string[] args)
//     {
//       Start s = new Start();
//       s.somemethod();
      
//       Inheritance ii = new Inheritance();
//       Console.WriteLine(i1);
//       Console.WriteLine(ii.i2);
//       Console.WriteLine(ii.Inheritancemethod());
//       Console.WriteLine(ii.i4);
//       Inheritance iii = new Inheritance("FIVE","SIX","SEVEN");
//       iii.i8="EIGHT"; //Encapsulation using get,set;
//       Console.WriteLine(iii.i8);
//       i9="NINE";
//       Console.WriteLine(i9);


//       One oo = new One();  //if the classes were static, then there was no need to create an object.
//       Console.WriteLine(oo.one1);
//       Console.WriteLine(oo.OneMethod());
//       oo.change();

//       Two two = new Two();  //if the classes were static, then there was no need to create an object.
//       Console.WriteLine(two.two1);
//       Console.WriteLine(two.twoMethod());

//       Base bb = new Base();
//       bb.Basemethod();
//       Console.WriteLine(bb.Color);

//       Derived dd = new Derived();
//       dd.Derivedmethod();
//       dd.Basemethod();
//       Console.WriteLine(dd.Color);

//       Console.WriteLine("-------------");
//       //From Derived class object to Base Class members
//       Console.WriteLine(((Base)dd).Color);// typecaste object dd to Base class object to access variable color
//       ((Base)dd).Basemethod(); // typecast object dd to Base class object to access method: BaseMethod
//       dd.Callbasefromderived(); // Another way to call base class method is to use base keyword
//       dd.SameMethod();

//       //From Base Class object to Derived Class members
//       bb.SameMethod();
//       bb = new Derived();  //base class object bb will be converted to derived class object and only methods with overidden keywords can be called
//       bb.SameMethod();
//       Console.WriteLine(bb.Color); //if used overriden in variables such that public overriden string color => "Black" in derived class then it will be displayed
//       Derived dobj = bb as Derived;
//       Console.WriteLine(dobj.Color);
//       dobj.Derivedmethod();
//       Console.WriteLine("-------------");

//       //we can create derived clas object from base class obj 
//       //we cannot create base class object from derive class obj

//       AbsDerive abs = new AbsDerive("Yellow");
//       abs.Absmethod();
//       abs.Imethod();
//       abs.Printcolor();

//       Rank r = Rank.One;
//       Console.WriteLine(r);
      
//       ERank er = new ERank();
//       er.Enumrank(Rank.One);
  
//       string reff= "reference string";
//       valrefexample obj = new valrefexample();
//       obj.Passbyvalue(reff);
//       Console.WriteLine(reff);
//       obj.Passbyreference(ref reff);
//       Console.WriteLine(reff);
      
      
     
//     }

// }
// public class One: Inheritance{
//     public string one1 = "Horse";
//     public string One2= "Cow";
//     public int one3 = 0;
//     public int OneMethod()
//     {
//       return one3;
//     }
//     public One(){
//         string one4="0.1";
//         Console.WriteLine(one4);
//     }
//     public string one5 = i1;
//     public void change(){
//     i9="NINE";
//     }

// }

// public class Two{
//     public string two1= "Tiger";
//     public string two2 ="Dog";
//     public int two3=1;
//     public int twoMethod()
//     {
//         return two3;
//     } 
//      public Two(){
//         string two4="1.1";
//         Console.WriteLine(two4);
//     }
// }

// public class Base{
//     public string Car = "Ferrari";
//     public string Color="Red";

//     public void Basemethod()
//     {
//         Console.WriteLine("Base Method called");
//     }

//     public virtual void SameMethod()
//     {
//         Console.WriteLine("Same Method from Base Class Called");
//     }
// }

// public class Derived: Base{
//      public new string Car= "Lamborghini";
//     public new string Color="Black";

//     public void Derivedmethod()
//     {
//         Console.WriteLine("Derived Method Called");
//     }
//     public void Callbasefromderived()
//     {
//         base.Basemethod();
//     }
//     public override void SameMethod()
//     {
//         Console.WriteLine("Same Method from Derived Class Called");
//     }
// }


// public abstract class AbsBase{  //Abstract class
//     protected string color= "";
//     public abstract void Absmethod(); //Abstract method
//     public AbsBase(string color)// Constructor   
//     {
//         this.color=color;
//     } 
//     public void Printcolor(){
//      Console.WriteLine(color);
//     }
// }

// public class AbsDerive : AbsBase, Iinterface{

//  public AbsDerive(string color) : base(color)  //constructor passing value to parent constructor
//  {}  
// public override void Absmethod(){
//     Console.WriteLine("Abstract method call");
// }

// public void Imethod(){
//     Console.WriteLine("Interface method called");
// }
// }

// public interface Iinterface{
//     protected void Imethod();
// }

// public enum Rank{
//     One = 1,
//     Two = 2,
//     Three = 3,
//     Four = 4,
//     Five = 5,
// }

// public class ERank{ 
//     public void Enumrank(Rank r){
//     switch(r)
//     {
//         case Rank.One:
//         Console.WriteLine("oneee");
//         break;
//         case Rank.Five:
//         Console.WriteLine("Five");
//         break;
//     }
//     Console.WriteLine((int)r);
//     }
// }

// public class valrefexample{
//     public void Passbyvalue(string reff)
//     {
//         Console.WriteLine("Before change: "+ reff);
//         reff="change in value method";
//         Console.WriteLine("After change: "+ reff);
//     }
//     public void Passbyreference(ref string reff)
//     {
//         Console.WriteLine("Before change: "+ reff);
//         reff="change in reference method";
//         Console.WriteLine("After change: "+ reff);
//     }
// }
