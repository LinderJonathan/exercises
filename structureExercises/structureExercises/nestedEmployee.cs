using System;
using System.Collections.Generic;
using System.Text;

struct birthDate
{
    public int day;
    public int month;
    public int year;
}

struct employee
{
    public birthDate date;
    public string name;
}


namespace structureExercises
{
    class nestedEmployee

    {
        static int maxEmployees = 2;
        public static void main()
        {
            employee[] employees = new employee[maxEmployees];
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("Name of employee # " + i + ": ");
                employees[i].name = Console.ReadLine();

                Console.WriteLine("Date of birth: \nDay: ");
                employees[i].date.day = int.Parse(Console.ReadLine());

                Console.WriteLine("Month: ");
                employees[i].date.month = int.Parse(Console.ReadLine());

                Console.WriteLine("Year: ");
                employees[i].date.year = int.Parse(Console.ReadLine());

            }
        }
    }
}
