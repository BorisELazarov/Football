using Football.Players;
namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Team team = new Team(new Coach("sd", 23),new FootballPlayer[] {
            new Striker("",24,24,184),
                new Striker("",22,21,180),new Striker("",24,24,184),
                new Defender("",22,21,180),new Striker("",24,24,184),
                new Striker("",22,21,180),new Striker("",24,24,184),
                new Goalkeeper("",22,21,180),new Striker("",24,24,184),
                new Striker("",22,21,180),new Striker("",24,24,184),
                new Midfield("",22,21,180),new Striker("",24,24,184),
                new Striker("",22,21,180),new Striker("",24,24,184),
                new Striker("",22,21,180)
            });
        }
    }
}