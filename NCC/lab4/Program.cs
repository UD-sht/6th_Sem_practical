//Program to demonstrate the four type of properties based on get and set accessors.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //For Read only
            employee1 obj1 = new employee1();
            Console.WriteLine(obj1.Name);

            //For Write only
            employee2 obj2 = new employee2();
            obj2.Name = "Tanjiro Kamada";
            Console.WriteLine(obj2.name);

            //For Read and Write 
            employee3 obj3 = new employee3();
            Console.WriteLine(obj3.Name);
            obj3.Name = "Saitama";
            Console.WriteLine(obj3.name);

            //For Automatic
            employee4 obj4 = new employee4();
            obj4.id = 25;
            Console.WriteLine("ID : {0}",obj4.id);
        }
    }
}