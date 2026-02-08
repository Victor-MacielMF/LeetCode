# 🚀 LeetCode Debug Helper

Projeto simplificado para resolver problemas do LeetCode com capacidade de debug local.

## 📋 Como Usar

### 1️⃣ Criar um Novo Problema

1. **Copie o arquivo template:**
   - Abra `LeetCode/Problems/_TEMPLATE.cs`
   - Copie todo o conteúdo
   - Crie um novo arquivo com o nome: `Problem[XXXX]_[NomeDoProblema].cs`
   - Exemplo: `Problem0003_LongestSubstring.cs`

2. **Preencha as informações básicas:**
   ```csharp
   public override int ProblemNumber => 3;
   public override string Title => "Longest Substring Without Repeating Characters";
   public override string Difficulty => "Medium";
   ```

3. **Cole o código inicial do LeetCode:**
   - Na seção marcada com "COLE AQUI O CÓDIGO INICIAL DO LEETCODE"
   - Cole exatamente como o LeetCode fornece
   ```csharp
   public class Solution {
       public int LengthOfLongestSubstring(string s) {
           
       }
   }
   ```

4. **Adicione os exemplos de teste:**
   - No método `Run()`, adicione os exemplos do problema
   - Cole os inputs, outputs e explanations direto do LeetCode
   ```csharp
   // Example 1
   var input1 = "abcabcbb";
   var expected1 = 3;
   var result1 = new Solution().LengthOfLongestSubstring(input1);
   PrintResult(1, $"s=\"{input1}\"", expected1, result1);
   Console.WriteLine("  Explanation: The answer is \"abc\", with the length of 3.");
   ```

### 2️⃣ Executar e Debugar

**Opção 1: Executar via Menu**
- Pressione `F5` ou `Ctrl+F5`
- Digite o número do problema que deseja executar
- Veja os resultados dos testes

**Opção 2: Debug Direto**
- Abra o arquivo do problema
- Coloque breakpoints no seu código dentro da classe `Solution`
- Pressione `F5`
- Digite o número do problema
- O debugger vai parar nos breakpoints e você pode inspecionar variáveis, step through, etc.

### 3️⃣ Estrutura de Arquivos

```
LeetCode/
├── Program.cs                          # Menu principal (não precisa editar)
├── ProblemBase.cs                      # Classe base (não precisa editar)
└── Problems/
    ├── _TEMPLATE.cs                    # Template para novos problemas
    ├── Problem0001_TwoSum.cs           # Exemplo: Two Sum
    ├── Problem0003_LongestSubstring.cs # Exemplo: Longest Substring
    └── Problem[XXXX]_[Nome].cs         # Seus novos problemas aqui
```

## ✨ Exemplos

### Problema com 1 Input

```csharp
// Example 1
var input1 = "abcabcbb";
var expected1 = 3;
var result1 = new Solution().LengthOfLongestSubstring(input1);
PrintResult(1, $"s=\"{input1}\"", expected1, result1);
```

### Problema com 2 Inputs

```csharp
// Example 1
var nums1 = new int[] { 2, 7, 11, 15 };
var target1 = 9;
var expected1 = new int[] { 0, 1 };
var result1 = new Solution().TwoSum(nums1, target1);
PrintResult(1, $"nums=[{string.Join(",", nums1)}], target={target1}", 
            $"[{string.Join(",", expected1)}]", 
            $"[{string.Join(",", result1)}]");
```

### Problema com Arrays

```csharp
// Example 1
var input1 = new int[] { 1, 2, 3, 4 };
var expected1 = new int[] { 4, 3, 2, 1 };
var result1 = new Solution().ReverseArray(input1);

// Para comparar arrays, use o método helper
bool passed = ArrayEquals(expected1, result1);
PrintResult(1, $"[{string.Join(",", input1)}]", 
            $"[{string.Join(",", expected1)}]", 
            $"[{string.Join(",", result1)}]");
```

## 🎯 Dicas

1. **Mantenha o código do LeetCode intacto inicialmente** - Cole exatamente como fornecido
2. **Adicione todos os exemplos** - Quanto mais testes, melhor
3. **Use breakpoints** - Coloque breakpoints na sua solução para debugar linha por linha
4. **Teste edge cases** - Adicione seus próprios casos de teste além dos exemplos

## 📦 Estrutura do Projeto

- **LeetCode** - Projeto console principal com todos os problemas
- **LeetCode.Tests** - Projeto antigo de testes unitários (pode ser removido se preferir)

## 🔄 Workflow Rápido

1. Abra o LeetCode e escolha um problema
2. Copie o template → renomeie para o número/nome do problema
3. Cole o código inicial do LeetCode
4. Cole os exemplos de input/output
5. Pressione F5, digite o número do problema
6. Debug e resolva! 🎉

## 🆚 Comparação: Antes vs Depois

### ❌ Antes (Complicado)
- Criar pasta com número e nome
- Criar README.md
- Criar Solution.cs com namespace específico
- Ir para EasyTests.cs/MediumTests.cs/HardTests.cs
- Adicionar using correto
- Criar classe de teste
- Adicionar [Theory] e [InlineData] para cada exemplo
- Buildar e rodar testes
- Não conseguia debugar facilmente

### ✅ Agora (Simples)
- Copiar template
- Colar código do LeetCode
- Colar exemplos
- F5 → Debug! 🚀

Tempo economizado: **~5-10 minutos por problema!**
