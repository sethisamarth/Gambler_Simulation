using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingSimulation
{
    class Gambler
    {
        public int stake = 100;
        public int bet = 1;
        public int betCount = 0;

        public void Betting()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == 0)
            {
                betCount = betCount + bet;
                Console.WriteLine("Player Won the Game");
                Calculate(stake, true);
            }
            else
            {
                betCount = betCount- bet;
                Console.WriteLine("Player Loose the Game");
                Calculate(stake, false);
            }
        }
        public void Calculate(int stake, Boolean winlose)
        {
            if (winlose)
            {
                stake = stake + stake * 50 / 100;
                Console.WriteLine("Player Won the Game : Your stake is :" + stake);
            }
            else
            {
                stake = stake - stake * 50 / 100;
                Console.WriteLine("Player lose the Game : Your stake is :" + stake);
            }
        }
    }
}
