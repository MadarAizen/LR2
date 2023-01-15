using GameProj.Account;
using System;

namespace GameProj.Game
{
    public class StandartGame : AbstractGame
    {
        public override double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rate can not be < 0");
                }
                rate = value;
            }
        }

        public StandartGame(double rate, GameAccount firstPlayer, GameAccount secondPlayer)
            : base(rate, firstPlayer, secondPlayer) { }
    }
}
