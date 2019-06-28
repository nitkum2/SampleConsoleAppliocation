using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    // ===This singlton class example is thread safe.Means we use lock in multithread environment to enter only one thread at a time.
    class ThreadSafeSingleton
    {
        private static int counter = 0;
        public static readonly object obj = new object();
        private static ThreadSafeSingleton getInstance = null;
        public static ThreadSafeSingleton CreateInstance()
        {
            lock(obj)
            {
                if (getInstance == null)
                {
                    getInstance = new ThreadSafeSingleton();
                }
            }
            return getInstance;
        }
        private ThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("Counter is:" + counter);
        }
        public double AddNum(double a, double b)
        {
            return a + b;
        }
    }
    class ThreadSafeSingletonImplement
    {
        public static void Main()
        {
            Parallel.Invoke(()=>NewMethod1(), //=== this to demonstrate multi-threaded environment.
                     ()=>NewMethod2());
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
            Singleton singleton = Singleton.CreateInstance();
            double Sum = singleton.AddNum(8.76, 10.86);
            Console.WriteLine("Sum is:" + Sum);
        }
    }
}
