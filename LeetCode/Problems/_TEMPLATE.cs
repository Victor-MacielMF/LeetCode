namespace LeetCode.Problems;

/// <summary>
/// NUMERO. TÍTULO DO PROBLEMA
/// Difficulty: Easy/Medium/Hard
/// https://leetcode.com/problems/problem-slug/
/// 
/// INSTRUÇÕES:
/// 1. Renomeie este arquivo para ProblemNUMERO_NomeDoProblema.cs
///    Exemplo: Problem0042_TrappingRainWater.cs
/// 
/// 2. Atualize os valores abaixo com as informações do problema
/// 
/// 3. Cole o código inicial do LeetCode na seção marcada
/// 
/// 4. Adicione os exemplos de teste no método Run()
/// </summary>
public class ProblemTEMPLATE_ChangeThisName : ProblemBase
{
    // ALTERE ESTES VALORES:
    public override int ProblemNumber => 0; // Número do problema (ex: 42)
    public override string Title => "Problem Title Here"; // Título (ex: "Trapping Rain Water")
    public override string Difficulty => "Easy"; // Easy, Medium, ou Hard

    public override void Run()
    {
        Console.WriteLine($"Problem {ProblemNumber}: {Title} ({Difficulty})");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine();

        // TODO: Adicione os exemplos aqui
        // Exemplo para problema com 1 input:
        /*
        var input1 = "example";
        var expected1 = 5;
        var result1 = new Solution().SeuMetodo(input1);
        PrintResult(1, $"input=\"{input1}\"", expected1, result1);
        Console.WriteLine("  Explanation: Cole a explicação do LeetCode aqui");
        Console.WriteLine();
        */

        // Exemplo para problema com 2 inputs:
        /*
        var nums1 = new int[] { 2, 7, 11, 15 };
        var target1 = 9;
        var expected1 = new int[] { 0, 1 };
        var result1 = new Solution().SeuMetodo(nums1, target1);
        PrintResult(1, $"nums=[{string.Join(",", nums1)}], target={target1}", 
                    $"[{string.Join(",", expected1)}]", 
                    $"[{string.Join(",", result1)}]");
        Console.WriteLine();
        */
    }

    // ============================================================
    // COLE AQUI O CÓDIGO INICIAL DO LEETCODE
    // ============================================================
    
    // Exemplo:
    // public class Solution {
    //     public int SeuMetodo(string input) {
    //         
    //     }
    // }
}
