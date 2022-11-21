namespace Lb2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GameAccount p1 = new PremLightAccount("Kirgo");
            GameAccount p2 = new PremAccount("Solify");
            Game myGame = new Game(p1, p2);
            // myGame.StartWarmupMatch();
            // myGame.StartWarmupMatch();
            // myGame.StartWarmupMatch();
            // myGame.StartRatedMatch();
            // myGame.StartRatedMatch();
            // myGame.StartWarmupMatch();
            // myGame.StartRatedMatch();
            // myGame.StartSoloMatch(p1);
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();
            myGame.StartRatedMatch();

            p1.PrintStats();
            p2.PrintStats();
        }
    }
}