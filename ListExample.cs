using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    // List Can grow in size automatically. but Array does not grow in size automatically.
    // List are Stongly Typed.
    class ListExample
    {
        public static void Main()
        {
            Customer customer1 = new Customer();
            customer1.ID = 10000;
            customer1.Name = "Customer1";
            customer1.Salary = 21000;

            Customer customer2 = new Customer();
            customer2.ID = 10001;
            customer2.Name = "Customer2";
            customer2.Salary = 25000;

            Customer customer3 = new Customer();
            customer3.ID = 10002;
            customer3.Name = "Customer3";
            customer3.Salary = 25500;

            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            CustomerSpecial customerspecial1 = new CustomerSpecial(); // we can add inherited class type objects in the List as CustomerSpecial in inherited from Customer Class.
            customerspecial1.Age = 35;
            customers.Add(customerspecial1);


            //============= get All items of a list====
            foreach (Customer c in customers)
            {
                Console.WriteLine(c.ID);
                Console.WriteLine(c.Name);
                Console.WriteLine(c.Salary);
                
            }
            // ===========getting Index of an Item in the List
            Console.WriteLine("Index is:"+customers.IndexOf(customer3));
            Console.WriteLine("Index is:"+customers.IndexOf(customer3, 0,3)); // this overloaded mathod of IndexOf having two more parameters, one is starting index for searching 
                                                                              //and second is how many item it will search. In this statement strating Index is zero 
                                                                              //and it will seach only 3 item sor customer3.
            
            Console.ReadLine();
        }
    }
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class CustomerSpecial:Customer
    {
        public int Age { get; set; }
    }

    
}
