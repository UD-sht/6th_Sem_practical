//enum

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1
{
    public class Program
    {
        enum level
        {
            Low,
            Medium=5,
            High
        }
        static void Main(string[] args)
        {
            int value =(int)level.Medium;
            Console.WriteLine(value);
            level myvar = level.Medium;
            Console.WriteLine(myvar);
        }
    }
}
