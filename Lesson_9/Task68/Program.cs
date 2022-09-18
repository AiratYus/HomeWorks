int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return ++n;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }

    return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

var result = Akkerman(m, n);
Console.WriteLine(result);
