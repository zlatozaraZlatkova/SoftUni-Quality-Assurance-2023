namespace _04._Inches_to_Centimeters_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double multiplier = 2.54;
            double result = inches * multiplier;
            Console.WriteLine(result);

        }
    }
}