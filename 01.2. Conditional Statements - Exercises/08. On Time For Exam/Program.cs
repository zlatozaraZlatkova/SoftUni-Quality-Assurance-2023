namespace _08._On_Time_For_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine()); 
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            double totalTimeExam = examHour * 60 + examMin;
            double totalTimeArrival = arrivalHour * 60 + arrivalMin;

            double diffTime = Math.Abs(totalTimeExam - totalTimeArrival);

            if (totalTimeExam < totalTimeArrival)
            {
                Console.WriteLine("Late");

                double hours = Math.Floor(diffTime / 60);
                double minutes = diffTime % 60;

                if (diffTime >= 60)
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            } else if (totalTimeExam == totalTimeArrival || totalTimeExam - totalTimeArrival <= 30)
            {
                Console.WriteLine("On time");
                if (diffTime > 0)
                {
                    double minutes = diffTime % 60;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                double hours = Math.Floor(diffTime / 60);
                double minutes = diffTime % 60;

                if (diffTime >= 60)
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }

            

        }
    }
}