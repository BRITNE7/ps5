using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 40;
            int columns = 80;
            char[,] massive = new char[rows, columns];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    massive[i, j] = rand.Next(100) < 5 ? '#' : ' ';
                }
            }

            int x = 0;
            int y = 0;

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (i == y && j == x)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(massive[i, j]);
                        }
                    }
                    Console.WriteLine();
                }

                ConsoleKey key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.W:
                        if (y > 0) y--;
                        break;
                    case ConsoleKey.S:
                        if (y < rows - 1) y++;
                        break;
                    case ConsoleKey.A:
                        if (x > 0) x--;
                        break;
                    case ConsoleKey.D:
                        if (x < columns - 1) x++;
                        break;
                    case ConsoleKey.Q:
                        return;
                }
            }
        }
    }
}
