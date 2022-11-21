using System;

namespace Lb2
{
    public class PremLightAccount : GameAccount
    {
        public PremLightAccount(string userName) : base(userName) {}
        public override void WinGame(Match match)
        {
            var bonus = RatingHandler(match.GetMatchRating());
            Rating += match.GetMatchRating() + bonus;
            UserCareer.Add(new MatchResult(match.MatchType, Match.MatchIndex,match.GetOpponent(this).UserName, match.GetMatchRating() + bonus,Status.Win));
        }

        private int RatingHandler(int rating)
        {
            if (UserCareer.Count == 0) return 0;
            int i = UserCareer.Count - 1, finalRating = 0;
            double multiplier = 0;
            while (i >= 0)
            {
                if (UserCareer[i].PStatus == Status.Win) multiplier += 0.1;
                else
                {
                    multiplier = 0;
                    break;
                }
                i--;
            }

            if (multiplier > 0.7) multiplier = 0.7;
            finalRating += Convert.ToInt32(rating * 0.25) + Convert.ToInt32(rating * multiplier);
            return finalRating;
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
                    (matchResult.MatchRating > 0 ? ") LIGHT PREMIUM BONUS" : "") + " | You Win" : 
                    " | Match Rating: " + matchResult.MatchRating + " | You Lose") ;
                Console.WriteLine();
            }
        }
    }
}