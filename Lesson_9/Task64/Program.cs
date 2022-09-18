void Print(int val, int max)
{
    Console.Write(val + " ");

    if (val < max)
    {
        Print(val + 1, max);
    }
}

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

Print(m, n);
