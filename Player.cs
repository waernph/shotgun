class Player
{
    private int shots = 0;
    public int Shots
    {
        get { return shots; }
        set { shots = value; }
    } //Property för skott
    public bool IsHuman; //Property för om spelare är människa eller dator.

    //För att avgöra om spelaren ska få fråga eller ska slumpas fram.
    private char UserInput { get; set; } //Property för att ta emot svar från spelare

    public Player(bool isHuman)
    {
        IsHuman = isHuman;
    }

    private char PlayerInput()
    {
        if (Shots < 3)
        {
            Console.WriteLine("Välj (S)kjut, (L)adda eller (B)locka");
            UserInput = char.ToLower(Console.ReadKey().KeyChar);
        }
        else
        {
            Console.WriteLine("Välj (S)kjut, (L)adda, (B)locka eller (H)agelgevär");
            UserInput = char.ToLower(Console.ReadKey().KeyChar);
        }
        return UserInput;
    }

    public int PlayerChoice()
    {
        if (IsHuman)
        {
            UserInput = PlayerInput();
        }
        else
        {
            UserInput = PlayerRandom();
        }

        if (UserInput == 's')
        {
            Shots -= 1;
            return 1;
        }
        else if (UserInput == 'l')
        {
            Shots += 1;
            return 2;
        }
        else if (UserInput == 'b')
        {
            return 3;
        }
        else if (UserInput == 'h' && Shots >= 3)
        {
            return 4;
        }
        else
        {
            return 0;
        }
    }

    private char PlayerRandom() //Returnerar en char för
    {
        string choices = "ssllbbhh";
        Random rnd = new Random();
        if (Shots == 0)
        {
            int index = rnd.Next(2, 5);
            return choices[index];
        }
        else if (Shots > 0 && Shots < 3)
        {
            int index = rnd.Next(0, 5);
            return choices[index];
        }
        else
        {
            int index = rnd.Next(5, 7);
            return choices[index];
        }
    }

    public bool GameOver()
    {
        if (PlayerChoice() == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
