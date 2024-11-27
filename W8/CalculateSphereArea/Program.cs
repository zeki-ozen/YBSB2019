
internal class Program
{

    public static double CalculateSphereArea(double r)
    {
        return (4.0 / 3.0) * Math.PI * r * r;
    }

    public static void PrintOutArea(double area)
    {
        Console.WriteLine($"The area of the Sphere is {area}");
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Type r of the Sphere");
        double r = double.Parse(Console.ReadLine());

        double area = CalculateSphereArea(r);
        //Console.WriteLine($"Area of the sphere is {area}");
        PrintOutArea(area);

    }
}