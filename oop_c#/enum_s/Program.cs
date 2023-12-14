using System;

namespace enum_
{
internal class Program
{

    static void DealingWithEnum(Days days)
    {
        Console.WriteLine($"To day is {days} and is the {(int)days} day of the week");
        
    }
    enum Days : byte
    {
        Monday=1, TuesDay, WednessDay, ThursDay,FriDay,SaturDay,SunDay
    }
    public static void Main(string[] args)
    {
        DealingWithEnum(Days.Monday);
    }
}
}