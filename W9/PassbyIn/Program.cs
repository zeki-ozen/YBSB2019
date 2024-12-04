﻿/********** STRUCTURED PROGRAMMING ****************/
/********** Dr. Zeki Ozen *************************/
/********** WEEK 9 - Methods **********************/

namespace Method_Calling
{
    internal class PassbyIn
    {
        public static void IncreaseValue(in int x)
        {
            // x = 5; // This line will cause a compile-time error.
            // x += 5; // This line will cause a compile-time error.
            Console.WriteLine($"x (Not Increased) = {x}");
        }

        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"x (Initially) = {x}");
            IncreaseValue(in x);
            Console.WriteLine($"x (Now)= {x}");
            Console.ReadLine();
        }
    }
}