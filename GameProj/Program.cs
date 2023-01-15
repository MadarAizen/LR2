using System;
using System.Collections.Generic;
using GameProj.Account;
using GameProj.Enum;
using GameProj.Game;

namespace GameProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userList = new List<GameAccount>();
            var gameList = new List<AbstractGame>();
            userList.Add(new GameAccount("user1"));
            userList.Add(new GameAccountLight("user2"));
            userList.Add(new GameAccountStreak("user2"));
            gameList.Add(GameCreater.CreateStandartGame(100, userList[0], userList[1]));
            gameList.Add(GameCreater.CreateTrainingGame(userList[0], userList[2]));
            gameList.Add(GameCreater.CreateGameRatingForOne(30, userList[0], userList[1], PlayerIndex.Second));
            gameList[0].WinSecondPlayer();
            gameList[1].WinFirstPlayer();
            gameList[2].WinFirstPlayer();
            Console.WriteLine("First player stat: ");
            foreach (var item in userList[0].GetStats())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\nSecond player stat: ");
            foreach (var item in userList[1].GetStats())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\nThird player stat: ");
            foreach (var item in userList[2].GetStats())
            {
                Console.WriteLine(item);
            }
        }
    }
}
