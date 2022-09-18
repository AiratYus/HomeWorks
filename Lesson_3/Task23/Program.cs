int a = int.Parse(Console.ReadLine());

for (int i = 1; i < a; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}

Console.Write(Math.Pow(a, 3));
