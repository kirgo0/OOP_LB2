using System;

namespace Lb2
{
    public class Game
    {
        
        private GameAccount _p1, _p2;
        
        public Game(GameAccount p1, GameAccount p2)
        {
            _p1 = p1;
            _p2 = p2;
        }

        public void StartWarmupMatch()
        {
            Match match = new WarmupMatch(_p1,_p2);
            match.CreateMatch();
        }

        public void StartRatedMatch()
        {
            Match match = new RatedMatch(_p1,_p2);
            match.CreateMatch();
        }

        public void StartSoloMatch(GameAccount p1)
        {
            Match match = new SoloMatch(p1);
            match.CreateMatch();
        }
    }
}