using GameProj.Account;
using GameProj.Enum;

namespace GameProj.Game
{
    public static class GameCreater
    {
        public static AbstractGame CreateStandartGame(double rate, GameAccount firstPlayer, GameAccount secondPlayer)
        {
            return new StandartGame(rate, firstPlayer, secondPlayer);
        }

        public static AbstractGame CreateTrainingGame(GameAccount firstPlayer, GameAccount secondPlayer)
        {
            return new TrainingGame(firstPlayer, secondPlayer);
        }

        public static AbstractGame CreateGameRatingForOne(double rate, GameAccount firstPlayer, GameAccount secondPlayer, PlayerIndex index)
        {
            return new GameRatingForOne(rate, firstPlayer, secondPlayer, index);
        }
    }
}
