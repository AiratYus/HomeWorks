int Sum(int val, int max)
{
    if (val < max)
    {
        return val + Sum(val + 1, max);
    }

    return val;
}

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

var sum = Sum(m, n);
Console.WriteLine(sum);
