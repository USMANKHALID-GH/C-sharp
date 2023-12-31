using MainProject.model;
namespace MainProject.service;

public interface DepartmentService
{

    void saveDepartment(Department department);
    Department getDepartmentById(int id);
    List<Department> getAllDepartments();
    void updateDepartment(Department department,int id);
    void deleteDepartment(int id);
    
}