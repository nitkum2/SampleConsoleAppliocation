using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppliocation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10] { 9, 68, 56, 24, 86, 12, 59, 43, 22, 55 };
             //Console.WriteLine(intArray.Rank);
            //--------------------------- Sort Array in Acsending Order
            Array.Sort(intArray);
            foreach(int x in intArray)
            {
                Console.WriteLine(x);
            }
            // ========================array Left Rotation by two position======================================
            Console.WriteLine("-----------------------------------------------------------------------------");
            LeftRotation(intArray, intArray.Length, 2);

            Employee emp = new Employee();
            Console.ReadLine();
        }

        private static void PrintArray(int[] intArray)
        {
            for(int i=0;i<intArray.Length;i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }

        private static void LeftRotation(int[] intArray, int length, int v)
        {
            for(int i=0;i<v;i++)
            {
                 int temp=intArray[0]; // store first item into temp variable.
                for(int j=1;j<length;j++) // this loop shifts items to its previous positions.
                {
                    intArray[j - 1] = intArray[j];
                }
                intArray[length - 1] = temp; // store temp value(first item) at last position of the array.
            }
            PrintArray(intArray);
        }
        



        class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public Employee()
            {
                return;
            }
        }
    }
}
