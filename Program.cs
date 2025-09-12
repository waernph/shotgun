class Program
{
    static void Main()
    {
        Player player = new Player(true);
        Player computer = new Player(false);
        computer.Shots = 0;
        player.Shots = 0;
        computer.IsHuman = false;
        player.IsHuman = true;
        bool gameIsOn = true;

        while (gameIsOn)
        {
            Console.WriteLine(player.PlayerChoice());
            Console.WriteLine(player.Shots);
        }
    }
}
