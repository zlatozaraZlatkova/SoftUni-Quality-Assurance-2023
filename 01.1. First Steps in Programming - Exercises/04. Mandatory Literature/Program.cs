namespace _04._Mandatory_Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPages = int.Parse(Console.ReadLine());
            int readedPagePerHour = int.Parse(Console.ReadLine());
            int neededDays = int.Parse(Console.ReadLine());

            int neededHoursPerDay = (numOfPages / readedPagePerHour) / neededDays;
            Console.WriteLine(neededHoursPerDay);

        }
    }
}