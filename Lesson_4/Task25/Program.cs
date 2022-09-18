int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

var res = 1;

while (b > 0)
{
    res *= a;
    b--;
}

Console.WriteLine(res);
