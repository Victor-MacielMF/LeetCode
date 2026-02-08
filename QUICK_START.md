# 🚀 Quick Start - Adicionar Novo Problema em 60 Segundos

## Exemplo Prático: Problema 3 - Longest Substring Without Repeating Characters

### Passo 1: Copiar o Template (5 segundos)
1. Abra `LeetCode/Problems/_TEMPLATE.cs`
2. Copie todo o conteúdo
3. Crie novo arquivo: `LeetCode/Problems/Problem0003_LongestSubstring.cs`

### Passo 2: Atualizar Informações do Problema (10 segundos)
```csharp
public class Problem0003_LongestSubstring : ProblemBase  // ← Mude o nome da classe
{
    public override int ProblemNumber => 3;              // ← Número do problema
    public override string Title => "Longest Substring Without Repeating Characters";  // ← Título
    public override string Difficulty => "Medium";       // ← Dificuldade
```

### Passo 3: Cole o Código do LeetCode (5 segundos)
Na seção marcada com "COLE AQUI O CÓDIGO INICIAL DO LEETCODE", cole:

```csharp
    // ============================================================
    // COLE AQUI O CÓDIGO INICIAL DO LEETCODE
    // ============================================================
    public class Solution {
        public int LengthOfLongestSubstring(string s) {
            
        }
    }
```

### Passo 4: Adicione os Exemplos (30 segundos)
No método `Run()`, adicione os test cases:

```csharp
    public override void Run()
    {
        Console.WriteLine($"Problem {ProblemNumber}: {Title} ({Difficulty})");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine();

        // Example 1: Input: s = "abcabcbb", Output: 3
        var input1 = "abcabcbb";
        var expected1 = 3;
        var result1 = new Solution().LengthOfLongestSubstring(input1);
        PrintResult(1, $"s=\"{input1}\"", expected1, result1);
        Console.WriteLine("  Explanation: The answer is \"abc\", with the length of 3.");
        Console.WriteLine();

        // Example 2: Input: s = "bbbbb", Output: 1
        var input2 = "bbbbb";
        var expected2 = 1;
        var result2 = new Solution().LengthOfLongestSubstring(input2);
        PrintResult(2, $"s=\"{input2}\"", expected2, result2);
        Console.WriteLine("  Explanation: The answer is \"b\", with the length of 1.");
        Console.WriteLine();

        // Example 3: Input: s = "pwwkew", Output: 3
        var input3 = "pwwkew";
        var expected3 = 3;
        var result3 = new Solution().LengthOfLongestSubstring(input3);
        PrintResult(3, $"s=\"{input3}\"", expected3, result3);
        Console.WriteLine("  Explanation: The answer is \"wke\", with the length of 3.");
        Console.WriteLine();
    }
```

### Passo 5: Executar e Debugar (10 segundos)

**Opção A - Rodar Direto:**
```bash
dotnet run --project LeetCode
# Digite: 3
```

**Opção B - Debug no VS Code:**
1. Pressione `F5`
2. Digite `3`
3. Coloque breakpoints dentro do método `LengthOfLongestSubstring`
4. Debug! 🐛

## 📸 Output Esperado

```
╔═══════════════════════════════════════════════════════════════╗
║                  LeetCode Problem Runner                      ║
╚═══════════════════════════════════════════════════════════════╝

Problemas disponíveis:

     1. Two Sum                                         [Easy]
     3. Longest Substring Without Repeating Characters [Medium]

───────────────────────────────────────────────────────────────

Digite o número do problema para executar (ou 'q' para sair): 3

═══════════════════════════════════════════════════════════════

Problem 3: Longest Substring Without Repeating Characters (Medium)
--------------------------------------------------

✓ PASSED - Test Case 1
  Input:    s="abcabcbb"
  Expected: 3
  Actual:   3

  Explanation: The answer is "abc", with the length of 3.

✓ PASSED - Test Case 2
  Input:    s="bbbbb"
  Expected: 1
  Actual:   1

  Explanation: The answer is "b", with the length of 1.

✗ FAILED - Test Case 3
  Input:    s="pwwkew"
  Expected: 3
  Actual:   0

  Explanation: The answer is "wke", with the length of 3.

Pressione qualquer tecla para sair...
```

## 🎯 Dicas Rápidas

### Para Arrays como Input:
```csharp
var nums = new int[] { 2, 7, 11, 15 };
var target = 9;
var expected = new int[] { 0, 1 };
var result = new Solution().TwoSum(nums, target);
PrintResult(1, $"nums=[{string.Join(",", nums)}], target={target}", 
            $"[{string.Join(",", expected)}]", 
            $"[{string.Join(",", result)}]");
```

### Para Múltiplos Inputs:
```csharp
var grid = new int[][] { 
    new int[] { 1, 2, 3 }, 
    new int[] { 4, 5, 6 } 
};
var k = 2;
var expected = 7;
var result = new Solution().KthSmallest(grid, k);
PrintResult(1, $"grid=[[...]], k={k}", expected, result);
```

### Para Comparar Arrays:
```csharp
var result = new Solution().SomeMethod(input);
// Se esperado e resultado são arrays, formate ao imprimir:
PrintResult(1, $"input={input}", 
            $"[{string.Join(",", expected)}]", 
            $"[{string.Join(",", result)}]");
```

## ⚡ Atalhos do VS Code

- `F5` - Start Debugging
- `Ctrl+F5` - Run Without Debugging
- `F9` - Toggle Breakpoint
- `F10` - Step Over
- `F11` - Step Into
- `Shift+F11` - Step Out

## 🎉 Pronto!

Agora você tem um ambiente completo para resolver problemas do LeetCode com debug local!

**Tempo total: ~60 segundos por problema** ⚡
