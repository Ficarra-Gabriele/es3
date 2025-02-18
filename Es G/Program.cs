int[,] m1 = { {0, 0, 0, 0, 0}, // esercizio G
              {0, 0, 0, 0, 0},
              {0, 0, 0, 0, 0},
              {0, 0, 0, 0, 0},
              {0, 0, 0, 0, 0}  };

for (int i = 0; i < m1.GetLength(0); i++)
{
    Random rnd = new Random();
    int n = rnd.Next(0, 5);

    for (int j = 0; j < m1.GetLength(0); j++)
    {
        if (m1[i, n] == 0)
        {
            m1[i, n] = -1;
        }
        Console.Write("[" + m1[i, j] + "]");
    }
    Console.WriteLine();
} // esercizio G

Console.WriteLine();
void somma_celle(int[,] m)
{
    int s1 = 0, s2 = 0, s3 = 0;
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(0); j++)
        {
            if (i == 0 || j == 0)
            {
                m[i, j] = m[i + 1, j + 1] + m[i, j + 1] + m[i + 1, j];
            }
            else if (i == m.GetLength(0) - 1 || j == m.GetLength(1) - 1)
            {
                m[i, j] = m[i - 1, j - 1] + m[i, j - 1] + m[i - 1, j];
            }
            else if (i == m.GetLength(0) - 1 && j == 0)
            {
                m[i, j] = m[i, j + 1] + m[i - 1, j + 1] + m[i - 1, j];
            }
            else if (i == 0 && j == m.GetLength(1) - 1)
            {
                m[i, j] = m[i + 1, j] + m[i + 1, j - 1] + m[i, j - 1];
            }

        }
    }
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(0); j++)
        {

            Console.Write(m[i, j]);
        }
        Console.WriteLine();
    }
}
somma_celle(m1);