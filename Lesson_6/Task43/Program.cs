Console.WriteLine("Введите коефиценты линии b1 и k1 через пробел");
var str1 = Console.ReadLine().Split(' ');
double b1 = Double.Parse(str1[0]);
double k1 = Double.Parse(str1[1]);

Console.WriteLine("Введите коефиценты линии b2 и k2 через пробел");
var str2 = Console.ReadLine().Split(' ');
double b2 = Double.Parse(str2[0]);
double k2 = Double.Parse(str2[1]);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.Write(x + ", " + y);
