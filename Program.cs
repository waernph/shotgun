class Program
{
    static void Main()
    {
        Player player = new Player();
        Player computer = new Player();
        computer.IsHuman = false;
        

        Console.WriteLine(computer.PlayerChoice());
    }
}
