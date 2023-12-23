using Service;
using Service.serviceImpl;
using Implementation.model;

namespace Implementation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            StudentModel studentModel= new StudentModel(1, "usman", 45,"loftyusman@gmail", "Black");
            StudentService studentService = new StudentServiceImp();
            studentService.saveStudent(studentModel);
            studentService.saveStudent(new StudentModel(2, "usman", 45,"loftyusman@gmail1", "Black"));
            studentService.saveStudent(new StudentModel(3, "usman", 45,"loftyusman@gmail2", "Black"));
            studentService.saveStudent(new StudentModel(4, "usman", 45,"loftyusman@gmail3", "Black"));
            studentService.saveStudent(new StudentModel(5, "usman", 45,"loftyusman@gmail4", "Black"));
            List<StudentModel> list = studentService.getAllStudents();
           Console.WriteLine( studentService.getStudentById(2).ToString());
           studentService.deleteStudent(1);
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            math sum=( x, y)=>x+y;
            Console.WriteLine(sum(7,7));
          Func<int,string> m= (i) => $"hello {i}";
          Console.WriteLine(m(7));
        
         
        }
        public delegate int math(int x, int y);
          
        
        
    }
    
   
}

