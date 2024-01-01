namespace MainProject.service.serviceImpl;
using MainProject.model;

public class CourseServiceImpl: CourseService
{
    private List<Courses> _coursesList = new();
    private StudentService studentService = new StudentServiceImpl();
    public void saveCourse(Courses course)
    {
        _coursesList.Add(course);
    }

    public Courses getCourseById(int id)
    {
        return GetById(id) ?? throw new Exception("Course not found" + id);
    }

    public List<Courses> getAllCourses()
    {
        return _coursesList;
    }

    public void updateCourse(Courses course, int id)
    {
        _coursesList.Remove(GetById(id) ?? throw new Exception("Course not found" + id));
         _coursesList.Add(course);  
    }

    public void deleteCourse(int id)
    {

        var course = studentService.getAllStudents().Any(studen => studen.Courses.Any(c => c.Id == id));
        if (course)
        {
            throw new Exception("Course cannot be deleted");
        }

        _coursesList.Remove(GetById(id));

    }

    private Courses GetById(int id)
    {
        Courses? studentCourses = _coursesList.Where(d => d.Id == id).FirstOrDefault();
        return studentCourses;
    }
    
}