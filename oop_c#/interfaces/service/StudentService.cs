using Implementation.model;

namespace Service
{
    public interface StudentService
    {
        
        void saveStudent(StudentModel studentModel);
        
        List<StudentModel> getAllStudents();
        
        StudentModel  getStudentById(int id);
        
        void updateStudent(StudentModel studentModel, int id);
        
        void deleteStudent(int id);
        
       

    }
}

