namespace LeetCode.Problems;

public class ProblemXXXX_NomeDoProblema : ProblemBase // ← MUDE O NOME DA CLASSE
{
    public override int ProblemNumber => 0;        // ← NÚMERO DO PROBLEMA
    public override string Title => "Title";       // ← TÍTULO
    public override string Difficulty => "Easy";   // ← DIFICULDADE

    public override void Run()
    {
        Console.WriteLine($"Problem {ProblemNumber}: {Title} ({Difficulty})");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine();

        // ← ADICIONE OS EXEMPLOS AQUI
        /*
        // Example 1
        var input1 = ...;
        var expected1 = ...;
        var result1 = new Solution().MetodoDoLeetCode(input1);
        PrintResult(1, $"input={input1}", expected1, result1);
        Console.WriteLine();

        // Example 2
        var input2 = ...;
        var expected2 = ...;
        var result2 = new Solution().MetodoDoLeetCode(input2);
        PrintResult(2, $"input={input2}", expected2, result2);
        Console.WriteLine();

        // Example 3
        var input3 = ...;
        var expected3 = ...;
        var result3 = new Solution().MetodoDoLeetCode(input3);
        PrintResult(3, $"input={input3}", expected3, result3);
        Console.WriteLine();
        */
    }

    // ============================================================
    // ← COLE O CÓDIGO DO LEETCODE AQUI
    // ============================================================
    
}
