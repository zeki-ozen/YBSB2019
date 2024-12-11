/********** STRUCTURED PROGRAMMING ********************/
/********** Dr. Zeki Ozen *****************************/
/********** WEEK 10 - Arithmetic Methods of Math Class */
internal class Program
{
    private static void Main(string[] args)
    {

        // Math Fields
        // E	
        // Represents the natural logarithmic base, specified by the constant, e.
        Console.WriteLine(Math.E); // 2.718281828459045

        // PI
        // Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π.
        Console.WriteLine(Math.PI); // 3.141592653589793

        // Tau
        //Represents the number of radians in one turn, specified by the constant, τ.
        Console.WriteLine(Math.Tau); // 6,283185307179586




        /****** Arithmetic Methods of Math Class ******/
        /**********************************************/

        // Math.Abs() Method
        // Return the absolute value of a specified number
        // abs = number < 0 ? -number : number
        Console.WriteLine(Math.Abs(-40)); // 40
        Console.WriteLine(Math.Abs(40)); // 40


        // Math.BigMul() Method
        // Return the full product of two 32-bit numbers
        // bigMul = a * b
        Console.WriteLine(Math.BigMul(6, -9)); // -54


        // Math.Cbrt() Method
        // Return the cube root of a specified number
        // cbrt = number ^ (1/3)
        Console.WriteLine(Math.Cbrt(64)); // 4


        // Math.Ceiling Method
        // Return the smallest integral value that is greater than or equal to the specified double-precision floating-point number
        Console.WriteLine(Math.Ceiling(8.2)); // 9
        Console.WriteLine(Math.Ceiling(8.6)); // 9
        Console.WriteLine(Math.Ceiling(-5.1)); // -5
        Console.WriteLine(Math.Ceiling(-5.9)); // -5


        // Math.Clamp() Method
        // Return a specified number limited to a range
        // clamp = value < min ? min : (value > max ? max : value)
        Console.WriteLine(Math.Clamp(8, 3, 17)); // 8
        Console.WriteLine(Math.Clamp(-8, 3, 17)); // 3
        Console.WriteLine(Math.Clamp(47, 3, 17)); // 17


        // Math.CopySign() Method
        // Return a value with the magnitude of x and the sign of y
        // copySign = Math.Abs(x) * Math.Sign(y)
        Console.WriteLine(Math.CopySign(8, -3)); // -8
        Console.WriteLine(Math.CopySign(-8, 3)); // 8


        // Math.DivRem() Method
        // Return the quotient and remainder resulting from dividing two numbers
        // quotient = a / b
        // remainder = a % b
        // return (quotient, remainder)
        Console.WriteLine(Math.DivRem(13, 5)); // (2, 3)


        // Math.Exp() Method
        // Return e raised to the specified power
        // e = 2.718281828459045
        // exp = e^value
        Console.WriteLine(Math.Exp(3)); // 20,085536923187668
        Console.WriteLine(Math.Exp(-3)); // 0,0497870683678639


        // Math.Floor() Method
        // Return the largest integral value that is less than or equal to the specified double-precision floating-point number
        Console.WriteLine(Math.Floor(8.2)); // 8
        Console.WriteLine(Math.Floor(8.6)); // 8


        // Math.FusedMultiplyAdd() Method
        // fusedMultiplyAdd = x * y + z
        Console.WriteLine(Math.FusedMultiplyAdd(2, 3, 4)); // 10


        // Math.IEEERemainder() Method
        // Return the remainder resulting from the division of a specified number by another specified number
        // IEEERemainder(a, b) = a − (b x round(a/b))
        // https://learn.microsoft.com/en-us/dotnet/api/system.math.ieeeremainder?view=net-9.0
        Console.WriteLine(Math.IEEERemainder(10, 3)); // 1
        Console.WriteLine(Math.IEEERemainder(5, 3)); // -1


        // Math.Max() Method
        // Return the larger of two numbers
        // max = x > y ? x : y
        Console.WriteLine(Math.Max(8, 3)); // 8
        Console.WriteLine(Math.Max(-8, 3)); // 3


        // Math.MaxMagnitude() Method
        // Return the number with the larger magnitude
        // maxMagnitude = Math.Abs(x) > Math.Abs(y) ? x : y
        Console.WriteLine(Math.MaxMagnitude(8, -3)); // 8
        Console.WriteLine(Math.MaxMagnitude(-8, 3)); // -8


        // Math.Min() Method
        // Return the smaller of two numbers
        // min = x < y ? x : y
        Console.WriteLine(Math.Min(8, 3)); // 3
        Console.WriteLine(Math.Min(-8, 3)); // -8


        // Math.MinMagnitude() Method
        // Return the number with the smaller magnitude
        // minMagnitude = Math.Abs(x) < Math.Abs(y) ? x : y
        Console.WriteLine(Math.MinMagnitude(8, -3)); // -3
        Console.WriteLine(Math.MinMagnitude(-8, 3)); // 3


        // Math.Pow() Method
        // Return a specified number raised to the specified power
        // pow = number ^ exp
        Console.WriteLine(Math.Pow(2, 3)); // 8
        Console.WriteLine(Math.Pow(2.2, 3.2)); // 12,466730713250179


        // Math.ReciprocalEstimate() Method
        // Return an estimate of the reciprocal of a specified number
        // reciprocal = 1 / number
        Console.WriteLine(Math.ReciprocalEstimate(3)); // 0,3333333333333333
        Console.WriteLine(Math.ReciprocalEstimate(5));  // 0,2


        // Math.ReciprocalSqrtEstimate() Method
        // Return an estimate of the reciprocal square root of a specified number
        // reciprocal square root = 1 / sqrt(number)
        Console.WriteLine(Math.ReciprocalSqrtEstimate(3)); // 0,5773502691896257
        Console.WriteLine(Math.ReciprocalSqrtEstimate(5)); // 0,4472135954999579


        // Math.Round() Method
        // Return the integral or decimal value nearest to the specified double-precision floating-point number
        Console.WriteLine(Math.Round(8.2)); // 8
        Console.WriteLine(Math.Round(8.6)); // 9
        Console.WriteLine(Math.Round(-5.1)); // -5
        Console.WriteLine(Math.Round(-5.9)); // -6


        // Math.ScaleB() Method
        // Return a number scaled by a power of 2
        // scaleB = number x 2^exp
        Console.WriteLine(Math.ScaleB(3, 2)); // 12
        Console.WriteLine(Math.ScaleB(3, -2)); // 0,75


        // Math.Sign() Method
        // Return a value indicating the sign of a number
        // -1: The value is less than zero
        // 0: The value is zero
        // 1: The value is greater than zero
        Console.WriteLine(Math.Sign(8)); // 1
        Console.WriteLine(Math.Sign(-8)); // -1
        Console.WriteLine(Math.Sign(0)); // 0

        // Math.Sqrt() Method
        // Return the square root of a specified number
        // sqrt = number ^ (1/2)
        Console.WriteLine(Math.Sqrt(64)); // 8
        Console.WriteLine(Math.Sqrt(-125)); // NaN

        // Math.Truncate() Method
        // Return the integral part of a specified double-precision floating-point number
        Console.WriteLine(Math.Truncate(8.2)); // 8
        Console.WriteLine(Math.Truncate(8.6)); // 8
        Console.WriteLine(Math.Truncate(-5.1)); // -5
        Console.WriteLine(Math.Truncate(-5.9)); // -5

    }
}