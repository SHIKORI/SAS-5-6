public class Program
{
    public static void Main(string[] args)
    {
        double r, AREA;
        const double Pi = 3.14;
        Console.WriteLine("Calculation of the area and circumference of the circle");
        Console.Write("Enter the radius of circle: ");
        r = Convert.ToDouble(Console.ReadLine());
        AREA = Pi * r * r;
        Console.WriteLine("The area of circle is {0} when radius is {1}", AREA, r);
        Console.WriteLine("The circumference of circle is {0}", 2 * Pi * r);

    }
}