using System;

namespace missionTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ask the user how many times they would like to roll the dice
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            int rolls = 0;
            //Make sure the user inputs a valid number that is greater than 0
            while (rolls == 0)
            {
                try
                {
                    rolls = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number greater than 0");
                }
            }

            //Instantiate a new instance of the DiceRoller class
            DiceRoller dr = new DiceRoller(rolls);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {dr.Rolls}\n");

            //Call the method that will roll the dice and calculate the number
            dr.RollDice();

            //Looop through the dictionary keys and output the *** representing the total percentage
            foreach(int total in dr.TotalPercents.Keys)
            {
                Console.WriteLine($"{total}: {dr.TotalPercents[total]}");
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
