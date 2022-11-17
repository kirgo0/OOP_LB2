using System;
using System.Collections.Generic;

namespace Lb2
{
    public class GameAccount
    {
        public string UserName { get; }
        private int Rating { set; get; }
        private List<MatchResult> _userCareer = new List<MatchResult>();

        public GameAccount(string userName)
        {
            UserName = userName;
        }
        public void WinGame(string opponentName, int matchRating)
        {
            Rating += matchRating;
            _userCareer.Add(new MatchResult(SomeGame.MatchIndex, opponentName,matchRating,Status.Win));
        }
        
        public void LoseGame(string opponentName, int matchRating)
        {
            Rating -= matchRating;
            if (Rating < 1) Rating = 1;
            _userCareer.Add(new MatchResult(SomeGame.MatchIndex, opponentName,matchRating,Status.Lose));
        }

        public void GetStats()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Profile of player " + UserName);
            Console.WriteLine("Count of matches: " + _userCareer.Count);
            Console.WriteLine("Rating: " + Rating + "\nMatch List:");
            foreach (var matchResult in _userCareer)
            {
                Console.WriteLine("Match index: " + matchResult.MatchIndex);
                Console.Write("Your opponent: " + matchResult.OpName);
                Console.Write(" | Match Rating: " + matchResult.MatchRating);
                Console.Write(matchResult.PStatus == Status.Lose ? "| You Lose" : "| You Win");
                Console.WriteLine();
            }
            Console.WriteLine("==========================================");
        }
    }
}