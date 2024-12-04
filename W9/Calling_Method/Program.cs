﻿/********** STRUCTURED PROGRAMMING ****************/
/********** Dr. Zeki Ozen *************************/
/********** WEEK 9 - Method Calling ***************/

namespace Method_Calling
{
    internal class Program
    {

        private static decimal CalculatePriceWithVat(decimal price, double vatRate = 10.0)
        {
            return Math.Round(price * (1 + (decimal)(vatRate / 100)), 2);
        }

        private static void Main(string[] args)
        {

            // Ask prices of apples and pears
            Console.WriteLine("Enter the price of apples: ");
            decimal applePrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of pears: ");
            decimal pearPrice = decimal.Parse(Console.ReadLine());

            // Ask VAT rate
            Console.WriteLine("Enter the VAT rate: ");
            double vatRate = double.Parse(Console.ReadLine());

            // Calculate the price of apples and pears with VAT
            decimal applePriceWithVat = CalculatePriceWithVat(applePrice, vatRate); // valid
            decimal pearPriceWithVat = CalculatePriceWithVat(pearPrice);    // valid
            decimal grapePriceWithVat = CalculatePriceWithVat(75);          // valid
            decimal xPriceWithVat = CalculatePriceWithVat(price: 100, vatRate: 25);  // valid
            decimal yPriceWithVat = CalculatePriceWithVat(vatRate: 25, price: 100);  // valid
            decimal zPriceWithVat = CalculatePriceWithVat(price: 125);          // valid
                                                                                //decimal qPriceWithVat = CalculatePriceWithVat(vatRate: 125);          // invalid

            // Print the prices of apples and pears with VAT
            Console.WriteLine("The price of apples with VAT is: " + applePriceWithVat);
            Console.WriteLine("The price of pears with VAT is: " + pearPriceWithVat);
            Console.WriteLine("The price of grapes with VAT is: " + grapePriceWithVat);
        }


        // write a mthod that calculate the area of the cylinder
        // the method should take the radius and height as input and return the area of the cylinder
        // the formula for the area of the cylinder is 2 * pi * radius * (radius + height)
        public static double CalculateCylinderArea(double radius, double height)
        {
            return 2 * Math.PI * radius * (radius + height);
        }
    }
}