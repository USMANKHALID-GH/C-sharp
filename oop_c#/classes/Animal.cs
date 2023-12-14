using System;

namespace classes
{
    public class Animal
    {
        private static int NumberOfAnimal = 0;
        private string name;
        private string sound;

        public Animal()
        {
            name = "None";
            sound = "No sound";
            NumberOfAnimal++;
        }

        public Animal(string name="NONE", string sound="No Sound")
        {
            this.name = name;
            this.sound = sound;
            NumberOfAnimal++;
        }
        
       

        public void NumberOfAnimal1()
        {
            Console.WriteLine($"The number of Animals are {NumberOfAnimal}");    
        }
    }
}