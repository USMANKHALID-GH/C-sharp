using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_loop_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your age");
           int input= Convert.ToInt32(Console.ReadLine());

            if(input <18)
            {
                Console.WriteLine("You are below 18 years");
            }
            else if(input < 30)
            {
                Console.WriteLine("Your age is between 18-30");
            }
            else {
                Console.WriteLine("Your above 30"); 
            }

            int sum = 0;
            for (int i = 0; i <= 10; i++) {
                sum += i;
            }
            Console.WriteLine($"sum: {sum}");

            while (sum < 100)
            {
                sum++;
            }

            Console.WriteLine($"sum {sum}");

            do
            {
                sum += 10;
            } while (sum < 150);
            Console.WriteLine("sum : " + sum);

            Console.WriteLine(SwitchStatement(3));


            Console.WriteLine("Enter x");
            int x= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y");
            int y = Convert.ToInt32(Console.ReadLine());

            ExceptionHandler(x, y);
            Console.ReadLine();
        }

       static string SwitchStatement(int x)
        {

            switch (x)
            {


                case 0: return "Sunday";
                case 1: return "monday";
                case 2: return "Tuesday";
                case 3: return "WednessDay";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 7: return "Saturday";
                default: return "ENTER CORRECT NAME";

            }
        }


        
        static void ExceptionHandler(int x , int y)
        {
            try
            {
                Console.WriteLine($"division of {x} and {y} = {x / y}");

            }
            catch (Exception e)
            {
               
              Console.WriteLine (e.ToString());
            }

           
        }


    }
}
