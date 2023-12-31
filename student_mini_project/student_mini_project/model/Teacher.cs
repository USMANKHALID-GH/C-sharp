namespace MainProject.model;

public class Teacher
{
    private readonly int id;
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public List<Department> Department { get; set; }
    public List<Courses>? Courses { get; set; }
    
    public Teacher(int id, string name, int age, string email, List<Department> department, List<Courses> courses=null)=>
        (this.id, Name, Age, Email, Department, Courses) = (id, name, age, email, department, courses);
    
    public int Id
    {
        get => id;
    }


    public override string ToString()
    {
        return $"Id: {id}, Name: {Name}, Age: {Age}, Email: {Email}, Department: {Department}, Courses: {Courses}";
    }
}