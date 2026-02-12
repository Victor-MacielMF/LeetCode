namespace LeetCode.Problems;

/// <summary>
/// 3. Longest Substring Without Repeating Characters
/// Difficulty: Medium
/// https://leetcode.com/problems/longest-substring-without-repeating-characters/
/// </summary>
public class Problem3_LengthOfLongestSubstring : ProblemBase
{
    public override int ProblemNumber => 3;        // ← NÚMERO DO PROBLEMA
    public override string Title => "Longest Substring Without Repeating Characters";       // ← TÍTULO
    public override string Difficulty => "Medium";   // ← DIFICULDADE

    public override void Run()
    {
        Console.WriteLine($"Problem {ProblemNumber}: {Title} ({Difficulty})");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine();

        // Example 1
        var input1 = "abcabcbb";
        var expected1 = 3;
        var result1 = new Solution().LengthOfLongestSubstring(input1);
        PrintResult(1, $"input={input1}", expected1, result1);
        Console.WriteLine();

        // Example 2
        var input2 = "bbbbb";
        var expected2 = 1;
        var result2 = new Solution().LengthOfLongestSubstring(input2);
        PrintResult(2, $"input={input2}", expected2, result2);
        Console.WriteLine();

        // Example 3
        var input3 = "pwwkew";
        var expected3 = 3;
        var result3 = new Solution().LengthOfLongestSubstring(input3);
        PrintResult(3, $"input={input3}", expected3, result3);
        Console.WriteLine();
        
    }
    
    /*
    public class Solution {
        public int LengthOfLongestSubstring(string s)
        {
            string actualSubstring = "";
            int longestSubstring = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (actualSubstring.Contains(s[i]))
                {
                    longestSubstring = actualSubstring.Length > longestSubstring ? actualSubstring.Length : longestSubstring;
                    actualSubstring = s[i].ToString();
                }
                else
                {
                    actualSubstring = actualSubstring + s[i];
                }
            }

            longestSubstring = actualSubstring.Length > longestSubstring ? actualSubstring.Length : longestSubstring;

            return longestSubstring;
        }
    }
    */

    public class Solution {
        public int LengthOfLongestSubstring(string s)
        {
            var seen = new HashSet<char>();
            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                // Se o caractere já está na janela, remove do início até eliminá-lo
                while (seen.Contains(s[right]))
                {
                    seen.Remove(s[left]);
                    left++;
                }

                seen.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
