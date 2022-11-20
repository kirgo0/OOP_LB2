using System;
using System.Collections.Generic;

namespace Lb2
{
    public class GameAccount
    {
        private string UserName { get; }
        private int Rating { set; get; }
        private List<MatchResult> _userCareer = new List<MatchResult>();

        public GameAccount(string userName)
        {
            Rating = 1;
            UserName = userName;
        }
        public virtual void WinGame(Match match)
        {
            Rating += match.GetMatchRating();
            _userCareer.Add(new MatchResult(Match.MatchIndex,match.GetOpponent(this).UserName, match.GetMatchRating(),Status.Win));
        }
        
        public void LoseGame(Match match)
        {
            Rating -= match.GetMatchRating();
            if (Rating < 1) Rating = 1;
            _userCareer.Add(new MatchResult(Match.MatchIndex,match.GetOpponent(this).UserName, match.GetMatchRating(),Status.Lose));
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