int PrintNumber(int M, int N)
{
    if (M == N) 
        return M;
    return N + PrintNumber(M,N-1);
}

Console.Clear();
Console.Write("Введите два числа  через пробел: ");
int [] matrix = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (matrix[0] > matrix[1])
{
    Console.Write(PrintNumber(matrix[1], matrix[0]));
}
else Console.Write(PrintNumber(matrix[0], matrix[1]));
