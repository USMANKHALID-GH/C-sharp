using MainProject.model;
namespace MainProject.service.serviceImpl;

public class DepartmentServiceImpl: DepartmentService

{
    private List<Department> departments = new ();
    
    private StudentService _studentService = new StudentServiceImpl();

    public void saveDepartment(Department department)
    {
        if (GetById(department.Id) != null)
        {
            throw new Exception("Department already exists");
        }
        departments.Add(department);
            
        
        
    }

   public Department getDepartmentById(int id)
    {
        return GetById(id);
    }

   public List<Department> getAllDepartments()
   {
       return departments;
   }

    public void updateDepartment(Department department, int id)
    {
        if (GetById(id) == null)
        {
            throw new Exception("Department not found");
            
        }
        var newdepartment = GetById(id);
        departments.Remove(department);
        departments.Add(newdepartment);
        
    }

    public void deleteDepartment(int id)
    {
        Department? department = GetById(id);
        var student = _studentService.getAllStudents().Where(student => student.Department.Id == id).FirstOrDefault();
        if (department == null && student != null)
        {
            throw new Exception("Department not found or student exists");
        }
       
        departments.Remove(department);
    }

    private Department GetById(int id)
    {
        Department? department = departments.Where(d => d.Id == id).FirstOrDefault();
        return department;
    }
    
}