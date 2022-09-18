string a = Console.ReadLine();

for (int i = 0; i < a.Length / 2; i++)
{
    if (a[i] != a[a.Length - i - 1])
    {
        Console.WriteLine("нет");
        return;
    }
}

Console.WriteLine("да");
