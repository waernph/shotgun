using System.Xml.Serialization;

class Player
{
    public int Shots { get; set; } //Property för skott
    public bool IsHuman { get; set; } //Property för om spelare är människa eller dator.

    //För att avgöra om spelaren ska få fråga eller ska slumpas fram.
    public char UserInput { private get; set; } //Property för att ta emot svar från spelare

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
            return 1;
        }
        else if (UserInput == 'l')
        {
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

    public char PlayerRandom() //Returnerar en char för
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
}
