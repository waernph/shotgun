class Graphics
{
    public void ShotgunLogo()
    {
        Console.WriteLine(
            @"
     ____  _   _  ___ _____ ____ _   _ _   _ _
    / ___|| | | |/ _ \_   _/ ___| | | | \ | | |
    \___ \| |_| | | | || || |  _| | | |  \| | |
     ___) |  _  | |_| || || |_| | |_| | |\  |_|
    |____/|_| |_|\___/ |_| \____|\___/|_| \_(_) 
    "
        );
    }

    public void YouWin()
    {
        Console.WriteLine(
            @"
    __   _____  _   _  __        _____ _   _ _ 
    \ \ / / _ \| | | | \ \      / /_ _| \ | | |
     \ V / | | | | | |  \ \ /\ / / | ||  \| | |
      | || |_| | |_| |   \ V  V /  | || |\  |_|
      |_| \___/ \___/     \_/\_/  |___|_| \_(_)"
        );
    }

    public void YouLost()
    {
        Console.WriteLine(
            @"
    __   _____  _   _   _     ___  ____ _____ _ 
    \ \ / / _ \| | | | | |   / _ \/ ___|_   _| |
     \ V / | | | | | | | |  | | | \___ \ | | | |
      | || |_| | |_| | | |__| |_| |___) || | |_|
      |_| \___/ \___/  |_____\___/|____/ |_| (_)"
        );
    }

    public void ShotsLeft(int player1Shots, int player2Shots)
    {
        Console.WriteLine($"Player 1: {player1Shots} skott Player 2: {player2Shots} skott");
    }

    public void NotValidInput(int choice)
    {
        choice -= 100;
        string[] errorMessage =
        [
            "Du har inga skott, försök inte!",
            "Valet finns inte. Försök igen",
            "Du måste ha minst 3 skott",
        ];
        Console.WriteLine(choice);
        Console.WriteLine(errorMessage[choice]);
    }
}
