namespace LeetCode.Problems.Easy.TransformedArray;

public static class Solution
{
    public static int[] ConstructTransformedArray(int[] nums)
    {
        int n = nums.Length;                            // Armazena o tamanho do array
        int[] result = new int[n];                      // Cria array de resultado com mesmo tamanho

        for (int i = 0; i < n; i++)                     // Percorre cada índice do array
        {
            if (nums[i] > 0)                            // Se o valor atual é positivo
            {
                int newIndex = (i + nums[i]) % n;       // Calcula novo índice: anda para direita e usa % para "dar a volta"
                result[i] = nums[newIndex];             // Resultado recebe o valor na posição calculada
            }
            else if (nums[i] < 0)                       // Se o valor atual é negativo
            {
                int newIndex = ((i + nums[i]) % n + n) % n; // Calcula novo índice: anda para esquerda. O "+ n" corrige índices negativos
                result[i] = nums[newIndex];             // Resultado recebe o valor na posição calculada
            }
            else                                        // Se o valor atual é zero
            {
                result[i] = nums[i];                    // Não se move, resultado é o próprio valor (0)
            }
        }

        return result;                                  // Retorna o array transformado
    }
}