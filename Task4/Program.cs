int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

var max = a;
if (c > a && c > b)
{
    max = c;
}
else if (b > a && b > a)
{
    max = b;
}

Console.WriteLine($"max = {max}");
