namespace LeetCode.Problems;

/// <summary>
/// 1. Two Sum
/// Difficulty: Easy
/// https://leetcode.com/problems/two-sum/
/// </summary>
public class Problem0001_TwoSum : ProblemBase
{
    public override int ProblemNumber => 1;
    public override string Title => "Two Sum";
    public override string Difficulty => "Easy";

    public override void Run()
    {
        Console.WriteLine($"Problem {ProblemNumber}: {Title} ({Difficulty})");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine();

        // Test Case 1
        var nums1 = new int[] { 2, 7, 11, 15 };
        var target1 = 9;
        var expected1 = new int[] { 0, 1 };
        var result1 = new Solution().TwoSum(nums1, target1);
        PrintResult(1, $"nums=[{string.Join(",", nums1)}], target={target1}", 
                    $"[{string.Join(",", expected1)}]", $"[{string.Join(",", result1)}]");

        // Test Case 2
        var nums2 = new int[] { 3, 2, 4 };
        var target2 = 6;
        var expected2 = new int[] { 1, 2 };
        var result2 = new Solution().TwoSum(nums2, target2);
        PrintResult(2, $"nums=[{string.Join(",", nums2)}], target={target2}", 
                    $"[{string.Join(",", expected2)}]", $"[{string.Join(",", result2)}]");

        // Test Case 3
        var nums3 = new int[] { 3, 3 };
        var target3 = 6;
        var expected3 = new int[] { 0, 1 };
        var result3 = new Solution().TwoSum(nums3, target3);
        PrintResult(3, $"nums=[{string.Join(",", nums3)}], target={target3}", 
                    $"[{string.Join(",", expected3)}]", $"[{string.Join(",", result3)}]");
    }

    // ============================================================
    // COLE AQUI O CÓDIGO INICIAL DO LEETCODE
    // ============================================================
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // Sua solução aqui
            var dict = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                dict[nums[i]] = i;
            }
            
            return new int[0];
        }
    }
}
