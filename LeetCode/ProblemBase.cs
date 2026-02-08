namespace LeetCode;

/// <summary>
/// Classe base para todos os problemas do LeetCode.
/// Cada problema deve herdar desta classe e implementar o método Run().
/// </summary>
public abstract class ProblemBase
{
    public abstract int ProblemNumber { get; }
    public abstract string Title { get; }
    public abstract string Difficulty { get; }
    
    /// <summary>
    /// Execute os teste cases do problema.
    /// </summary>
    public abstract void Run();
    
    protected void PrintResult<TInput, TOutput>(int testCase, TInput input, TOutput expected, TOutput actual)
    {
        var passed = EqualityComparer<TOutput>.Default.Equals(expected, actual);
        var status = passed ? "✓ PASSED" : "✗ FAILED";
        var color = passed ? ConsoleColor.Green : ConsoleColor.Red;
        
        Console.ForegroundColor = color;
        Console.WriteLine($"{status} - Test Case {testCase}");
        Console.ResetColor();
        Console.WriteLine($"  Input:    {FormatValue(input)}");
        Console.WriteLine($"  Expected: {FormatValue(expected)}");
        Console.WriteLine($"  Actual:   {FormatValue(actual)}");
        Console.WriteLine();
    }
    
    protected bool ArrayEquals<T>(T[] a, T[] b)
    {
        if (a.Length != b.Length) return false;
        for (int i = 0; i < a.Length; i++)
        {
            if (!EqualityComparer<T>.Default.Equals(a[i], b[i]))
                return false;
        }
        return true;
    }
    
    private string FormatValue<T>(T value)
    {
        if (value is System.Collections.IEnumerable enumerable and not string)
        {
            return "[" + string.Join(", ", enumerable.Cast<object>()) + "]";
        }
        return value?.ToString() ?? "null";
    }
}
