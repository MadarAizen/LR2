using GameProj.Game;
using System;

namespace GameProj.Account
{
    public class GameAccountLight : GameAccount
    {
        public GameAccountLight(string userName)
            : base(userName) { }

        public override void LoseGame(GameResult result)
        {
            GamesCount++;
            if (CurrentRating - result.Rate >= 1)
            {
                CurrentRating -= (result.Rate/2);
            }
            else
            {
                CurrentRating = 1;
            }
            GameResults.Add(result);
        }
    }
}
