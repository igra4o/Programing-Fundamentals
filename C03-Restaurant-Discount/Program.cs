using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double price = 1;
            double pricePerPerson = 1;

            if (countOfPeople <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                
                if (package == "Normal")
                {
                    price = 2500 + 500;
                    pricePerPerson = (price - (price * 0.05)) / countOfPeople;
                }
                else if (package == "Gold")
                {
                    price = 2500 + 750;
                    pricePerPerson = (price - (price * 0.10)) / countOfPeople;
                }
                else if (package == "Platinum")
                {
                    price = 2500 + 1000;
                    pricePerPerson = (price - (price * 0.15)) / countOfPeople;
                }
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            if (countOfPeople > 50 && countOfPeople <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");

                if (package == "Normal")
                {
                    price = 5000 + 500;
                    pricePerPerson = (price - (price * 0.05)) / countOfPeople;
                }
                else if (package == "Gold")
                {
                    price = 5000 + 750;
                    pricePerPerson = (price - (price * 0.10)) / countOfPeople;
                }
                else if (package == "Platinum")
                {
                    price = 5000 + 1000;
                    pricePerPerson = (price - (price * 0.15)) / countOfPeople;
                }
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            if (countOfPeople > 100 && countOfPeople <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");

                    if (package == "Normal")
                {
                    price = 7500 + 500;
                    pricePerPerson = (price - (price * 0.05)) / countOfPeople;
                }
                else if (package == "Gold")
                {
                    price = 7500 + 750;
                    pricePerPerson = (price - (price * 0.10)) / countOfPeople;
                }
                else if (package == "Platinum")
                {
                    price = 7500 + 1000;
                    pricePerPerson = (price - (price * 0.15)) / countOfPeople;
                }
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }

            else if (countOfPeople < 1 || countOfPeople > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
