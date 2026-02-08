# 🚀 LeetCode Debug Helper

Repositório para resolver problemas do LeetCode em C# com **debug local fácil e rápido**.

> ⚡ **Objetivo:** Adicionar problemas em segundos e debugar localmente (já que o LeetCode não permite debug).

## 🎯 Por Que Este Projeto?

- ✅ **Cole e rode** - Copie o código inicial do LeetCode direto
- ✅ **Debug completo** - Breakpoints, step through, inspeção de variáveis
- ✅ **Testes automáticos** - Adicione os exemplos do LeetCode e veja os resultados
- ✅ **Zero burocracia** - Sem criar pastas, namespaces complexos, ou arquivos de teste separados

## 🏗️ Estrutura

```
LeetCode/
├── Program.cs                          # Menu para escolher qual problema rodar
├── ProblemBase.cs                      # Classe base (não precisa editar)
└── Problems/
    ├── _TEMPLATE.cs                    # ⭐ Template para copiar
    ├── Problem0001_TwoSum.cs           # Exemplo: Two Sum
    ├── Problem0003_LongestSubstring.cs # Exemplo: Longest Substring
    └── [Seus problemas aqui]
```

## ⚡ Quick Start

### 1. Criar novo problema (30 segundos)

1. Copie `LeetCode/Problems/_TEMPLATE.cs`
2. Renomeie: `Problem[XXXX]_[Nome].cs` (ex: `Problem0003_LongestSubstring.cs`)
3. Cole o código do LeetCode
4. Cole os exemplos

### 2. Executar e debugar

**Rodar:**
```bash
dotnet run --project LeetCode
# Ou pressione F5 no VS Code
```

**Debugar:**
1. Coloque breakpoints na sua solução
2. Pressione F5
3. Digite o número do problema
4. Debug! 🐛

## 📝 Exemplo Rápido

```csharp
namespace LeetCode.Problems;

public class Problem0003_LongestSubstring : ProblemBase
{
    public override int ProblemNumber => 3;
    public override string Title => "Longest Substring Without Repeating Characters";
    public override string Difficulty => "Medium";

    public override void Run()
    {
        // Example 1
        var input1 = "abcabcbb";
        var expected1 = 3;
        var result1 = new Solution().LengthOfLongestSubstring(input1);
        PrintResult(1, $"s=\"{input1}\"", expected1, result1);

        // Example 2
        var input2 = "bbbbb";
        var expected2 = 1;
        var result2 = new Solution().LengthOfLongestSubstring(input2);
        PrintResult(2, $"s=\"{input2}\"", expected2, result2);
    }

    // Cole o código do LeetCode aqui 👇
    public class Solution {
        public int LengthOfLongestSubstring(string s) {
            // Sua solução aqui
            return 0;
        }
    }
}
```

## 📚 Documentação Completa

Veja [COMO_USAR.md](COMO_USAR.md) para:
- Tutorial detalhado
- Exemplos de diferentes tipos de problemas
- Dicas e truques
- Comparação antes/depois

## 🛠️ Comandos Úteis

```bash
# Rodar o projeto
dotnet run --project LeetCode

# Build
dotnet build

# Rodar testes (antigo sistema de testes, opcional)
dotnet test
```

## 🎯 Workflow

1. **Escolha um problema no LeetCode**
2. **Copie o template → Cole o código inicial**
3. **Cole os exemplos**
4. **F5 → Debug!** 🎉

**Tempo total: ~30-60 segundos por problema** ⚡
