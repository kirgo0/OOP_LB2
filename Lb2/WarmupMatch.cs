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
            MatchIndex++;
            MatchRating = GenerateMatchRating();
            // if (MatchRating < 0) throw new Exception("Rating cannot be less then 0");
            _p1.WinGame(this);
            _p2.WinGame(this);
        }
    }
}