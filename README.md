# LeetCode Workspace

Repositório para armazenar soluções de desafios do LeetCode em C#.

## Estrutura
```
LeetCode.sln
LeetCode/
  Problems/
    Easy/
    Medium/
    Hard/
```

## Como adicionar um desafio
1. Crie uma pasta dentro de `LeetCode/Problems/Easy`, `LeetCode/Problems/Medium` ou `LeetCode/Problems/Hard`.
2. Use um nome claro, por exemplo: `0001-Two-Sum`.
3. Dentro da pasta, crie:
   - `Solution.cs` para a solução.
   - `README.md` com descrição breve, complexidade e observações.

## Como executar
Use testes para validar as soluções:

- Rodar todos os testes: `dotnet test`
- Rodar testes específicos: `dotnet test --filter FullyQualifiedName~HelloWorld`

## Projeto de testes
Os testes ficam no projeto `LeetCode.Tests` e validam as soluções contidas em `LeetCode/Problems`.
