using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {

        public static void DealingWithDecimal()
        {
            Console.WriteLine("Currency: {0:c}",3.55);
            Console.WriteLine("Padding: {0:d4}",45);
            Console.WriteLine("3 Decimal place: {0:f3}",5.9999);
            Console.WriteLine("Add commans : {0:n}",55555555);
        }

        public static void DealingWithString()
        {
            string sentence = "usman khalid is my name";
            foreach (var i in sentence)
                
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(sentence.ToUpper());
            Console.WriteLine(sentence[3]);
            Console.WriteLine(sentence.Contains("usman"));
            Console.WriteLine(sentence.Length);
            Console.WriteLine(sentence.Normalize());
            Console.WriteLine(sentence.Insert(0,"Dont "));
            Console.WriteLine(sentence.Replace("a","A"));
            string[] split_sentence = sentence.Split(' ');
            Console.WriteLine(split_sentence[1]);
            string newString = "usman";
            Console.WriteLine(newString.PadLeft('*'));
            Console.WriteLine(newString.PadRight('^'));
            Console.WriteLine(newString.CompareTo("usman"));
            Console.WriteLine(newString.ToUpperInvariant());
            Console.WriteLine(string.Equals(newString, "usmaN",StringComparison.CurrentCultureIgnoreCase));
            
            Console.WriteLine("Any Digit: {0}",newString.Any(char.IsDigit));
            Console.WriteLine("Any Number: {0}",newString.Any(char.IsNumber));



        }

        public static void RandomNumber()
        {
            Random random = new Random();
            int number;
            int guese;
            int score = 0;
            int count = 0;
            do
            {
                number = random.Next(1, 10); 
                Console.WriteLine("Enter A number /n");
                guese = int.Parse(Console.ReadLine());
                if (guese == number)
                {
                    score += 3;
                }
                else
                {
                    score -= 1;
                }

                Console.WriteLine($"number :{number} and guese {guese}");
                count++;

            } while (count<=3);
            Console.WriteLine($"Score is {score}");
        }
        
        // out function
        static void OutMethod(int x, out int y)
        {
            y = x * x;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            int solution;
            OutMethod(45,out solution);
            Console.WriteLine("solution: {0}", solution);
            //RandomNumber();
            DealingWithString();
            //DealingWithDecimal();
            float f = 5.1f;
            //Console.WriteLine($"FLOAT {f}");
            
            print();
            print("usman khalid");

           int result= add(3, 5);
            //Console.WriteLine(result);

            //Console.WriteLine(max(45, 65));
            int[] array=p.GetArray();

            //Console.WriteLine($"{MaxInArray(array)}");
           foreach(int i in array)
            {
    
              //  Console.Write(i+ " ");
            }
            //5Console.ReadLine();

        }

        static void print( string name = "usman")
        {
            Console.WriteLine(name);
        }

        static int  add( int x, int y )
        {
            return x + y;
        }

        static long max( long x, long y )
        {
            if( x > y )
            {
                return x;
            }
            else
               return y;
        }

       public int[] GetArray()
        {
            int[] array = new int[10];
            for ( int i = 0; i<array.Length; i++)
            {
                array[i] = i;
            }
            return array;
        }


       public static int MaxInArray(int[] array)
       {
           int max = array[0];
           for (int i = 0; i < array.Length; i++)
           {
               if (array[i] > max)
               {
                    max = array[i];
               }
           }
           return max;
       }
    }
}
