Console.WriteLine("Введите координаты точки A через пробел");
var pointA = Console.ReadLine().Split(' ');
var x1 = int.Parse(pointA[0]);
var y1 = int.Parse(pointA[1]);
var z1 = int.Parse(pointA[2]);

Console.WriteLine("Введите координаты точки B через пробел");
var pointB = Console.ReadLine().Split(' ');
var x2 = int.Parse(pointB[0]);
var y2 = int.Parse(pointB[1]);
var z2 = int.Parse(pointB[2]);

var distance = Math.Sqrt(Sqr(x2 - x1) + Sqr(y2 - y1) + Sqr(z2 - z1));

Console.WriteLine(Math.Round(distance, 2));

int Sqr(int val)
{
    return val * val;
}
