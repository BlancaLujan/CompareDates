using System;

namespace CompareDates
{
    class Program
    {
        static void Main()
        {
            DateTime myDateTimeVariable = new DateTime(12 / 09 / 2011);
            DateTime myDateTimeVariable2 = DateTime.Now;

            int result = DateTime.Compare(myDateTimeVariable, myDateTimeVariable2);

            Console.WriteLine(result);
        }
    }
    
}
