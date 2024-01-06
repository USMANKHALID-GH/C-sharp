namespace MainProject.service.serviceImpl;
using MainProject.model;
public class TeacherServiceImpl: TeacherService
{
    
    private static List<Teacher> _teachers = new();

    private CourseService CourseService = new CourseServiceImpl();
    
    public void saveTeacher(Teacher teacher)
    {
        
        _teachers.Add(teacher);
    }
    
    public void assignCourseToTeacher(int teacherId, int courseId)
    {
        Teacher teacher = getTeacherById(teacherId);
        Courses course = CourseService.getCourseById(courseId);
        teacher.Courses.Add(course);
        _teachers.Remove(teacher);
        _teachers.Add(teacher);
    }


    public void unAssignCourseToTeacher(int teacherId, int courseId)
    {
        Teacher teacher = getTeacherById(teacherId);
        Courses course = CourseService.getCourseById(courseId);
        teacher.Courses.Remove(course);
    }
    public Teacher getTeacherById(int id)
    {
        return GetById(id);
    }
    
    public List<Teacher> getAllTeachers()
    {
        return _teachers;
    }
    
    public void updateTeacher(Teacher teacher, int id)
    {
        throw new NotImplementedException();
    }
    
    public void deleteTeacher(int id)
    {
        Teacher teacher = GetById(id);
       if (teacher.Courses == null) throw new Exception("Teacher Cant be Deleted" + id); 
        _teachers.Remove(teacher);
    }
    
    private Teacher GetById(int id)
    {
       return _teachers.Where(d => d.Id == id).FirstOrDefault() ?? throw new Exception("Teacher not found" + id);
    }
    
}