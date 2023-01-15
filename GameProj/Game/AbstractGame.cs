using System;
using GameProj.Account;
using GameProj.Enum;

namespace GameProj.Game
{
    public abstract class AbstractGame
    {
        private static int amount = 0;

        public int Id { get; protected set; }

        protected double rate;

        public abstract double Rate { get; set; }

        public GameAccount FirstPlayer { get; protected set; }

        public GameAccount SecondPlayer { get; protected set; }

        public AbstractGame(double rate, GameAccount firstPlayer, GameAccount secondPlayer)
        {
            amount += 1;
            Id = amount;
            Rate = rate;
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
        }

        public virtual void WinFirstPlayer()
        {
            FirstPlayer.WinGame(new GameResult(Id, Rate, SecondPlayer, Result.Win));
            SecondPlayer.LoseGame(new GameResult(Id, Rate, FirstPlayer, Result.Lose));
        }

        public virtual void WinSecondPlayer()
        {
            FirstPlayer.LoseGame(new GameResult(Id, Rate, SecondPlayer, Result.Lose));
            SecondPlayer.WinGame(new GameResult(Id, Rate, FirstPlayer, Result.Win));
        }
    }
}
