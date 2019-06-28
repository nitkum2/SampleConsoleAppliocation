using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    // Lambda expression is a shothand of anonymous methods, introduced in c# 3.0;
    // In Lambda expression we do not need to write delegate keyword and no need to specify the datatype of inpumt parameters.
    class LambdaExpressions
    {
        public static void Main()
        {
            DelegateSum delegateSum =  (a, b) =>
            {
                return a + b;
            };
            DelegateMult delegateMult =  (a,  b) =>
            {
                return a * b;
            };
            double sum = delegateSum(8.76, 10.86);
            double mult = delegateMult(8.76, 10.86);
            Console.WriteLine("Sum is: " + sum);
            Console.WriteLine("Multiplication is: " + mult);
            Console.ReadLine();
        }
    }
}
