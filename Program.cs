class Program
{
    static void Main()
    {
        Player player = new Player();
        Player computer = new Player();

        player.Shots = 3;

        Console.WriteLine(player.UserInputConversion());
    }
}