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

Console.WriteLine("Введите количество строк матрицы #1");
int m1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы #1");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество строк матрицы #2");
int m2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы #2");
int n2 = int.Parse(Console.ReadLine());

var matrix1 = new int[m1, n1];
FillMatrix(matrix1, m1, n1);
Console.WriteLine("Матрица #1:");
PrintMatrix(matrix1, m1, n1);

var matrix2 = new int[m2, n2];
FillMatrix(matrix2, m2, n2);
Console.WriteLine("Матрица #2:");
PrintMatrix(matrix2, m2, n2);

int[,] matrix3 = new int[m1, n2];

for (int x = 0; x < m1; x++)
{
    for (int y = 0; y < n2; y++)
    {
        for (int z = 0; z < n1; z++)
        {
            matrix3[x, y] += matrix1[x, z] * matrix2[z, y];
        }
    }
}

PrintMatrix(matrix3, n1, m2);
