
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
             Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            dct.Add(4, "vb.net");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
                
            }
            Console.ReadLine();

        }
    }
    
}