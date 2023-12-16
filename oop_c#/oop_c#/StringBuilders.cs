using System;
using System.Globalization;
using System.Text;

namespace oop_c_
{
    public class StringBuilders
    {
      public  static void StringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder("this is me");
            stringBuilder.Append(" yes");
            
            Console.WriteLine(stringBuilder);
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("tr");
            stringBuilder.AppendFormat(cultureInfo, " gelemiyorum");
            Console.WriteLine(stringBuilder);
        }
    }
}