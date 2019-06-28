using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    // ===This singlton class example is not thread safe.Means that it works fine in single threaded environment, but if there are multiple threads accesing this singleton class then 
    //     it may possible that we may ended up having multiple instance of singleton calss, and this against the rule of singleton class.

    sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton getInstance = null;
        public static Singleton CreateInstance()
        {
            if(getInstance==null)
            {
                getInstance= new Singleton();
            }
            return getInstance;
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter is:" + counter);
        }
        public double AddNum(double a, double b)
        {
            return a + b;
        }
        // ==========================================This is nested Derived class of singleton class.
        //public class NestedClass:Singleton
        //{
            
        //}
    }
     class SingletonInplement1
    {
        public static void Main()
        {
            Singleton singleton = Singleton.CreateInstance();
            double Sum = singleton.AddNum(8.76, 10.86);
            Console.WriteLine("Sum is:" + Sum);

            Singleton singleton2 = Singleton.CreateInstance();
            double Sum2 = singleton2.AddNum(78.76, 190.86);
            Console.WriteLine("Sum2 is:" + Sum2);

            //Singleton.NestedClass nestedClass = new Singleton.NestedClass(); // * a new instance of singleton class is created by its derived class. that is why we make singleton class as sealed
            Console.ReadLine();
        }
    }
    
    
}
