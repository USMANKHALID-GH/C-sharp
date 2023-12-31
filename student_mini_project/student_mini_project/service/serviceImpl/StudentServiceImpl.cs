namespace MainProject.service.serviceImpl;
using MainProject.model;
using MainProject.service;
public class StudentServiceImpl: StudentService
{
    

    private List<Student> _students = new();
    public void saveStudent(Student student)
    {
       
    
        _students.Add(student);
    }
    
    public  void AssignCourse(List<Courses> coursesList,int id)
    {
        if (coursesList.Capacity > 6)
        {
            throw new Exception("Can't assign more than 6 courses");
        }
         var student = getStudentById(id) ?? throw new Exception("Student not found");

         student.Courses = coursesList;
         updateStudent(student,student.Id);
    }

    public Student getStudentById(int id)
    {
     
        return GetById(id);
    }

    public List<Student> getAllStudents()
    {
        return _students;
    }

    public void updateStudent(Student student,int id)
    {
        var student_= GetById(id);
            _students.Remove(GetById(id) ?? throw new Exception("Student not found" + id));
      
    }

    public void deleteStudent(int id)
    {
        _students.Remove(GetById(id) ?? throw new Exception("Student not found" + id));
    }
    
    private Student GetById(int id)
    {
        Student? student = _students.Where(d => d.Id == id).FirstOrDefault();
        return student;
    }
    
}