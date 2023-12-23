// See https://aka.ms/new-console-template for more information

namespace inheritance;

public class Program
{
    public static void Main(string[] args)
    {
        BMW bmw = new BMW("red", "bmw", "2020", 300);
        Console.WriteLine(bmw.ToString());
    }
}

public  class Vehicel{
    
    private  const  decimal VehicelPrice = 1000m; 

    public string Color { get; set; }
    public string name  { get; set; }
    
    public Vehicel(string color, string name) =>(color, name) = (color, name);

    public virtual decimal GetVehicelPrice()=> 0;


    public decimal GetTotalPrice() => VehicelPrice;

}

class  BMW: Vehicel
{
    public string Year { get; set; }
    public int  Speed { get; set; }
    
    public decimal? Discount { get; set; }
    
    

    public BMW(string color, string name, string year) : base(color, name)
    {
        Year = year;
    }
    public BMW(string color, string name, string year,int speed) : base(color, name)
    {
        Year = year;
        Speed = speed;
    }

 
    public override decimal GetVehicelPrice()
    {
        decimal number = Discount ?? 1.9m;

        return base. GetTotalPrice() * number;
    }

    public override string ToString()
    {
        return "Color: "+ Color + "Name: " + name + "Year " + Year + " Speed" + Speed  + "Price" + GetVehicelPrice(); 
    }
}



