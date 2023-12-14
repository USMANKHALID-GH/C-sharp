using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");
            Console.WriteLine("    /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine("/____|");

            // variable

            string name = "usman khalid";
            int age = 45;

            Console.WriteLine("my name is " + name + " and  i am " + age + " years");

            // Data types

            const String school = "Firat university";
            int class_ = 2;
            float score = 50.3f;
            string course = "phy";
            double final = 56.4;
            long tc = 111111111;
            char sex = 'M';
            bool isAlive = false;

            Console.WriteLine("School: " +school+
                " \nname: " + name +
                " \nclass: " + class_ +
                " \nscore: "+score+
                " \nsubject: "+ course+ 
                " \nfinal: "+final+
                " \ntc: "+tc);

            //Strings
           
            string myString = "usman khalid is studying C sharp";
            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.Contains("is"));

            //numbers and operators
            int x = 8;int y =10;
            Console.WriteLine( x * 10);
            Console.WriteLine(6 - 10);
            Console.WriteLine(6 / 10.0);
            Console.WriteLine(x % 10);
            Console.WriteLine(6 + y);
            Console.WriteLine(x++);
            Console.WriteLine(x);
            Console.WriteLine(--y);
            Console.WriteLine(y);
            Console.WriteLine(Math.Max(x, y));
            // taking user inputs
            Console.Write("enter your name");
            string full_name = Console.ReadLine();

            Console.WriteLine($"Hello your name is {full_name}");




             Console.ReadLine();
        }
    }
}
