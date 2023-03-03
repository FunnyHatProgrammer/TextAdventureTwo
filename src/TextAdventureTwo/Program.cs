using TextAdventureTwo.Models;
using TextAdventureTwo.Enums;

Console.WriteLine("Welcome to TEXTADVENTURE TWO");
Console.WriteLine();
Console.WriteLine("Move around with the Arrow Keys");

Player player = new Player();
var TextOutput = String.Empty;

// Main game loop
while (true)
{
    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey();

        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                TextOutput = player.Move(Direction.North);
                break;
            case ConsoleKey.RightArrow:
                TextOutput = player.Move(Direction.East);
                break;
            case ConsoleKey.DownArrow:
                TextOutput = player.Move(Direction.South);
                break;
            case ConsoleKey.LeftArrow:
                TextOutput = player.Move(Direction.West);
                break;
        }
        Console.WriteLine(TextOutput);
    }
}
