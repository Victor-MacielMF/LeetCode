using LeetCode;
using LeetCode.Problems;
using System.Reflection;

Console.Clear();
Console.WriteLine("╔═══════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                  LeetCode Problem Runner                      ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// Descobre todos os problemas disponíveis automaticamente
var problemType = typeof(ProblemBase);
var problems = Assembly.GetExecutingAssembly()
    .GetTypes()
    .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(problemType))
    .Select(t => (ProblemBase)Activator.CreateInstance(t)!)
    .OrderBy(p => p.ProblemNumber)
    .ToList();

if (problems.Count == 0)
{
    Console.WriteLine("❌ Nenhum problema encontrado!");
    return;
}

Console.WriteLine("Problemas disponíveis:");
Console.WriteLine();

foreach (var problem in problems)
{
    Console.WriteLine($"  {problem.ProblemNumber,4}. {problem.Title,-45} [{problem.Difficulty}]");
}

Console.WriteLine();
Console.WriteLine(new string('─', 63));
Console.WriteLine();
Console.Write("Digite o número do problema para executar (ou 'q' para sair): ");

var input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input) || input.ToLower() == "q")
{
    Console.WriteLine("Até logo! 👋");
    return;
}

if (!int.TryParse(input, out int problemNumber))
{
    Console.WriteLine("❌ Número inválido!");
    return;
}

var selectedProblem = problems.FirstOrDefault(p => p.ProblemNumber == problemNumber);

if (selectedProblem == null)
{
    Console.WriteLine($"❌ Problema {problemNumber} não encontrado!");
    return;
}

Console.WriteLine();
Console.WriteLine(new string('═', 63));
Console.WriteLine();

try
{
    selectedProblem.Run();
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"❌ Erro ao executar o problema: {ex.Message}");
    Console.WriteLine(ex.StackTrace);
    Console.ResetColor();
}

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();
