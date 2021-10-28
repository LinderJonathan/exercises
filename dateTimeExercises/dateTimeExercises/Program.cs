using System;

namespace dateTimeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2016, 6, 8, 11, 49, 0);
            DateTime[] dates = { DateTime.Now,
                           new DateTime(2016, 8, 16, 9, 28, 0),
                           new DateTime(2011, 5, 28, 10, 35, 0),
                           new DateTime(1979, 12, 25, 14, 30, 0) };
            //getMonthDifference();
            //shortFormatDate(dt1);
            //displayTimeProperties(dt1);
            //localTimeGlobalTime();
            displayArrayDates(dates);
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
        /**
         * DateTime exercise 5. Display local and global UTC time
         */
        static void localTimeGlobalTime ()
        {
            Console.WriteLine("Local date and time: " + DateTime.Now);
            Console.WriteLine("UTC date and time: " + DateTime.UtcNow);
        }
        /**
         * DateTime exercise 7. Display time in different formats from array of type DateTime
         */
        static void displayArrayDates (DateTime[] dates)
        {
            foreach (DateTime date in dates)
            {
                Console.WriteLine("day: {0:d}, time: {1:g}",date.Date, date.TimeOfDay);
                Console.WriteLine("day: {0:d}, time: {0:t}", date);
            }
        }

    }
}
