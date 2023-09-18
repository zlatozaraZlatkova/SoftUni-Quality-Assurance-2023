namespace _09._Numbers_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            string result = "";
            if (inputNum == 1)
            {
                result = "one";
            } else if (inputNum == 2)
            {
                result = "two";
            }
            else if (inputNum == 3)
            {
                result = "three";
            }
            else if (inputNum == 4)
            {
                result = "four";
            }
            else if (inputNum == 5)
            {
                result = "five";
            }
            else if (inputNum == 6)
            {
                result = "six";
            }
            else if (inputNum == 7)
            {
                result = "seven";
            }
            else if (inputNum == 8)
            {
                result = "eight";
            }
            else if (inputNum == 9)
            {
                result = "nine";
            }
            else if (inputNum == 10)
            {
                result = "ten";
            }
            else
            {
                result = "number out of range";
            }

            Console.WriteLine(result);
        }
    }
}