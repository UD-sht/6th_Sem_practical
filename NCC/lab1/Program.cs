//program to write helloworld

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            hello obj = new hello();
            obj.greet();
        }

    }

    public class hello
    {
        private string str = "Hello World.............";
        public void greet()
        {
            Console.WriteLine(str);
        } 
    }
}
