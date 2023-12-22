using System;


namespace oop_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("usman", "khalid", 'M', 45, "Black");
            Console.WriteLine(student.ToString());
            StringBuilders.StringBuilder();

            StudentService studentService = new StudentServiceImp();
            Console.WriteLine(studentService.GetStudentId());
            Datastructures.ArrayLists();
            
            Usman usman = new Usman();
            usman.getHairColor("black", "white", "red", "blue", "green");
            Console.Read();
        }
    }

    class  Student
    {
        private string firstName;
        private string secondName;
        private char sex;
        private int age;
        private string hairColor;
        private readonly int id=0;
        
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

    class  Usman
    {
        private string _sname;
        private string _fname;
        private int _age;
        private string _hairColor;
        
       

   

        public Usman(string hairColor,string sname= "usman", string fname="khalid", int age=4) 
        {
            
        }

        public Usman()
        {
            
        }

        public void getHairColor( params string[] hairColor)
        {
            foreach (var item in hairColor)
            {
                Console.Write($" {item}");
            }
            
        }

        public string HairColor
        {
            get => _hairColor;
            set => _hairColor = value;
        }

    
        public string Sname
        {
            get => _sname;
            set => _sname = value;
        }

        public string Fname
        {
            get => _fname;
            set => _fname = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

      
    }


    class  Khalid
    {
        private readonly int id;
        private string _sname;
        private string _fname;
        private int _age;
        
        

        public Khalid(string sname, string fname, int age)
        {
            _sname = sname;
            _fname = fname;
            _age = age;
        }

        public string Sname
        {
            get => _sname;
            set => _sname = value;
        }

        public string Fname
        {
            get => _fname;
            set => _fname = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }
        
        
    }
}
