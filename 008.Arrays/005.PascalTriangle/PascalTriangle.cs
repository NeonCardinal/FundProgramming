//Arrays, Task 005
//25.04.2023, 20:28
using System;

public class PascalTriangle
{
    static void Main()
    {
        const int HEIGHT = 11;

        long[][] triangle = new long[HEIGHT + 1][];

        for(int i = 0; i < HEIGHT; i++)
        {
            triangle[i] = new long[i + 1];
        }

        triangle[0][0] = 1;

        for(int i = 0; i < HEIGHT - 1; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                triangle[i + 1][j] += triangle[i][j];
                triangle[i + 1][j + 1] += triangle[i][j];
            }
        }

        for(int i = 0; i < HEIGHT; i++)
        {
            Console.Write("".PadLeft((HEIGHT - i) * 2));

            for(int j = 0; j <= i; j++)
            {
                Console.Write("{0, 3} ", triangle[i][j]);
            }

            Console.WriteLine();
        }
    }
}