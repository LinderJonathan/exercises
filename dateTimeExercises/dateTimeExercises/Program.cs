using System;

namespace dateTimeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2016, 6, 8, 11, 49, 0);
            //getMonthDifference();
            //shortFormatDate(dt1);
            displayTimeProperties(dt1);
        }
        /**
         * Method calculates a number of time differences in days from fixed referenceDate
         */
        static void getMonthDifference()
        {
            Console.WriteLine("Enter reference date: ");
            DateTime reference = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter # of reference points: ");
            Console.Write("\n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter date (yyyymmdd): ");
                DateTime actual = DateTime.Parse(Console.ReadLine());
                int monthsApart = (12 * (reference.Year - actual.Year)) + reference.Month - actual.Month;
                Console.Write("# of months from reference = " + Math.Abs(monthsApart));
                Console.Write("\n");
            }

        }
        /**
         * DateTime exercise 1. Solution is appearantly not correct
         */
        static void shortFormatDate(DateTime dt1)
        {
            DateTime dateOnly = dt1.Date;
            Console.WriteLine("Short date: " + dateOnly.ToString("d"));
            Console.WriteLine("Display date using 24-h clock format: ");

            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));
        }
        /**
         * DateTime exercise 2. Display all properties of date. 
         */
        static void displayTimeProperties (DateTime dt1)
        {
            Console.Write(dt1.Year + "\n");
            Console.Write(dt1.Month + "\n");
            Console.Write(dt1.Day + "\n");
            Console.Write(dt1.Hour + "\n");
            Console.Write(dt1.Minute + "\n");
            Console.Write(dt1.Second + "\n");
            Console.Write(dt1.Millisecond + "\n");
        }
    }
}
