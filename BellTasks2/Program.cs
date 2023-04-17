using System;

namespace BellTasks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры куба");
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,,] cube = new int[size[0], size[1], size[2]];
            Console.WriteLine("Введите данные матрицы построчно через пробелы");
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    string enterString = Console.ReadLine();
                    string[] massiveString = enterString.Split(new Char[] { ' ' }); //Чтение данных
                    for (int k = 0; k < massiveString.Length; k++)
                    {
                        cube[i, j, k] = int.Parse(massiveString[k]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Предмаксимальное значение равно: {FindPreMaximum(cube)}");
        }
        public static int FindPreMaximum(int[,,] cube)
        {
            int preMaximum = int.MinValue + 1;
            int maximum = int.MinValue;
            for(int i = 0; i < cube.GetLength(0); i++)
            {
                for(int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        if (i == j && j == k)
                        {
                            if (cube[i, j, k] > maximum)
                            {
                                preMaximum = maximum;
                                maximum = cube[i, j, k];
                            }
                            else if (cube[i, j, k] > preMaximum)
                                preMaximum = cube[i, j, k];
                        }
                        else if (cube[cube.GetLength(0) - 1 - i, cube.GetLength(1) - 1 - j, k] > maximum)
                        {
                            preMaximum = maximum;
                            maximum = cube[cube.GetLength(0) - 1 - i, cube.GetLength(1) - 1 - j, k];
                        }
                        else if (cube[cube.GetLength(0) - 1 - i, cube.GetLength(1) - 1 - j, k] > preMaximum)
                            preMaximum = cube[cube.GetLength(0) - 1 - i, cube.GetLength(1) - 1 - j, k];
                        else if (cube[cube.GetLength(0) - 1 - i, j, k] > maximum)
                        {
                            preMaximum = maximum;
                            maximum = cube[cube.GetLength(0) - 1 - i, j, k];
                        }
                        else if (cube[cube.GetLength(0) - 1 - i, j, k] > preMaximum)
                            preMaximum = cube[cube.GetLength(0) - 1 - i, j, k];
                        else if (cube[i, cube.GetLength(1) - 1 - j, k] > maximum)
                        {
                            preMaximum = maximum;
                            maximum = cube[cube.GetLength(0) - 1 - i, j, k];
                        }
                        else if (cube[i, cube.GetLength(1) - 1 - j, k] > maximum)
                            preMaximum = cube[i, cube.GetLength(1) - 1 - j, k];
                    }
                }
            }
            if (preMaximum != int.MinValue + 1)
                return preMaximum;
            else if (maximum != int.MinValue)
                return maximum;
            throw new ArgumentException(message: "Некорректные данные");
        }
    }
}