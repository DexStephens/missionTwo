﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace missionTwo
{
    public class DiceRoller
    {
        public int Rolls { get; set; }
        public Dictionary<int, string> TotalPercents = new Dictionary<int, string>(){ { 2, "" }, { 3, "" }, { 4, "" }, { 5, "" }, { 6, "" }, { 7, "" }, { 8, "" }, { 9, "" }, { 10, "" }, { 11, "" }, { 12, "" } };

        public DiceRoller(int rolls)
        {
            Rolls = rolls;
        }

        public void RollDice()
        {
            Dictionary<int, int> totalRolls = new Dictionary<int, int>() { { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, { 10, 0 }, { 11, 0 }, { 12, 0 } };
            for(int i = 0; i < Rolls; i++)
            {
                int diceOne = RandomNumberGenerator.GetInt32(1, 7);
                int diceTwo = RandomNumberGenerator.GetInt32(1, 7);
                int total = diceOne + diceTwo;

                totalRolls[total] = totalRolls[total] + 1;
            }
            CalculatePercents(totalRolls);
        }

        public void CalculatePercents(Dictionary<int, int> totalRolls)
        {
            foreach(int total in totalRolls.Keys)
            {
                double percent = Math.Round(((double)totalRolls[total] / (double)Rolls) * 100);
                TotalPercents[total] = String.Concat(Enumerable.Repeat("*", Convert.ToInt32(percent)));
            }
        }
    }
}
