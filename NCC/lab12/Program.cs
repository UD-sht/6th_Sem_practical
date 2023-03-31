
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
            var square = (int x)=>x*x;
            var result = square(10);
            Console.WriteLine(result);
            
        }
    }

    
}
