namespace src;

class FootballPlayer
{
    string name;

    public FootballPlayer(string name)
    {
        this.name = name;
    }

    public void ShootBall()
    {
        Console.WriteLine("{0} shoots the ball.", this.name);
    }

}

class GoalKeeper : FootballPlayer
{
    public GoalKeeper(string name) : base(name)
    {
    }

    public void TakeBall()
    {
        Console.WriteLine("{0} takes the ball in his hands.", this.name);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        GoalKeeper goalKeeper = new GoalKeeper("Hugo Lloris");

        goalKeeper.TakeBall();  // Return : "Hugo Lloris takes the ball in his hands."
        goalKeeper.ShootBall(); // Return : "Hugo Lloris shoots the ball."
    }
}
