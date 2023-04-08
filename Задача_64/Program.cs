string PrintNumber (int n)
{
    if (n == 1) 
        return 1.ToString();
    return n.ToString() + ", " + PrintNumber (n-1);
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.Write(PrintNumber(n));