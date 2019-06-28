using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    // Abstract Methods ate methods without body. they contains only declaration.
    // A class under which abstract method is declared is known as abstract class.An abstract class can contain npn-abstract method also.The child class of abstract class is responsible for implementing abstact method.
    // The child class can not consume non-abstract methods without implementing all abstarct methods of parent class. It is mandatory to implement all abstarct methods in the child class.
    // We can not create instance od abstract class. Only static methods can be called without implement abstract methods.
    // Abstract Class provides the blueprint to its child classes.
    abstract class AbstractParent
    {
        
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public abstract void Mult(int x, int y);
        public abstract void Div(int x, int y);
        public static void percent(int x, int y)
        {
            Console.WriteLine("Percent is:" + (x/y)*100);
        }
    }
    class abstractChild:AbstractParent
    {
        public override void Mult(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public static void Main()
        {
            
            abstractChild abstractChild = new abstractChild();
            abstractChild.Add(12, 45);
            abstractChild.Sum(12, 45);
            abstractChild.Mult(12, 45);
            abstractChild.Div(12, 45);
            AbstractParent.percent(25,50);
            Console.ReadLine();
        }

    }
}


