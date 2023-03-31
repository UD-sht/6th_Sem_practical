using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace lab5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    
}