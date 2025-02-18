

int[,] m1 = { {0, 0, 0, 0, 0},
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
}