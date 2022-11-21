using System;

namespace Lb2
{
    public class WarmupMatch : Match
    {
        public WarmupMatch(GameAccount p1, GameAccount p2) : base (p1,p2) { }
        
        public override int GenerateMatchRating()
        {
            return 0;
        }

        public override void CreateMatch()
        {
            MatchType = MatchType.Warmup;
            MatchIndex++;
            MatchRating = GenerateMatchRating();
            ChooseWinner();
        }
    }
}