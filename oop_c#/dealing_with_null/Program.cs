// See https://aka.ms/new-console-template for more information

namespace null_;

internal class Program
{
     static void Main(string[] args)
    {
        string name = "usman";
        List<int> numbers = new();
 
        int x = 1==0? 0 : 1;

        string? t = null;
        int? t1=null;
        Console.WriteLine($"t {t}  t1 {t1}");
        name = "NO NO";
        Console.WriteLine(name ?? "Hello, World!");
        Console.WriteLine("Hello, World!");
        if (name?.Length > 0)
        {
            Console.WriteLine(t);
        }
    }
}


public class Person{

    public string Name { get; set; }
    public string? LastName { get; set; }
    
    private Person(string name, string? lastName)=> (Name, LastName) = (name, lastName);
    
    public static Person Create(string name, string lastName) => new Person(name, lastName);
    
    public static Person Create(string name) => new Person(name, null);
    
    
}