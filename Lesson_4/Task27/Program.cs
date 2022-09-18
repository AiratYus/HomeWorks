int val = int.Parse(Console.ReadLine());

var res = 0;

while (val > 0)
{
    res += val % 10;
    val /= 10;
}

Console.WriteLine(res);
