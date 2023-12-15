using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
       

        var mySchool = new School {
                Name = "Firat",
                Location = "ELzig",
                Capacity = 1000000,
                Description = "A great school for learning."
            };

            Console.WriteLine(mySchool.ToString());
           // Console.ReadLine();
            Teacher teacher = new Teacher();

            teacher.secondName = "khalid";
            Console.WriteLine(teacher.ToString());

            //Console.ReadLine();
        }
    }


    public class School
    {
        private string name;
        private string location;
        private Int64 capacity;
        private string description;

        public School()
        {
            Console.WriteLine("created constructor");
        }



        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Location
        {
            get
            { return location; }
            set { location= value; }
        }

        public Int64 Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public override string ToString()
        {
            return $"School Name: {Name}, Location: {Location}, Capacity: {Capacity}, Description: {Description}";
        }
    }

    public class Teacher
    {
        protected string firstName;

        internal string secondName;

        public Teacher()
        {
            Console.WriteLine("Teacher Class is called");
        }


        public override string ToString()
        {
            return $"first name {firstName} and second name is {secondName}";
        }
    }
    
    
    
}
