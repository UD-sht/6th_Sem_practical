using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace lab15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Userdetails ud = new Userdetails(1,"Tanjiro","Swordsmit village");
            Console.WriteLine("Before serialization the object contains: ");
            ud.getdetails();
            string fpath = @"/home/uday/Documents/6th_Sem/Practical(6th_sem)/NCC/lab9/file1.txt";
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            //Opens a file and serializes the object into it in binary format.
            Stream stream = File.Open(fpath, FileMode.Create);
            stream.Close();
            Console.WriteLine("\nSerialization Successful");
            Console.ReadLine();
        }
    }
    public class Userdetails
    {
        public int userid { get; set;}
        public string username { get; set;}
        public string location { get; set;}
        public Userdetails(int id, string name, string place)
        {
            userid=id;
            username=name;
            location=place;
        }
        public void getdetails()
        {
            Console.WriteLine("User ID: {0}",userid);
            Console.WriteLine("Username: {0}",username);
            Console.WriteLine("Location : {0}",location);
        }
    }
}

