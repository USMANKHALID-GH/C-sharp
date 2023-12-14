using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("usman", "khalid", 'M', 45, "Black");
            Console.WriteLine(student.ToString());
        }
    }

    class  Student
    {
        private string firstName;
        private string secondName;
        private char sex;
        private int age;
        private string hairColor;

        public Student(string firstName, string secondName, char sex, int age, string hairColor)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.sex = sex;
            this.age = age;
            this.hairColor = hairColor;
        }

        public Student()
        {
            
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string SecondName
        {
            get => secondName;
            set => secondName = value;
        }

        public char Sex
        {
            get => sex;
            set => sex = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string HairColor
        {
            get => hairColor;
            set => hairColor = value;
        }

        public override string ToString()
        {
            return $"First Name: {firstName}  Last Name: {SecondName}   Sex: {sex} Hair Color: {hairColor}  Age: {age}";
        }
    }
}
