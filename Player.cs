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
    private int Choice;

    public Player(bool isHuman)
    {
        IsHuman = isHuman;
    }

    private char PlayerInput()
    {
        string[] Options =
        [
            "Välj (L)adda eller (B)locka",
            "Välj (S)kjut, (L)adda eller (B)locka",
            "Välj (S)kjut, (L)adda, (B)locka eller (H)agelgevär",
        ];
        if (shots > 0 && shots < 3)
        {
            Console.WriteLine(Options[1]);
        }
        else if (shots >= 3)
        {
            Console.WriteLine(Options[2]);
        }
        else
        {
            Console.WriteLine(Options[0]);
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
                    Console.WriteLine("Du har inga skott, förök inte!");
                    Choice = 9;
                    break;
                }

            case 'l':
                shots += 1;
                Choice = 2;
                break;

            case 'b':
                Choice = 3;
                break;

            case 'h':
                Choice = 4;
                break;

            default:
                Console.WriteLine("Valet finns inte. Försök igen");
                Choice = 9;
                break;
        }

        /*         if (UserInput == 's' && shots > 0) //Val att göra, skjuta, ladda eller blocka
                {
                    shots -= 1;
                    return 1;
                }
                else if (UserInput == 'l')
                {
                    shots += 1;
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
                } */
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
            int index = rnd.Next(6, 7);
            return choices[index];
        }
    }

    public bool GameOver()
    {
        if (Choice == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
