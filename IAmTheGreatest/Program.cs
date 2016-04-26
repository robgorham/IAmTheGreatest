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
            //int[] someArray = new int[] { 2, 6, 3, 7, 1, 4, 8, 9, 0, 3, 5 };
            int[] someArray = GetArray();
            Console.WriteLine("Greatest in array is:" + Greatest(someArray));
            Console.ReadLine();
        }

        static int[] GetArray()
        {
            int[] result = new int[10];
            for(int i = 0; i < 10; i++)
            {
                result[i] = GetInt("Enter a number above O");
            }
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
        static int Greatest(int[] myArray)
        {
            int temp = -1;
            foreach (int element in myArray)
            {
                if (element > temp)
                    temp = element;
            }
            return temp;
        }
    }
}
