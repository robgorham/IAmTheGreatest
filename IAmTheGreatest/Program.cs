using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmTheGreatest
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] someArray = new int[] { 2, 6, 3, 7, 1, 4, 8, 9, 0, 3, 5 };
            //int[] someArray = GetArray();
            Console.WriteLine("Greatest in array is:" + Greatest(someArray)[0] + " at position:" + Greatest(someArray)[1]);
            Console.WriteLine("Sorted Array is:");
            PrintArray(someArray);
            Console.WriteLine();
            int[] sortedArray = SortIntArray(someArray);
            PrintArray(sortedArray);

            int response = GetInt("\nEnter Another Number:");
            if (IsIn(response, someArray))
            {
                Console.WriteLine("That number is in the Array");
            }
            else
            {
                Console.WriteLine("That number is not in the Array");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Returns a bool array all false;
        /// </summary>
        /// <param name="length">length of bool array to be returned</param>
        /// <returns>boolean array all false</returns>
        static bool[] initBool(int length)
        {
            bool[] result = new bool[length];
            for (int i = 0; i < length; i++) //initialize the Array
            {
                result[i] = false;
            }
            return result;
        }

        static int[] SortIntArray(int[] unSorted)
        {
            int []tempGreat = { -1, -1 };
            int[] result = new int[unSorted.Length];
            bool[] found = initBool(unSorted.Length);
            for(int i = 0; i < unSorted.Length; i++)
            {
                tempGreat = GreatestwithFlags(unSorted, found);
                result[unSorted.Length - i-1] = tempGreat[0];
                found[tempGreat[1]] = true;
            }



            return result;
        }

        /// <summary>
        /// Prints out values in integer array
        /// </summary>
        /// <param name="printMe">Integer Array to Print</param>
        static void PrintArray(int[] printMe)
        {
            Console.Write("int[]Array:");
            foreach (int element in printMe)
            {
                Console.Write(" {0} ", element);
            }
        }

        static int[] GetArray()
        {
            int[] result = new int[10];
            Console.WriteLine("Enter Ten Numbers");
            for (int i = 0; i < 10; i++)
            {
                result[i] = GetInt("Enter a number 0 or above:");
            }
            return result;
        }

        static bool IsIn(int num, int[] numArray)
        {
            bool result = false;
            int inc = 0;
            do
            {
                if (num == numArray[inc++])
                {
                    result = true;
                }
            } while (inc < numArray.Length);

            return result;
        }

        /// <summary>
        /// getInt()
        /// grabs a non negative integer from the User through the Console
        /// </summary>
        /// <param name="prompt">Takes a String to display to User before readline</param>
        /// <returns>non Negative integer</returns>
        static int GetInt(string prompt)
        {
            int result = -1;
            string response = "";
            do
            {
                Console.Write(prompt);
                response = Console.ReadLine();

            } while (!int.TryParse(response, out result));
            return result;
        }
        static int[] Greatest(int[] myArray)
        {
            int[] result = { -1, -1 };
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > result[0])
                {
                    result[0] = myArray[i];
                    result[1] = i;
                }
            }
            return result;
        }


        static int[] GreatestwithFlags(int[] myArray, bool[] found)
        {
            int[] result = { -1, -1 };
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > result[0] && !found[i])
                {
                    result[0] = myArray[i];
                    result[1] = i;
                }
            }
            return result;
        }
    }
}
