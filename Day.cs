using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    
    public class Day
    {

        public Weather weather;
        public List<Customer> customers;
        public Random random;

        public Day()
        {
            random = new Random();
            weather = new Weather();
            customers = new List<Customer>();
        }
        public int GenerateAmountOfCustomers()
        {
            int amountOfCustomers = 0;

            if (weather.condition == "Sunny")
            {
                amountOfCustomers = random.Next(60, 70);
            }
            else if (weather.condition == "Rainy")
            {
                amountOfCustomers = random.Next(30, 35);
            }
            else if (weather.condition == "Cloudy")
            {
                amountOfCustomers = random.Next(25, 38);
            }
            else if (weather.condition == "Thunderstorm")
            {
                amountOfCustomers = random.Next(20, 3);
            }
            return amountOfCustomers;
        }

        public void AddCreateCustomers(int numberOfCustomers)
        {
            // Look at the inventory class. How are things put into the inventory?
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customers customer = new Customers();
                customers.Add(customers);
            }
        }
        public void AddDaysToWeek(int numberOfDays)
        {

            for (int i = 0; i < numberOfDays; i++)
            {
                Day days = new Day();
                days.Add(days);
            }

        }
    }
}   

