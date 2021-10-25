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
            Console.WriteLine("Enter reference date: ");
            DateTime reference = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter # of reference points: ");
            Console.Write("\n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter date (yyyymmdd): ");
                DateTime actual = DateTime.Parse(Console.ReadLine());
                Console.Write("# of days from reference = " + (actual - reference).TotalDays);
                Console.Write("\n");
            }

        }
    }
}
