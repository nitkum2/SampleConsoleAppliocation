using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    //Step1:====Define a Delegate===
    public delegate double DelegateSum(double num1, double num2);
    public delegate double DelegateMult(double num1, double num2);
    class DelegateClass
    {
        
        
        public double AddNum(double a,double b)
        {
            return a + b;
        }
        public double MultNum(double a, double b)
        {
            return a * b;
        }
        public static void Main()
        {
            DelegateClass obj = new DelegateClass();
            //Step2: Instantiating the delegate, means create object of delegate and pass the method name which it will reference to. 
            //we can pass any method which is matching the signature of delegate.
            DelegateSum delegateSum = new DelegateSum(obj.AddNum);
            DelegateMult delegateMult = new DelegateMult(obj.MultNum);
            //Step-3: Now call the delegate by passing required parameter values, so that internally the method which is bound with the delegate gets executed.
            double sum=delegateSum(8.76, 10.86);
            double mult=delegateMult(8.76, 10.86);
            // we can call the delegate by using Invoke method===
            sum = delegateSum.Invoke(8.76, 10.86);
            mult = delegateMult.Invoke(8.76, 10.86);
            //=============================================
            Console.WriteLine("Sum is: " + sum);
            Console.WriteLine("Multiplication is: " + mult);
            Console.ReadLine();
        }
    }
}
