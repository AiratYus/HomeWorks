void FillMatrix(int[,] matrix, int m, int n)
{
    var random = new Random();
    
    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            matrix[x, y] = random.Next(0, 100);
        }
    }
}

void PrintMatrix(int[,] matrix, int m, int n)
{
    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            Console.Write(matrix[x, y] + " ");
        }
        Console.WriteLine();
    }
}

void SortMatrix(int[,] matrix, int m, int n)
{
    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            for (int z = 0; z < n; z++)
            {
                if (matrix[x, y] > matrix[x, z])
                {
                    var temp = matrix[x, y];
                    matrix[x, y] = matrix[x, z];
                    matrix[x, z] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());

var matrix = new int[m, n];

FillMatrix(matrix, m, n);
Console.WriteLine("До сортировки");
PrintMatrix(matrix, m, n);

SortMatrix(matrix, m, n);
Console.WriteLine("После сортировки");
PrintMatrix(matrix, m, n);
