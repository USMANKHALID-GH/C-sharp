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
        }
        
    }
}

