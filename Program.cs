class Program
{
    static void Main()
    {
        Player player1 = new Player(true);
        Player player2 = new Player(false);
        Graphics gfx = new Graphics();
        player2.Shots = 0;
        player1.Shots = 0;
        bool gameIsOn = true;

        while (gameIsOn)
        {
            int player1Shots = player1.Shots;
            int player2Shots = player2.Shots;
            Console.Clear();

            gfx.ShotgunLogo();
            gfx.ShotsLeft(player1Shots, player2Shots);
            player1.PlayerChoice();
            player2.PlayerChoice();

            if (player1.GameOver())
            {
                Console.WriteLine("Spelare 1 vann!");
                Console.WriteLine("Vill du spela igen? Y/N");
                char UserInput = char.ToLower(Console.ReadKey().KeyChar);
                if (UserInput == 'n')
                {
                    gameIsOn = false;
                }
                else
                {
                    gameIsOn = true;
                    player1.Shots = 0;
                    player2.Shots = 0;
                }
            }
            if (player2.GameOver())
            {
                Console.WriteLine("Spelare 2 vann!");
                Console.WriteLine("Vill du spela igen? Y/N");
                char UserInput = char.ToLower(Console.ReadKey().KeyChar);
                if (UserInput == 'n')
                {
                    gameIsOn = false;
                }
                else
                {
                    gameIsOn = true;
                    player1.Shots = 0;
                    player2.Shots = 0;
                }
            }
        }
    }
}
