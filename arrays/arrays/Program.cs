using System;

namespace arrays
{
    /**
     * Contained in this class are functions for solving the exercises from w3resource
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SumIntArray(new int[]{1,2,3,4}));
            uniqueElements(new int[]{ 1, 1, 2, 3, 5, 4, 5, 6, 8, 8 }); 
            Console.Write("Type any key to exit");
            Console.ReadKey();
        }
        /**
         * Array exercise 3, sum of elements 
         */
        static int SumIntArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void uniqueElements(int[] arr)
        {
            int ctr;
            for (int i = 0; i < arr.Length; i++)
            {
                ctr = 0;
                for (int j = 0; j < i-1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ctr++;
                    }
                }
                for (int k = i+1; k < arr.Length; k++)
                {
                    if (arr[i] == arr[k])
                        ctr++;

                    if (arr[i] == arr[i + 1])
                    {
                        ctr++;
                    }
                }

                if (ctr == 0)
                {
                    Console.Write(" {0} ", arr[i]);
                }
            }
        }
    }
}
