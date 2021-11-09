using System;
using System.Collections.Generic;
using System.Text;

public class newClass
{
    public int x;
    public int y;
    public newClass(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int getX
    {
        get { return x; }
    }
    public int getY
    {
        get { return y; }
    }
}

public struct newStruct
{
    public int x;
    public int y;
    public newStruct(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
namespace structureExercises
{
    class classAndStruct
    {
        public static void main()
        {
            Console.Write("\n\nCreate a structure and assign the value and call it :\n");
            Console.Write("---------------------------------------------------------\n");

            newClass classObj = new newClass(750, 750);
            //TODO: Research why the code below doesnt work
            newStruct structObj = new newStruct(750, 750);
            Console.WriteLine(classObj.x);
        }
    }
}
