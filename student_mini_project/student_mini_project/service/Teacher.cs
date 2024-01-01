namespace MainProject.service;
using MainProject.model;

public interface TeacherService
{
    void saveTeacher(Teacher teacher);
    Teacher getTeacherById(int id);
    List<Teacher> getAllTeachers();
    void updateTeacher(Teacher teacher, int id);
    void deleteTeacher(int id);
    
}