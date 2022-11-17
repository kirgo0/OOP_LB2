namespace Lb2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GameAccount p1 = new GameAccount("Kirgo");
            GameAccount p2 = new GameAccount("Solify");
            SomeGame myGame = new SomeGame(p1, p2);
            myGame.CreateMatch();
            myGame.CreateMatch();
            myGame.CreateMatch();
            myGame.CreateMatch();
            myGame.CreateMatch();
            myGame.CreateMatch();
            myGame.CreateMatch();
            p1.GetStats();
            p2.GetStats();
        }
    }
}