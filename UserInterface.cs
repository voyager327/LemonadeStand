using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class UserInterface
    {

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static int GetUserInputInt(string recipeToPick)
        {
            Console.WriteLine();
            string recipeToPick = Console.ReadLine();
            int result = Int32.Parse(Console.ReadLine());
            return 0;

        }
        public static int GetNumberOfRecipe(string recipeToPick)
        { 
            bool userInputIsAnInteger = false;
            int quantityOfRecipe = -1;

            while (!userInputIsAnInteger || quantityOfRecipe < 0)
            {
                Console.WriteLine("How many" + recipeToPick + "would you like to pick?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel0:");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out recipeToPick);
            }
            return recipeToPick;
        }
        public double GetUserInputDouble(string PricePerCup)
        {
            
            Console.WriteLine(Convert.ToDouble(myInt));
            double pricePerCup = Console.ReadLine();
            double result = Int32.Parse(Console.ReadLine());
            return pricePerCup;
        }
        
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
 
        }
    }
}
