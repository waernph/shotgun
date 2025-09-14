class Graphics
{
    public string[] Options = ["Välj (L)adda eller (B)locka", "Välj (S)kjut, (L)adda eller (B)locka", "Välj (S)kjut, (L)adda, (B)locka eller (H)agelgevär"];
    //int shots;
    public string Prompts(int shots)
    {
        if (shots > 0 && shots < 3)
        {
            return Options[1];
        }
        else if (shots >= 3)
        {
            return Options[2];
        }
        else
        {
            return Options[0];
        }
    }
}