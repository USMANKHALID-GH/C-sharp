namespace MainProject.model;

public class Courses
{
    private readonly int id;
    public string Code { get; set; }
    public string Credit { get; set; }
    
    public Department Department {get; set;}
    
    public Courses(int id, string code, Department department, string credit)=> (id, Code,Department, Credit) = (id, code,Department, credit);

    public override string ToString()
    {
        return $"Id: {Id}, Code: {Code}, Credit: {Credit}";
    }

    public int Id
    {
        get => Id;
    }
}