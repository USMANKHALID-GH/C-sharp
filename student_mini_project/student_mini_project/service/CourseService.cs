namespace MainProject.service;
using MainProject.model;


public interface CourseService
{
    
    void saveCourse(Courses course);
    
    Courses getCourseById(int id);
    
    List<Courses> getAllCourses();
    
    void updateCourse(Courses course,int id);
    
    void deleteCourse(int id);
    
}