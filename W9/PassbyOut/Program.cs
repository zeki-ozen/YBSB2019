﻿/********** STRUCTURED PROGRAMMING ****************/
/********** Dr. Zeki Ozen *************************/
/********** WEEK 9 - Methods **********************/

namespace Method_Calling
{
    internal class PassbyOut
    {
        public static void ChangeValue(out int x)
        {
            x = 10;
            Console.WriteLine($"x (Changed) = {x}");
        }

        static void Main(string[] args)
        {
            int x;
            Console.WriteLine($"x (Initially) is unset.");
            ChangeValue(out x);
            Console.WriteLine($"x (Now)= {x}");
            Console.ReadLine();
        }

    }
}