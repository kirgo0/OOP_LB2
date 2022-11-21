using System;

namespace Lb2
{
    public class Game
    {
        public static Match StartWarmupMatch(GameAccount p1, GameAccount p2)
        {
            return new WarmupMatch(p1, p2);
        }

        public static Match StartRatedMatch(GameAccount p1, GameAccount p2)
        {
            return new RatedMatch(p1,p2);
        }

        public static Match StartSoloMatch(GameAccount p1)
        {
            return new SoloMatch(p1);
        }
    }
}