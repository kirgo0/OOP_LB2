namespace Lb2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GameAccount p1 = new GameAccount("Kirgo");
            GameAccount p2 = new GameAccount("Solify");
            Game myGame = new Game(p1, p2);
            myGame.StartWarmupMatch();
            myGame.StartWarmupMatch();
            myGame.StartWarmupMatch();
            myGame.StartWarmupMatch();
            myGame.StartRatedMatch();
            myGame.StartWarmupMatch();
            myGame.StartWarmupMatch();
            p1.GetStats();
            p2.GetStats();
        }
    }
}