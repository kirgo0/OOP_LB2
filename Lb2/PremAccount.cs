using System;

namespace Lb2
{
    public class PremAccount : GameAccount
    {
        public PremAccount(string userName) : base(userName) {}

        public override void WinGame(Match match)
        {
            Rating += match.GetMatchRating();
            base.WinGame(match);
        }

        protected override void PrintMatchList()
        {
            foreach (var matchResult in UserCareer)
            {
                Console.Write("Match Type: " + (matchResult.MType == MatchType.Rated ? "Rated" : 
                    matchResult.MType == MatchType.Warmup ? "Warmup" : "Solo") + " | ");
                Console.WriteLine("Match index: " + matchResult.MatchIndex);
                Console.Write("Your opponent: " + matchResult.OpName); 
                Console.Write(matchResult.PStatus == Status.Win ? 
                    " | Match Rating:" + (matchResult.MatchRating > 0 ? " (" : " ") + matchResult.MatchRating + 
                    (matchResult.MatchRating > 0 ? ") x2 PREMIUM = " + matchResult.MatchRating*2 : "") + " | You Win" : 
                    " | Match Rating: " + matchResult.MatchRating + " | You Lose") ;
                Console.WriteLine();
            }
        }
    }
}
