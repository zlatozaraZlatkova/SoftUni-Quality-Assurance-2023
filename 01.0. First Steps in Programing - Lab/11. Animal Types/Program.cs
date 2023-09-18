namespace _11._Animal_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string result = "";
            switch (animal)
            {
                case "dog": result = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake": result = "reptile";
                    break;
                default: result = "unknown";
                    break;
                
            }
            Console.WriteLine(result);
        }
    }
}