using AddOneSolution = LeetCode.Problems.Easy.AddOne.Solution;

namespace LeetCode.Tests;

public class AddOneTests
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(5, 6)]
    [InlineData(-3, -2)]
    public void Run_ReturnsValuePlusOne(int input, int expected)
    {
        var result = AddOneSolution.Run(input);

        Assert.Equal(expected, result);
    }
}

public class NimGameTests
{
    [Theory]
    [InlineData(4, false)]
    [InlineData(1, true)]
    [InlineData(2, true)]
    public void Run_NimGame_Tests(int input, bool expected)
    {
        var result = Problems.Easy.NimGame.Solution.CanWinNim(input);

        Assert.Equal(expected, result);
    }
}
