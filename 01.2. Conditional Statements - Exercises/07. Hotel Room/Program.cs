namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countOfNights = int.Parse(Console.ReadLine());

            double priceStudio = 0.00;
            double priceApartment = 0.00;

            switch (month)
            {
                case "May": 
                case "October":
                    priceStudio = countOfNights * 50;
                    priceApartment = countOfNights * 65;

                    if (countOfNights > 7 && countOfNights <= 14)
                    {
                        priceStudio *= 0.95;
                        
                    } else if (countOfNights > 14)
                    {
                        priceStudio *= 0.70;
                        priceApartment *= 0.90;
                    }
                    break;

                case "June": 
                case "September":
                    priceStudio = countOfNights * 75.20;
                    priceApartment = countOfNights * 68.70;

                    if (countOfNights > 14)
                    {
                        priceStudio *= 0.80;
                        priceApartment *= 0.90;
                    }
                    break;

                case "July": 
                case "August":
                    priceStudio = countOfNights * 76;
                    priceApartment = countOfNights * 77;

                    if (countOfNights > 14)
                    {
                        priceApartment *= 0.90;
                    }
                    break;


            }

            Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
        }

    }
}