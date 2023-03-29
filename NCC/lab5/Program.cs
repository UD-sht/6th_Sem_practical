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
           IndexerExample ie = new IndexerExample();
           ie[0]="a";
           ie[1]="b";

           for (int i = 0; i < 10; i++)
           {
                Console.WriteLine(ie[i]);
           }  
        }
    }
    
}
