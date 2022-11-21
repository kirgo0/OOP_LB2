namespace Lb2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GameAccount p1 = new GameAccount("Chokopie");
            GameAccount p2 = new PremLightAccount("Kirgo");
            GameAccount p3 = new PremAccount("Solify");
            Game.StartRatedMatch(p1, p2);
            Game.StartWarmupMatch(p2, p3);
            Game.StartRatedMatch(p2, p3);
            Game.StartSoloMatch(p1);
            Game.StartSoloMatch(p2);
            Game.StartSoloMatch(p3);
            Game.StartRatedMatch(p1, p3);
            Game.StartRatedMatch(p1, p3);
            Game.StartWarmupMatch(p1, p2);
            Game.StartRatedMatch(p1, p2);
            p1.PrintStats();
            p2.PrintStats();
            p3.PrintStats();
        }
    }
}