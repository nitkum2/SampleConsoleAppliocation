using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    //1: Extension Methods is introduced in C# 3.0.
    //2: It is a mechanism of adding new methods into an existing class or structure without modifying the source code of original type, and this process we do not require any permission, 
    //3: and the original type does not require any re-compilation.
    //4: Extension methods are defined as static, but once they are bound with any class or stucture, they turn into Non-Static.
    //5: If an extension method is defind as the same name and signature of an existing mathod in the class or structure, extension method will not execute, 
    //   because preference always goes to the original method only.
    //6: The first parameter of an extension method should be the name of the type to which the method has to be bound with and this parameter is not takemn into consideration 
    //    while calling the extension method.
    // 7: an extension method should have one and only one binding parameter, and it should be in first place in parameter list.
    //8 : Inheritance can be used to add methods in an existing class, but there are some restriction in inheritance. if the original class is sealed or original type is structure, 
    //   then we can not perform inheritance.
    class ExtensionMethods
    {
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }
        public void Test2()
        {
            Console.WriteLine("Method 2");
        }
    }
    static class statClass
    {
        public static void Test3(this ExtensionMethods extensionMethods)
        {
            Console.WriteLine("Method 3");
        }
        public static long Factorial(this Int32 x)
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
    public class TestClass
    {
        public static void Main()
        {
            ExtensionMethods extensionMethods = new ExtensionMethods();
            extensionMethods.Test1();extensionMethods.Test2();extensionMethods.Test3();
            int i = 8;
            long fct = i.Factorial();
            Console.WriteLine(fct);
            Console.ReadLine();
        }
    }
}
