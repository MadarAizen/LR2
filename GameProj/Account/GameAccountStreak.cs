using System.Security;
using GameProj.Game;

namespace GameProj.Account
{
    public class GameAccountStreak : GameAccount
    {
        private int streak;
        public GameAccountStreak(string userName)
            : base(userName)
        {
            streak = 0;
        }

        public override void LoseGame(GameResult result)
        {
            streak = 0;
            base.LoseGame(result);
        }

        public override void WinGame(GameResult result)
        {
            streak++;
            if (streak >= 2)
            {
                base.WinGame(new GameResult(result.GameId, result.Rate + streak * 5, result.Opponent, result.Result));
            }
            else
            {
                base.WinGame(result);
            }
        }
    }
}
