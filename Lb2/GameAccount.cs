using System;
using System.Collections.Generic;

namespace Lb2
{
    public class GameAccount
    {
        private string UserName { get;  }
        protected int Rating { set; get; }
        protected List<MatchResult> UserCareer = new List<MatchResult>();

        public GameAccount(string userName)
        {
            Rating = 1;
            UserName = userName;
        }
        
        public virtual void WinGame(Match match)
        {
            Rating += match.GetMatchRating();
            UserCareer.Add(new MatchResult(match.MatchType, Match.MatchIndex,match.GetOpponent(this).UserName, match.GetMatchRating(),Status.Win));
        }
        
        public void LoseGame(Match match)
        {
            Rating -= match.GetMatchRating();
            if (Rating < 1) Rating = 1;
            UserCareer.Add(new MatchResult(match.MatchType, Match.MatchIndex,match.GetOpponent(this).UserName, match.GetMatchRating(),Status.Lose));
        }

        public void PrintStats()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Profile of player " + UserName);
            Console.WriteLine("Count of matches: " + UserCareer.Count);
            Console.WriteLine("Rating: " + Rating + "\nMatch List:");
            PrintMatchList();
            Console.WriteLine("==========================================");
        }

        protected virtual void PrintMatchList()
        {
            foreach (var matchResult in UserCareer)
            {
                Console.Write("Match Type: " + (matchResult.MType == MatchType.Rated ? "Rated" : 
                    matchResult.MType == MatchType.Warmup ? "Warmup" : "Solo") + " | ");
                Console.WriteLine("Match index: " + matchResult.MatchIndex);
                Console.Write("Your opponent: " + matchResult.OpName);
                Console.Write(" | Match Rating: " + matchResult.MatchRating);
                Console.Write(matchResult.PStatus == Status.Lose ? " | You Lose" : " | You Win");
                Console.WriteLine();
            }
        }
    }
}