using Implementation.model;

namespace Service
{
    public interface StudentService
    {
        string GetStudentId();
        void saveStudent(StudentModel studentModel);
        
        List<StudentModel> getAllStudents();
        
        StudentModel  getStudentById(int id);
        
        void updateStudent(StudentModel studentModel);
        
        void deleteStudent(int id);
        
       

    }
}

