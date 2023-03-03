using TextAdventureTwo.Enums;
using TextAdventureTwo.Models;
using Xunit;

namespace TextAdventureTests;

public class PlayerMovementTests
{
    [Fact]
    public void PlayerCanMoveNorth()
    {
        var expected = "North";
        var actual = new Player().Move(Direction.North);

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void PlayerCanMoveEast()
    {
        var expected = "East";
        var actual = new Player().Move(Direction.East);

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void PlayerCanMoveSouth()
    {
        var expected = "South";
        var actual = new Player().Move(Direction.South);

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void PlayerCanMoveWest()
    {
        var expected = "West";
        var actual = new Player().Move(Direction.West);

        Assert.Equal(expected, actual);
    }
}