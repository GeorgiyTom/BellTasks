using System;

namespace BellTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите матрицу N*N - два числа через пробел");
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double[,] matrix = new double[size[0], size[1]];
            if (size[0] != size[1])
            {
                Console.WriteLine("Неккоректный размер!");
                return;
            }
            Console.WriteLine("Вводите значения матрицы построчно (через пробел)");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string enterString = Console.ReadLine();
                string[] massiveString = enterString.Split(new Char[] { ' ' });
                for (int j = 0; j < massiveString.Length; j++)
                {
                    matrix[i, j] = double.Parse(massiveString[j]);
                }
            }
            BellTasks1.Task1 task = new BellTasks1.Task1(matrix, size[0]);
            Console.WriteLine($"Минимальное значение на побочной диагонали равно: {task.FindMinimum()}");
        }
    }
}