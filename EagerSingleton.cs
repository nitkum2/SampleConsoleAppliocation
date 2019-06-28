using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    class EagerSingleton
    {
        private static int counter = 0;
        private static readonly EagerSingleton getInstance = new EagerSingleton();// we create an object instaed of initialising with null and make this propery readonly and remove the lock code.CLR is responsible for its thread safty.
        public static EagerSingleton CreateInstance()
        {
            
            return getInstance;
        }
        private EagerSingleton()
        {
            counter++;
            Console.WriteLine("Counter is:" + counter);
        }
        public double AddNum(double a, double b)
        {
            return a + b;
        }
    }
    class EagerSingletonImplement
    {
        public static void Main()
        {
            Parallel.Invoke(() => NewMethod1(), //=== this to demonstrate multi-threaded environment.
                     () => NewMethod2());
            Console.ReadLine();
        }

        private static void NewMethod2()
        {
            Singleton singleton2 = Singleton.CreateInstance();
            double Sum2 = singleton2.AddNum(78.76, 190.86);
            Console.WriteLine("Sum2 is:" + Sum2);
        }

        private static void NewMethod1()
        {
            EagerSingleton singleton = EagerSingleton.CreateInstance();
            double Sum = singleton.AddNum(8.76, 10.86);
            Console.WriteLine("Sum is:" + Sum);
        }
    }
}
