int Akkerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    {
    if (n == 0)
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
Console.Clear();
Console.Write("Введите значение M и N для функции Аккермана через пробел: ");
int [] matrix = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(Akkerman(matrix[0], matrix[1]));