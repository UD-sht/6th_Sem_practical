﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    class Dog
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>() 
            {
             new Dog { Name = "Ren", Age = 4 },
             new Dog { Name = "Sean", Age = 0 },
             new Dog { Name = "Stacy", Age = 3 }
            };            
            var names = dogs.Select(x => x.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
