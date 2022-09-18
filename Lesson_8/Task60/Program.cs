void FillMatrix(int[,,] matrix, int xs, int ys, int zs)
{
    var max = 100;
    var added = new bool[max];
    
    var random = new Random();
    
    for (int x = 0; x < xs; x++)
    {
        for (int y = 0; y < ys; y++)
        {
            for (int z = 0; z < zs; z++)
            {
                 var value = random.Next(0, max);

                 while (added[value])
                 {
                     value = random.Next(0, max);
                 }

                 matrix[x, y, z] = value;
                 added[value] = true;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix, int xs, int ys, int zs)
{
    for (int x = 0; x < xs; x++)
    {
        for (int y = 0; y < ys; y++)
        {
            for (int z = 0; z < zs; z++)
            {
                Console.Write($"{matrix[y, z, x]}({y},{z},{x}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите количество x");
int xs = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество y");
int ys = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество z");
int zs = int.Parse(Console.ReadLine());

var matrix = new int[xs, ys, zs];

FillMatrix(matrix, xs, ys, zs);
PrintMatrix(matrix, xs, ys, zs);
