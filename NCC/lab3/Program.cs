using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            name obj = new name("Uday","Shrestha");

        }
    }

    public class name
    {
        private string lastname="",firstname="";
        public name(string first, string last)
        {
            lastname=last;
            firstname=first;
            Console.WriteLine("Fields Initialized.\n");
            Console.WriteLine("My name is "+firstname+" "+lastname+".");
        }
        public void dispose()
        {
            lastname = "";
            firstname = "";
            Console.WriteLine("Fields Cleaned.\n");
        }
        ~name()
        {
            dispose();
        }
    }
}
