void SpiralFill(int[,] matrix, int m, int n)
{
    var val = 1;
    
    for (int y = 0; y < n; y++)
    {
        matrix[0, y] = val;
        val++;
    }

    for (int x = 1; x < m; x++)
    {
        matrix[x, n - 1] = val;
        val++;
    }

    for (int y = 2; y >= 0; y--)
    {
        matrix[m - 1, y] = val;
        val++;
    }

    for (int x = 2; x > 0; x--)
    {
        matrix[x, 0] = val;
        val++;
    }

    for (int y = 1; y < n - 1; y++)
    {
        matrix[m - 3, y] = val;
        val++;
    }

    for (int y = 2; y > 0; y--)
    {
        matrix[m - 2, y] = val;
        val++;
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

int m = 4;
int n = 4;

var matrix = new int[m, n];

SpiralFill(matrix, m, n);
PrintMatrix(matrix, m, n);
