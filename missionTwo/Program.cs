using System;

namespace missionTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            int rolls = 0;
            while (rolls == 0)
            {
                try
                {
                    rolls = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

            DiceRoller dr = new DiceRoller(rolls);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {dr.Rolls}\n");

            dr.RollDice();

            foreach(int total in dr.TotalPercents.Keys)
            {
                Console.WriteLine($"{total}: {dr.TotalPercents[total]}");
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
