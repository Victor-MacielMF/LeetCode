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
