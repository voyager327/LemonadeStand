using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Game
    {
        Player player;
        public List<Day> days;
        public int currentDay;
        public Random random;

        public Game()
        {
            random = new Random();
            player = new Player();
            days = new List<Day>();
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
