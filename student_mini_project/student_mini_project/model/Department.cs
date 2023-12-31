namespace MainProject.model;

public class Department
{
    private readonly int id;
    public string Name { get; set; }
  
    public Department(int id, string name) => (this.id, Name) = (id, name);

    public int Id
    {
        get => id;
    }

    public override string ToString()
    {
        return $"Id: {id}, Name: {Name}";
    }
}