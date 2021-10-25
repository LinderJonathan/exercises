using System;
using System.Collections;

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
            //uniqueElements(new int[]{ 1, 1, 2, 3, 5, 4, 5, 6, 8, 8 });
            descendingOrder(new int[] { 1, 2, 5,3,9,7,6,3,1,6, 5, 6 });
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
        /**
         * Array exercise xx. sort unique elements in list
         */
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
        /**
         * Array exercise 10. Can obviously be solved without using lists
         */
        static void SeperateEvenFromOdd (int[] arr)
        {
            int oddLength = 0;
            int evenLength = 0;
            ArrayList oddList = new ArrayList();
            ArrayList evenList = new ArrayList();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenList.Add(arr[i]);
                    evenLength++;
                }
                else
                    oddList.Add(arr[i]);
                    oddLength++;
            }

            int[] evenArr = (int[]) evenList.ToArray(typeof(int));
            int[] oddArr = (int[]) oddList.ToArray(typeof(int));
        }

        /**
         * Array exercise 12, w3resource
         */
        static void descendingOrder(int[] arr)
        {
            int tmp;
            
            int[] refArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }

            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write("{0}, ", arr[k]);
            }
            Console.Write("\n");
        }

        /**
         * Array exercise 16, second largest element in array
         */
        static int SndLargest (int[] arr)
        {
            int largest = arr[0];
            
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] >= largest)
                {
                    largest = arr[i];
                }

            }
            return 0;
        }
    }
}
