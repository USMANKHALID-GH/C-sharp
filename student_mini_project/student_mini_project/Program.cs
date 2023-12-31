using MainProject.model;
using MainProject.service;
using MainProject.service.serviceImpl;

namespace MainProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WE ARE ABOUT TO START!!!!!!!!!!!!!!!!!!!!!!!!!!/n");
            Console.WriteLine("1: FOR DEPARTMENT 2: FOR STUDENT 3: FOR TEACHER 4: EXIT");
            var expression = Console.ReadLine();
            do
            {
                switch (expression)
                {
                    case "1":
                        DepartmentWork();
                        break;
                    case "2":
                        StudentWork();
                        break;
                    default:
                        throw new Exception("Invalid input");

                }

            } while (!expression.Equals("4", StringComparison.OrdinalIgnoreCase));

        }

        public static void DepartmentWork()
        {
            DepartmentService departmentService = new DepartmentServiceImpl();

            string expression;

            do
            {
                Console.WriteLine("1: SAVE  2: GET 3: UPDATE 4: DELETE: 5: EXIT");
                expression = Console.ReadLine();
                switch (expression)
                {
                    case "1":
                    {
                        Console.WriteLine("Enter the name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter the id");
                        var id = Console.ReadLine();
                        Department department = new Department(int.Parse(id), name);
                        departmentService.saveDepartment(department);
                        foreach (var VARIABLE in departmentService.getAllDepartments())

                        {
                            Console.WriteLine(VARIABLE.ToString());
                        }

                    }
                        break;
                    case "2":
                    {
                        Console.WriteLine("Enter the id");
                        var id = Console.ReadLine();
                        var department = departmentService.getDepartmentById(int.Parse(id));
                        Console.WriteLine(department.ToString());

                    }
                        break;
                    case "3":
                    {
                        Console.WriteLine("Enter the id");
                        var id = Console.ReadLine();
                        Console.WriteLine("Enter the name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter the age");
                        Department department = new Department(int.Parse(id), name);
                        departmentService.updateDepartment(department, int.Parse(id));

                    }
                        break;
                    case "4":
                    {
                        Console.WriteLine("Enter the id");
                        var id = Console.ReadLine();
                        departmentService.deleteDepartment(int.Parse(id));
                        Console.WriteLine(departmentService.getAllDepartments());

                    }
                        break;
                    default:
                    {
                        foreach (var VARIABLE in departmentService.getAllDepartments())

                        {
                            Console.WriteLine(VARIABLE.ToString());
                        }
                    }
                        break;

                }

            } while (!expression.Equals("5", StringComparison.OrdinalIgnoreCase));

        }

        public static void StudentWork()
        {
            StudentService studentService = new StudentServiceImpl();
            DepartmentService departmentService=new DepartmentServiceImpl();
            string expression;

            do
            {
                Console.WriteLine("1: SAVE  2: GET 3: UPDATE 4: DELETE: 6:ASSIGN COURSE 5: EXIT");
                expression = Console.ReadLine();
                switch (expression)
                {
                    case "1":
                    {
                        Console.WriteLine("Enter the name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter the id");
                        var id = Console.ReadLine();
                        Console.WriteLine("Enter the age");
                        var age = Console.ReadLine();
                        Console.WriteLine("Enter the email");
                        var email = Console.ReadLine();
                        Console.WriteLine("Enter the department id");
                        var departmentId = Console.ReadLine();
                        Student student = new Student(int.Parse(id), name, int.Parse(age), email);
                        student.Department = departmentService.getDepartmentById(int.Parse(departmentId));
                        studentService.saveStudent(student);
                      
                        foreach (var VARIABLE in studentService.getAllStudents())

                        {

                            Console.WriteLine(VARIABLE.ToString());
                        }

                        break;
                    }

                    case "2":
                    {
                        Console.WriteLine("Enter the id");
                        var id = Console.ReadLine();
                        var student = studentService.getStudentById(int.Parse(id));
                        Console.WriteLine(student.ToString());
                        
                    }
                        break;
                    case "3":
                    {
                        var id = Console.ReadLine();
                        var name = Console.ReadLine();
                        var age = Console.ReadLine();
                        var email = Console.ReadLine();
                        var departmentId = Console.ReadLine();
                        Student student = new Student(int.Parse(id), name, int.Parse(age), email);
                        studentService.updateStudent(student, int.Parse(id));
                        Console.WriteLine("Updated");
                    }
                        break;

                    case "4":
                    {
                        var id = Console.ReadLine();
                        studentService.deleteStudent(int.Parse(id));
                    }
                        break;
                    case "6":
                    {
                        Console.WriteLine("Enter the id");
                        var id = Console.ReadLine();
                        Console.WriteLine("Enter the courses id");
                        var coursesId = Console.ReadLine();
                        var coursesList = new List<Courses>();
                      
                        studentService.AssignCourse(coursesList, int.Parse(id));
                        
                    }
                        break;
                    default:
                    {
                        foreach (var VARIABLE in studentService.getAllStudents())
                        {
                            Console.WriteLine(VARIABLE.ToString());
                        }
                    }
                        break;
                }

            } while (!expression.Equals("5", StringComparison.OrdinalIgnoreCase));

        }
    }
}
            