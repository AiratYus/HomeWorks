Console.WriteLine("Введите числа через пробел:");

var str = Console.ReadLine().Split(' ');

var res = 0;
for (int i = 0; i < str.Length; i++)
{
    var val = int.Parse(str[i]);
    if (val > 0) res++;
}

Console.WriteLine(res);
