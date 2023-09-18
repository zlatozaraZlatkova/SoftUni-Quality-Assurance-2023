namespace _06._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade < 5.50)
            {
                Console.WriteLine("Not excellent.");
            } else if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            
            
        }
    }
}