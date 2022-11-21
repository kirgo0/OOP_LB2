using System;

namespace Lb2
{
    public abstract class Match
    {
        public MatchType MatchType { get; protected set; }
        protected static readonly Random Random = new Random();
        public static int MatchIndex = Random.Next(0,100);

        protected int MatchRating { get; set; }
        protected readonly GameAccount P1,P2;

        protected Match(GameAccount p1, GameAccount p2)
        {
            P1 = p1;
            P2 = p2;
            CreateMatch();
        }
        public abstract int GenerateMatchRating();

        public abstract void CreateMatch();

        public int GetMatchRating()
        {
            return MatchRating;
        }
        public GameAccount GetOpponent(GameAccount player)
        {
            return player == P1 ? P2 : P1;
        }

        protected virtual void ChooseWinner()
        {
            if (Random.Next(0, 10) >= 5)
            {
                P1.WinGame(this);
                P2.LoseGame(this);
            }
            else
            {
                P2.WinGame(this);
                P1.LoseGame(this);
            }
        }
        
    }
}