using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{   
    
    public class Weather
    {
        public string condition;
        public int temperature;
        private List<string> weatherConditions; 
        public Random random;
       
        public Weather()
        {
            random = new Random();
            weatherConditions = new List<string>() { "Sunny", "Rainy", "Cloudy", "Thunderstorms" };
            GenerateCondition();
            GenerateTemperature();
        }
        
        public void GenerateCondition()
        {
            int index = random.Next(weatherConditions.Count);
            condition = weatherConditions[index];
        }

        public void GenerateTemperature()
        {
            if (condition == "Sunny")
            {
                temperature = random.Next(85, 95);
            }
            else if (condition == "Rainy")
            {
                temperature = random.Next(70, 80);
            }
            else if (condition == "Cloudy")
            {
                temperature = random.Next(50, 60);
            }
            else if (condition == "Thunderstorm")
            {
                temperature = random.Next(65, 69);
            }
        }
        
    }
    
} 

                  