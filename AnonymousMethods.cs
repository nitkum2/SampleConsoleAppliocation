using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    // Anonymous Method is a method without name, it has only body.
    // we do not need to specify the access modifiers, return type for anonymous methods.Return type of anonymous methods is same as of its delegate.
    // we call anonymous methods with delegate keyword.
    // The advantage of using anonymous method is we have to write lesser code, but if we have large code volume for amnonymous method body then we are not suggested to use anonymous method,
    // Use anonymous methos only when we have less code volume.
    class AnonymousMethods
    {
        
        
        public static void Main()
        {
            DelegateSum delegateSum = delegate (double a, double b)
            {
                return a + b;
            };
            DelegateMult delegateMult = delegate (double a, double b)
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
