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

public class TransformedArrayTests
{
    [Theory]
    [InlineData(new int[] {3,-2,1,1}, new int[] {1,1,1,3})]
    [InlineData(new int[] {-1,4,-1}, new int[] {-1,-1,4})]
    public void Run_TransformedArray_Tests(int[] input, int[] expected)
    {
        var result = Problems.Easy.TransformedArray.Solution.ConstructTransformedArray(input);

        Assert.Equal(expected, result);
    }
}
