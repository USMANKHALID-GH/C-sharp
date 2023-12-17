using System;
using System.Collections;

namespace oop_c_
{
    public class Datastructures
    {
        public static void ArrayLists()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add(7);
            arrayList.Add(8);
            arrayList.Add(9);
            arrayList.Add(10);
            Console.WriteLine("Array: {0}",arrayList.ToString());
            Console.WriteLine("Array count: {0}",arrayList.Count);
            Console.WriteLine("Array capacity: {0}",arrayList.Capacity);
            Console.WriteLine("Array type: {0}",arrayList.GetType());
            
        }
    }
}