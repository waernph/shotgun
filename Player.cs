class Player
{
    public int Shots { get; private set; }
    public bool IsHuman { get; set; }


    public int UserInput(char userInput)
    {
        if (userInput == 's')
        {
            return 1;
        }
        else if (userInput == 'l')
        {
            return 2;
        }
        else if (userInput == 'b')
        {
            return 3;
        }
        else if (userInput == 'h' && Shots >= 3)
        {
            return 4;
        }
        else
        {
            return 0;
        }
    }
}
