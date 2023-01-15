using GameProj.Account;
using GameProj.Enum;
using System;

namespace GameProj.Game
{
    public class GameRatingForOne : AbstractGame
    {
        public PlayerIndex PlayerForRate { get; private set; }

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
        public GameRatingForOne(double rate, GameAccount firstPlayer, GameAccount secondPlayer, PlayerIndex playerForRate)
            : base(rate, firstPlayer, secondPlayer) 
        {
            PlayerForRate = playerForRate;
        }

        public override void WinFirstPlayer()
        {
            switch (PlayerForRate)
            {
                case PlayerIndex.First:
                    {
                        FirstPlayer.WinGame(new GameResult(Id, Rate, SecondPlayer, Result.Win));
                        SecondPlayer.LoseGame(new GameResult(Id, 0, FirstPlayer, Result.Lose));
                        break;
                    }
                case PlayerIndex.Second:
                    {
                        FirstPlayer.WinGame(new GameResult(Id, 0, SecondPlayer, Result.Win));
                        SecondPlayer.LoseGame(new GameResult(Id, Rate, FirstPlayer, Result.Lose));
                        break;
                    }
            }
        }

        public override void WinSecondPlayer()
        {
            switch (PlayerForRate)
            {
                case PlayerIndex.First:
                    {
                        FirstPlayer.LoseGame(new GameResult(Id, Rate, SecondPlayer, Result.Win));
                        SecondPlayer.WinGame(new GameResult(Id, 0, FirstPlayer, Result.Lose));
                        break;
                    }
                case PlayerIndex.Second:
                    {
                        FirstPlayer.LoseGame(new GameResult(Id, 0, SecondPlayer, Result.Win));
                        SecondPlayer.WinGame(new GameResult(Id, Rate, FirstPlayer, Result.Lose));
                        break;
                    }
            }
        }
    }
}
