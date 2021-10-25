using System;

namespace loopProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[,] m = multTable(int.Parse(Console.ReadLine()));
            //printMat(m);
            //Console.ReadKey();
            //christmasTree();
            //DiamondPattern();
            Console.WriteLine("Lol");
        }

        /**
         * Exercise 7 https://www.w3resource.com/csharp-exercises/for-loop/index.php
         */
        static string[,] multTable ()
        {
            int topFactor = 10;     // a mult-table goes up to 10 
            int range = int.Parse(Console.ReadLine());
            // a multiplication table imagined as matrix
            string[,] m = new string[topFactor, range];
            for (int i = 1; i <= topFactor; i++)
            {
                for (int j = 1; j <= range; j++)
                {
                    m[i - 1, j - 1] = j + " * " + i + " = " + i * j + ", ";
                }
            }
            return m;
        }
        /**
         * Exercise 13 https://www.w3resource.com/csharp-exercises/for-loop/index.php
         */
        static void christmasTree()
        {
            int k = 1;
            int j;
            int height = int.Parse(Console.ReadLine());
            int t = height;
            for (int i = 1; i <= height; i++)
            {
                j = i;
                for (int spc = 0; spc < t; spc++)
                {
                    Console.Write(" ");
                    
                }
                while (j > 0)
                {
                    
                    Console.Write(" {0}", k);
                    k++;
                    j--;
                }
                Console.WriteLine();
                t--;
            }
            Console.ReadKey();
        }

        /**
         * Exercise 31, diamond pattern. https://www.w3resource.com/csharp-exercises/for-loop/index.php
         */

        static void DiamondPattern()
        {

            int height, spcs, count;
            count = 1;
            height = int.Parse(Console.ReadLine());
            spcs = height;
            for (int i = 0; i < height; i++)
            {
                if (i < height)
                {
                    for (int j = 0; j < spcs; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < count; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    spcs--;
                    count += 2;
                }
                else
                {
                    spcs = 0;
                    for (int j = 1; j > spcs; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = height-1; k > 0; k--)
                    {

                    }
                }
            }
        }

        /**
         * Function prints a matrix of type string
         */
        static void PrintMat(string[,] m)
        {
            int rowLength = m.GetLength(0);
            int colLength = m.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", m[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }

    }
}
