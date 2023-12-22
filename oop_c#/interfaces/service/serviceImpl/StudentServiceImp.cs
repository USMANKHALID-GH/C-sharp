using Implementation.model;

namespace Service.serviceImpl;

public class StudentServiceImp: StudentService{
    
    private List<StudentModel> list = new List<StudentModel>();
    public string GetStudentId()
    {
        throw new NotImplementedException();
    }

    public void saveStudent(StudentModel studentModel)
    {
        throw new NotImplementedException();
    }

    public List<StudentModel> getAllStudents()
    {
        throw new NotImplementedException();
    }

    public StudentModel getStudentById(int id)
    {
        throw new NotImplementedException();
    }

    public void updateStudent(StudentModel studentModel)
    {
        throw new NotImplementedException();
    }

    public void deleteStudent(int id)
    {
        throw new NotImplementedException();
    }
    
    private bool checkDuplicate(string email)
    {
        throw new NotImplementedException(); 
    }
}