using GameProj.Account;
using System;

namespace GameProj.Game
{
    public class TrainingGame : AbstractGame
    {
        public override double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                if (value != 0)
                {
                    throw new ArgumentException("Training rate can only be equal to 0");
                }
                rate = value;
            }
        }
        public TrainingGame(GameAccount firstPlayer, GameAccount secondPlayer)
            : base(0, firstPlayer, secondPlayer) { }
    }
}
