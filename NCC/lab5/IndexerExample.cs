using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public class IndexerExample
    {
        private string[] names = new string[2];

        public string this[int i]
        {
            get { return names[i] ;}
            set {  names[i]=value;}
        }
    }
}