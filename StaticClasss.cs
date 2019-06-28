using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    // A static Class can have only static data members and static methods.
    // We can not create object of static class.
    // Static methods can call by using class name.
    // If you declare any member as a non-static member, you will get an error. 
    // When you try to create an instance to the static class, it again generates a compile time error.
    // we can not inherit thwe static class.becuase they are implicitly sealed.
    // Static Constructor can initialize statuc datamembers and a non-static cunstructor can intitialize non-stataic datamembers.
    // Static Constructor can‘t contain any access modifiers.
    // Static Constructor must be parameterless.
    // A Static Cunstructor can not access the non-satic data members.

    static class StaticClasss
    {
        public static string CollegeName;
        public static string Address;

        //static constructor  
        static StaticClasss()
        {
            CollegeName = "ABC College of Technology";
            Address = "Hyderabad";
        }
        
    }
    class ImplementStaticClass
    {
        public static void Main()
        {
            ImplementStaticClass obj = new ImplementStaticClass();
            Console.WriteLine(StaticClasss.CollegeName);
            Console.WriteLine(StaticClasss.Address);
            obj.abc();

            Console.ReadLine();
        }
        public void abc()
        {
            Console.WriteLine(StaticClasss.CollegeName); 
        }
    }
    
}
