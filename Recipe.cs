using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
     public class Recipe
    {
         public int amountOfLemons;
         public int amountOfSugarCubes;
         public int amountOfIceCubes;
         public double pricePerCup;
    
        public Recipe()
        {
             amountOfLemons = 0;
             amountOfSugarCubes = 0;
             amountOfIceCubes = 0;
             pricePerCup = 0;

        }
        public void SetRecipe()
        {
            UserInterface.DisplayMessage("Please set your recipe.");
            amountOfIceCubes = UserInterface.GetUserInputInt("How many ice cubes would you like to use per pitcher.");
            amountOfLemons = UserInterface.GetUserInputInt("How many lemons  would you like to use per pitcher.");
            amountOfSugarCubes = UserInterface.GetUserInputInt("How many sugarCubes would you like to use per pitcher.");
            
        }
        public double PricePerCup()
        {
            UserInterface.DisplayMessage("Please set your recipe.");
            pricePerCup = UserInterface.GetUserInputInt("How Much would you charge per cup.");
            return pricePerCup;
        }
     }
    
}
