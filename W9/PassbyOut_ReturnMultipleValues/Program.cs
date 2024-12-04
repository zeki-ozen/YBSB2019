﻿/********** STRUCTURED PROGRAMMING ****************/
/********** Dr. Zeki Ozen *************************/
/********** WEEK 9 - Methods **********************/

namespace Method_Calling
{
    internal class PassbyOut_ReturnMultipleValues
    {
        public static void ChangeValues(out int x, out int y)
        {
            x = 10;
            y = -10;
            Console.WriteLine($"The x and y values ​​have been changed x = {x} y = {y}");
        }

        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine($"x (Initially) is unset.");
            Console.WriteLine($"y (Initially) is unset.");
            ChangeValues(out x, out y);
            Console.WriteLine($"x (Now)= {x} y (Now)= {y}");
            Console.ReadLine();
        }

    }
}