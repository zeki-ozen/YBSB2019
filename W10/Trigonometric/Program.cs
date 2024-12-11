/********** STRUCTURED PROGRAMMING ************************/
/********** Dr. Zeki Ozen *********************************/
/********** WEEK 10 - Trigonometric Methods of Math Class */
namespace W10_Trigonometric
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double angle = 60;
            double radians = angle * Math.PI / 180;


            // Math.Cos() Method
            // Return the cosine of the specified angle
            // cos = adjacent / hypotenuse
            Console.WriteLine(Math.Cos(radians)); // 0.5000000000000001


            // Math.Sin() Method
            // Return the sine of the specified angle
            // sin = opposite / hypotenuse
            Console.WriteLine(Math.Sin(radians)); // 0.8660254037844386


            // Math.Tan() Method
            // Return the tangent of the specified angle
            // tan = opposite / adjacent
            Console.WriteLine(Math.Tan(radians)); // 1.7320508075688767


            // Math.SinCos() Method
            // Return the sine and cosine of the specified angle
            // sin = opposite / hypotenuse
            // cos = adjacent / hypotenuse
            (double sin, double cos) = Math.SinCos(radians);
            Console.WriteLine(sin); // 0.8660254037844385
            Console.WriteLine(cos); // 0.5000000000000003



            // Math.Acos() Method
            // Return the angle whose cosine is the specified number
            // acos = cos^-1
            Console.WriteLine(Math.Acos(0.5)); // 1.0471975511965979


            // Math.Asin() Method
            // Return the angle whose sine is the specified number
            // asin = sin^-1
            Console.WriteLine(Math.Asin(0.8660254037844386)); // 1.0471975511965979


            // Math.Atan() Method
            // Return the angle whose tangent is the specified number
            // atan = tan^-1
            Console.WriteLine(Math.Atan(1.7320508075688767)); // 1.0471975511965979


            // Math.Atan2() Method
            // Return the angle whose tangent is the quotient of two specified numbers
            // atan2 = tan^-1(y / x)
            Console.WriteLine(Math.Atan2(3, 2)); // 0.982793723247329


            // Math.Cosh() Method
            // Return the hyperbolic cosine of the specified angle
            // cosh = (e^x + e^-x) / 2
            Console.WriteLine(Math.Cosh(radians)); // 1.600286857702386


            // Math.Sinh() Method
            // Return the hyperbolic sine of the specified angle
            // sinh = (e^x - e^-x) / 2
            Console.WriteLine(Math.Sinh(radians)); // 1.2493670504831844


            // Math.Tanh() Method
            // Return the hyperbolic tangent of the specified angle
            // tanh = sinh / cosh
            Console.WriteLine(Math.Tanh(radians)); // 0.5463024898437905


            // Math.Acosh() Method
            // Return the angle whose hyperbolic cosine is the specified number
            // acosh = cosh^-1
            Console.WriteLine(Math.Acosh(1.600286857702386)); // 1.0471975511965979


            // Math.Asinh() Method
            // Return the angle whose hyperbolic sine is the specified number
            // asinh = sinh^-1
            Console.WriteLine(Math.Asinh(1.2493670504831844)); // 1.0471975511965979


            // Math.Atanh() Method
            // Return the angle whose hyperbolic tangent is the specified number
            // atanh = tanh^-1
            Console.WriteLine(Math.Atanh(0.5463024898437905)); // 1.0471975511965979



        }
    }
}
