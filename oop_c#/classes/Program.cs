﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classes.other_classes;

namespace classes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var student= new Student(1,"usman", "khalid");
            
            Console.WriteLine(student.getFirstName());
            Animal animal = new Animal();
            animal.NumberOfAnimal1();
            Animal animal1 = new Animal("CAT");
            
            animal1.NumberOfAnimal1();

        }
    }
}
