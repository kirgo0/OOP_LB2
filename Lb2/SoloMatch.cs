using System;

namespace Lb2
{
    public class SoloMatch : Match
    {
        public SoloMatch(GameAccount p1) : base(p1,new GameAccount("Bot" + Random.Next(0,9999)))
        {
        }

        public override int GenerateMatchRating()
        {
            return Random.Next(5, 15);
        }

        protected override void ChooseWinner()
        {
            if (Random.Next(0, 5) >= 2)
            {
                P1.WinGame(this);
            }
            else
            {
                P1.LoseGame(this);
            }
        }

        public override void CreateMatch()
        {
            MatchType = MatchType.Solo;
            MatchIndex++;
            MatchRating = GenerateMatchRating();
            if (MatchRating < 0) throw new Exception("Rating cannot be less then 0");
            ChooseWinner();
        }
    }
}