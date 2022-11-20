using System;

namespace Lb2
{
    public abstract class Match
    {
        protected static Random _random = new Random();
        public static int MatchIndex = _random.Next(0,100);

        protected int MatchRating { get; set; }
        protected GameAccount _p1, _p2; 
        public Match(GameAccount p1, GameAccount p2)
        {
            _p1 = p1;
            _p2 = p2;;
        }
        public abstract int GenerateMatchRating();

        public abstract void CreateMatch();

        public int GetMatchRating()
        {
            return MatchRating;
        }
        public GameAccount GetOpponent(GameAccount player)
        {
            if (player == _p1) return _p2;
            return _p1;
        }

        public virtual void ChooseWinner()
        {
            if (_random.Next(0, 10) >= 5)
            {
                _p1.WinGame(this);
                _p2.LoseGame(this);
            }
            else
            {
                _p2.WinGame(this);
                _p1.LoseGame(this);
            }
        }
        
    }
}