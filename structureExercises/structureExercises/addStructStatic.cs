using System;
using System.Collections.Generic;
using System.Text;

struct addStatic
{
    public static int x;
    public static int y;
}

namespace structureExercises
{
    class addStructStatic
    {
        public static void main()
        {
            Console.Write("\n Declare simple structure: \n");
            Console.Write("\n ------------------------- \n");
            addition adding = new addition();
            adding.x = int.Parse(Console.ReadLine());
            adding.y = int.Parse(Console.ReadLine());
            int sum = adding.x + adding.y;
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
