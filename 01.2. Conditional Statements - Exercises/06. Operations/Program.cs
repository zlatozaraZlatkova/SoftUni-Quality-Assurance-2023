namespace _06._Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());

            string print = "";
            string evenOrOdd = "";
            double sum = 0.00;
           


            switch (operators) 
            {
                case '+':
                    sum = n1 + n2;
                    if (sum % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    print = $"{n1} + {n2} = {sum} - {evenOrOdd}";
                    break;
                case '-':
                    sum = n1 - n2;
                    if (sum % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    print = $"{n1} - {n2} = {sum} - {evenOrOdd}";
                    break;
                case '*':
                    sum = n1 * n2;
                    if (sum % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    print = $"{n1} * {n2} = {sum} - {evenOrOdd}";
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        print = $"Cannot divide {n1} by zero";
                    }
                    else
                    {
                        decimal xN1 = n1;
                        decimal xN2 = n2;
                        decimal result = xN1 / xN2;

                        print = $"{n1} / {n2} = {result:F2}";
                    }
                    break; 
                case '%':
                    if (n2 == 0)
                    {
                        print = $"Cannot divide {n1} by zero";
                    }
                    else
                    {
                        sum = n1 % n2;
                        print = $"{n1} % {n2} = {sum}";
                    }
                    
                    break;
            }

            Console.WriteLine($"{print}");
        }
    }
}
