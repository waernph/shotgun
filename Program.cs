class Program
{
    static void Main()
    {
        Player player = new Player(true);
        Player computer = new Player(false);
        Graphics graphics = new Graphics();
        computer.Shots = 0;
        player.Shots = 0;
        computer.IsHuman = false;
        player.IsHuman = true;
        bool gameIsOn = true;

        while (gameIsOn)
        {
            Console.WriteLine(graphics.Prompts(player.Shots));

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
