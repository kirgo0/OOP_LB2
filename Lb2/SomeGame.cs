using System;

namespace Lb2
{
    public enum Status { Win, Lose }
    public class SomeGame
    {
        private Random _random;
        public static int MatchIndex { set; get; }
        
        private GameAccount _p1, _p2;
        
        public SomeGame(GameAccount p1, GameAccount p2)
        {
            _random = new Random();
            MatchIndex = _random.Next(0,100);
            _p1 = p1;
            _p2 = p2;
        }

        public void CreateMatch()
        {
            MatchIndex++;
            int matchRating = _random.Next(5,25);
            if (matchRating < 0) throw new Exception("Rating cannot be less then 0");
            if (_random.Next(0,10) >= 5)
            {
                _p1.WinGame(_p2.UserName,matchRating);
                _p2.LoseGame(_p1.UserName,matchRating);
            }
            else
            {
                _p2.WinGame(_p1.UserName,matchRating);
                _p1.LoseGame(_p2.UserName,matchRating);
            }
        }
    }
}