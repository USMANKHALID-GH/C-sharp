namespace MainProject.model;

public class Student
{
    private readonly int id;
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public Department Department { get; set; }
    public List<Courses>? Courses { get; set; }
    
    public Student(int id, string name, int age, string email, Department department=null, List<Courses> courses=null)=>
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