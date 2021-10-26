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
            //descendingOrder(new int[] { 1, 2, 5,3,9,7,6,3,1,6, 5, 6 });
            //Console.WriteLine(SndLargest(new int[] { 1,2,3,4,9,9,9,9,7,8 }));
            //Console.WriteLine(LeftDiagonalSum(new int[,] { { 1, 2 }, { 3, 4 } }));
            //sumRowsCols(new int[,] { { 1, 2 }, { 3, 4 } });
            printMat(upperRightZero(new int[,] { { 1, 2,3}, { 4,5,6 },{ 7, 8, 9 } }));
            
            Console.Write("\n" + "Type any key to exit");
            Console.ReadKey();
        }
        static void printMat (int[,] m)
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
            int n = 2,tmp = 0;
            
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            while (n < arr.Length)
            {
                if (arr[n-1] > arr[n])
                {
                    return arr[n];
                }
                else
                {
                    n++;
                }
            }
            if (arr[arr.Length-2] >= arr[arr.Length - 1])
            {
                return arr[arr.Length - 2];
            }
            return 0;
        }

        /**
         * Array exercise 21, matrix mutliplication
         */
        static void MatrixMul(int[,] m1, int[,] m2)
        {
            if (m1.GetLength(1) != m2.GetLength(0))
            {
                throw new ArgumentException("Matrix dimensions are invalid");
            }
        }

        /**
         * Array exercise 24, sum of left diagonals in square matrix
         */

        static int LeftDiagonalSum (int[,] m)
        {
            int sum = 0,j = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                sum += m[i, j];
                j++;
            }
            return sum;
        }

        /**
         * Array exercise 25, sum of rows and columns of square matrix
         */
        static void sumRowsCols (int [,] m)
        {
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                int colSum = 0, rowSum = 0;
                for (int j = 0; j < cols; j++)
                {
                    rowSum += m[i, j];
                    colSum += m[j, i];
                }
                Console.Write("{0}:st columnsum = {1}" + "\n", i+1, colSum);
                Console.Write("{0}:st rowsum    = {1}" + "\n", i+1, rowSum);
            }
        }

        /**
         * Array exercise 27, 0's on upper triangular matrix, right-bound
         */
        static int[,] upperRightZero (int [,] m)
        {
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = i+1; j < cols; j++)
                {
                    m[i, j] = 0;
                }
            }
            return m;
        }
    }
}
