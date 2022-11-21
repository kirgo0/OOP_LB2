using System;

namespace Lb2
{
    public class RatedMatch : Match
    {
        public RatedMatch(GameAccount p1, GameAccount p2) : base (p1,p2) {}


        public override int GenerateMatchRating()
        {
            return Random.Next(10, 25);
        }

        public override void CreateMatch()
        {
            MatchType = MatchType.Rated;
            MatchIndex++;
            MatchRating = GenerateMatchRating();
            if (MatchRating < 0) throw new Exception("Rating cannot be less then 0");
            ChooseWinner();
        }
    }
}