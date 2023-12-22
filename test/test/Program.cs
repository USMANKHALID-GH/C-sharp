// See https://aka.ms/new-console-template for more information


using packageName;
using Jeeed;
namespace  packageName
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass(1,"John", "Doe", 25);

           
            Myclass.printSomething1();
            Console.WriteLine();
            
            
            Console.WriteLine(myclass.ToString());
            Console.WriteLine(myclass.printSomething("nothing"));
            myclass.printSomething2("usman","khalid","ali","ahmed","mohamed","ahmed");

            Student student = new Student();
            student.DoSomething();
            
            Student1 student1= new Student1();
            student1.DoSomething();

        }
    }

    class  Myclass
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private readonly int id=1;

        private string? gender; 

        public Myclass()
        {
        }
        public Myclass( string lastName, int age)
        {
            _lastName = lastName;
            _age = age;
        }
        
        public Myclass(string firstName, string lastName, int age): this(lastName,age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }
        
        public Myclass(int id,string firstName, string lastName, int age)
        {
            this.id = id;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }
        
        public int Id
        {
            get => id;
        }

        public string printSomething(string name = "usman khalid")
        {
            return name;
        }
        
        public static void printSomething1()
        {
            Console.WriteLine("i am a static method");
        }
        
        public void printSomething2( params string[] name)
        {
            foreach (var i in name)
            {
              Console.WriteLine("NAME: {0}",i);   
            }
        }

        public override string ToString()
        {
            return  $" id: {id} firstName: {_firstName}  lastName: {_lastName}  age:  {_age}";
        }
    }
}


