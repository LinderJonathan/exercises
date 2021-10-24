using System;

namespace dateTimeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            getDayDifference();
        }
        /**
         * Method calculates a number of time differences in days from fixed referenceDate
         */
        static void getDayDifference()
        {
            DateTime reference = new DateTime(2018, 03, 22);
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter date (yyyymmdd): ");
                DateTime actual = DateTime.Parse(Console.ReadLine());
                Console.Write("# of days from reference = " + (actual - reference).TotalDays);
                Console.Write("\n");
            }

        }
    }
}
