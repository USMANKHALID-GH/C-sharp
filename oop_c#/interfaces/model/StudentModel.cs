using Service;

namespace Implementation.model;

public class StudentModel
{
    private readonly int id;
    private string Name { get; set; }
    private int Age { get; set; }
    private string Email { get; set; }
    private string Address { get; set; }

    public  StudentModel()
    {
    }

    public StudentModel(int id, string name, int age, string email, string address)
    {
        this.id = id;
        Name = name;
        Age = age;
        Email = email;
        Address = address;
    }

    public int Id
    {
        get => Id;
    }
}