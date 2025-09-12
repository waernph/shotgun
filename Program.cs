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
            Console.WriteLine($"Spelare 1 skott: {player.Shots}");
            Console.Clear();
            computer.PlayerChoice();
            Console.WriteLine($"Spelare 2 skott: {computer.Shots}");
            

            if (player.GameOver())
            {
                Console.WriteLine("Spelare 2 vann!");
                gameIsOn = false;
            }
            else if (computer.GameOver())
            {
                Console.WriteLine("Spelare 1 vann!");
                gameIsOn = false;
            }
        }
        Console.ReadLine();
    }
}
