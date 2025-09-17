class Player
{
    Graphics gfx = new Graphics();
    private int shots = 0;
    public int Shots
    {
        get { return shots; }
        set { shots = value; }
    } //Property för skott
    private bool IsHuman { get; set; } //Property för om spelare är människa eller dator.

    //För att avgöra om spelaren ska få fråga eller ska slumpas fram.
    private char UserInput { get; set; } //Property för att ta emot svar från spelare
    int choice = 9;
    public int Choice
    {
        get { return choice; }
        set { choice = value; }
    }

    public Player(bool isHuman)
    {
        IsHuman = isHuman;
    }

    private char PlayerInput()
    {
        string[] Options =
        [
            "Välj (L)adda eller (B)locka ",
            "Välj (S)kjut, (L)adda eller (B)locka ",
            "Välj (S)kjut, (L)adda, (B)locka eller (H)agelgevär "
        ];
        if (shots > 0 && shots < 3)
        {
            Console.Write(Options[1]);
        }
        else if (shots >= 3)
        {
            Console.Write(Options[2]);
        }
        else
        {
            Console.Write(Options[0]);
        }
        return char.ToLower(Console.ReadKey().KeyChar);
    }

    public void PlayerChoice()
    {
        if (IsHuman) //Avgör om spelare ska få välja eller om det ska slumpas
        {
            UserInput = PlayerInput();
        }
        else
        {
            UserInput = PlayerRandom();
        }

        switch (UserInput)
        {
            case 's':
                if (shots > 0)
                {
                    shots -= 1;
                    Choice = 1;
                    break;
                }
                else
                {
                    Choice = 100; //Felkod. Inga skott
                    goto default;
                }

            case 'l':
                shots += 1;
                Choice = 2;
                break;

            case 'b':
                Choice = 3;
                break;

            case 'h':
                if (shots >= 3)
                {
                    Choice = 4;
                    break;
                }
                else
                {
                    Choice = 102; //felkod. inte tillräckligt med skott för shotgun.
                    goto default;
                }

            default:
                if (choice != 100 && choice != 102)
                {
                    Choice = 101; //felkod. felaktigt knapptryck
                }
                Console.Clear();
                gfx.ShotgunLogo();
                gfx.NotValidInput(Choice);
                choice = 9;
                break;
        }
    }

    private char PlayerRandom() //Returnerar en char för
    {
        string choices = "ssllbbhhhh";
        Random rnd = new Random();
        if (shots == 0)
        {
            int index = rnd.Next(2, 4);
            return choices[index];
        }
        else if (shots > 0 && shots < 3)
        {
            int index = rnd.Next(0, 5);
            return choices[index];
        }
        else
        {
            int index = rnd.Next(5, 9);
            return choices[index];
        }
    }

    public bool GameOver()
    {
        if (Choice == 4 && Shots >= 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
