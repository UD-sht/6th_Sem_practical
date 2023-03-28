// Proogram to demonstrate constructor.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            sum obj = new sum(25,45);
        }
    }

    public class sum
    {
        private int x,y;
        public sum(int num1,int num2)
        {
            x=num1;
            y=num2;
            Console.WriteLine("Sum of "+x+" and "+y+" : "+(x+y));
        }
    }
}
