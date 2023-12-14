
namespace MyNamespace
{
    class  DealingWithArrays
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Welcome to Arrays");
            int[] intArray = { 1, 2, 43, 54 };
           Array.Sort(intArray);
           foreach (var VARIABLE in intArray)
           {
               Console.Write(VARIABLE+ " ");
           }

           Array array = Array.CreateInstance(typeof(int), 10);
           
           foreach (var VARIABLE in array)
           {
               Console.Write(VARIABLE +" ");
           }
           Console.WriteLine();
           Console.WriteLine($"The sum of the following is: {SumParam(10,2,45,5)}");
        }


        static double SumParam(int i=0,params double[] array)
        {
            double sum = 0;
            foreach (var VARIABLE in array)
                sum += VARIABLE;

            {
                return sum+i;

            }
        }
    }
}

