using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SampleConsoleAppliocation
{
    // ArrayList is present in the SSystem.Collection NameSpace.
    // Can grow automatically.
    // ArrayList is weakly typed, means can hold multiple datatypes.

    class ArrayListExample
    {
        public static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");
            list.Add("Six");
            list.Add("Seven");
            list.Add("Eight");
            list.Add("Nine");
            list.Add("Ten");
            
            foreach (string c in list)
            {
                Console.WriteLine(c);
            }
            //==================== how to print arraylist having multiple datatypes=======
            Console.WriteLine("=============================================");
            ArrayList list2 = new ArrayList();
            list2.Add("One");
            list2.Add("Two");
            list2.Add("Three");
            list2.Add("Four");
            list2.Add("Five");
            list2.Add("Six");
            list2.Add("Seven");
            list2.Add("Eight");
            list2.Add("Nine");
            list2.Add("Ten");
            list2.Add(11);
            foreach (var c in list2)
            {
                Console.WriteLine(c);
            }
            //============== Copy to an array============
            string[] strArray = new string[list.Count];
            list.CopyTo(strArray);
            //================ remove a perticular item
            Console.WriteLine("=============================================");
            list2.Remove(11);
            foreach (var c in list2)
            {
                Console.WriteLine(c);
            }
            // remove item at any index=
            Console.WriteLine("=============================================");
            list2.RemoveAt(9);
            foreach (var c in list2)
            {
                Console.WriteLine(c);
            }
            // ======remove given number of items from starting index
            Console.WriteLine("=============================================");
            list2.RemoveRange(0, 2);
            foreach (var c in list2)
            {
                Console.WriteLine(c);
            }
            //=============== reverse a arraylist===========================
            Console.WriteLine("=============================================");
            list.Reverse();
            foreach (var c in list)
            {
                Console.WriteLine(c);
            }
            //========================================= Get Last Index===================
            Console.WriteLine("=============================================");
            Console.WriteLine("Last Index:"+ list.LastIndexOf("Seven")); // returns index of the item(in this case Seven) from the reverse direction.
            Console.WriteLine("Last Index:" + list.LastIndexOf("Eight",4)); // returns index of the item(in this case Seven) from the reverse direction, 
                                                                            //but searches only given number of Items( in this case only 4 item are seached)
             //================ Adding Customer Object==============
            Customer cust1 = new Customer();
            cust1.ID = 10001;
            cust1.Name = "Customer1";
            cust1.Salary = 27000;
            list2.Add(cust1);
            foreach (var c in list2)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
    
}
