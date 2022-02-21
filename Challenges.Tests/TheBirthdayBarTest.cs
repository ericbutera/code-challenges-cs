using System.Collections.Generic;
using Xunit;
using static Challenges.TheBirthdayBar;

namespace Challenges.Tests;


public class TheBirthdayBar
{
    public class Input
    {
        public List<int>? Squares;
        public int Day;
        public int Month;
    }

    [Fact]
    public static void Input00()
    {
        var input = new Input
        {
            Squares = new List<int> { 1, 2, 1, 3, 2 },
            Day = 3,
            Month = 2
        };
        Assert.Equal(2, birthday(input.Squares, input.Day, input.Month));
        Assert.Equal(2, birthday2(input.Squares, input.Day, input.Month));
    }

    [Fact]
    public static void Input01()
    {
        var input = new Input
        {
            Squares = new List<int> { 1, 1, 1, 1, 1, 1 },
            Day = 3,
            Month = 2
        };
        Assert.Equal(0, birthday(input.Squares, input.Day, input.Month));
        Assert.Equal(0, birthday2(input.Squares, input.Day, input.Month));
    }

    [Fact]
    public static void Input02()
    {
        var input = new Input
        {
            Squares = new List<int> { 4 },
            Day = 4,
            Month = 1
        };
        Assert.Equal(1, birthday(input.Squares, input.Day, input.Month));
        Assert.Equal(1, birthday2(input.Squares, input.Day, input.Month));
    }
}