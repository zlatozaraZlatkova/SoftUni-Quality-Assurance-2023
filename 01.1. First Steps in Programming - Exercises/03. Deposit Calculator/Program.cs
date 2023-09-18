namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int depositPeriod = int.Parse(Console.ReadLine());
            double annualRate = double.Parse(Console.ReadLine());
            double amount = depositAmount + depositPeriod * (depositAmount * annualRate /100) / 12;

            Console.WriteLine(amount);
        }
    }
}