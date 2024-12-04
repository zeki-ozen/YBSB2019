﻿/********** STRUCTURED PROGRAMMING ****************/
/********** Dr. Zeki Ozen *************************/
/********** WEEK 9 - Methods **********************/

namespace PassbyParams
{
    internal class Program
    {
        public static void ProcessValues(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine($"{i}. argument: {numbers[i]}");
        }

        static void Main(string[] args)
        {
            ProcessValues(4, 12, 2024);
            Console.ReadLine();
        }

    }
}
