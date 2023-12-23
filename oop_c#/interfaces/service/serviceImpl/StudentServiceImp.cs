using System.Data;
using Implementation.model;

namespace Service.serviceImpl;

public class StudentServiceImp: StudentService{
    
    private List<StudentModel> list = new List<StudentModel>();
    
   

    public void saveStudent(StudentModel studentModel)
    {
        list.Add(studentModel);
    }

    public List<StudentModel> getAllStudents()
    {
        return list;
    }

    public StudentModel getStudentById(int id)
    {
        var student=list.Where(s=>s.id.Equals(id)).First();
        return student;
    }

    public void updateStudent(StudentModel studentModel, int id)
    {
        list.Remove(findById(id));
        list.Add(studentModel);
    }

    public void deleteStudent(int id)
    {
        StudentModel studentModel = findById(id);
        list.Remove(studentModel);
    }
    
    private bool checkDuplicate(string email)
    {
        var student=list.Where(s=>s.Email.Equals(email)).First();
        
        return student != null;
    }

    private StudentModel findById(int id)
    {
        return list.Where(s=>s.id.Equals(id)).First();
    }
}