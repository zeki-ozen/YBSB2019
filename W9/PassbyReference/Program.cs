﻿/********** STRUCTURED PROGRAMMING ****************/
/********** Dr. Zeki Ozen *************************/
/********** WEEK 9 - Methods **********************/

namespace Method_Calling
{
    internal class PassbyReference
    {

        public static void IncreaseValue(ref int x)
        {
            x += 5;
            Console.WriteLine($"x (Increased) = {x}");
        }

        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"x (Initially) = {x}");
            IncreaseValue(ref x);
            Console.WriteLine($"x (Now) = {x}");
            Console.ReadLine();
        }
    }

}