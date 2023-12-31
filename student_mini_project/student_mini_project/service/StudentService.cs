using MainProject.model;
namespace MainProject.service;


public interface StudentService
{
    void saveStudent(Student studen);

    Student getStudentById(int id);
    
    List<Student> getAllStudents();
    
    void updateStudent(Student student,int id);
    
    void deleteStudent(int id);

    void AssignCourse(List<Courses> coursesList, int id);

}