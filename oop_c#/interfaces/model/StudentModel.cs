using Service;

namespace Implementation.model;

public class StudentModel
{
    public readonly int id;
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

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

    public override string ToString()
    {
        return "Id: " + id + ", Name: " + Name + ", Age: " + Age + ", Email: " + Email + ", Address: " + Address;
    }
}