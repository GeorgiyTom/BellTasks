using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellTasks1
{
    internal class Task1
    {
        private double[,] matrix;
        private readonly double centralElement;
        public static int Rows { set; private get; }
        public static int Cols { set; private get; }
        private double minimum = double.MaxValue;
        public Task1(double[,] matrix, int rows)
        {
            this.matrix = matrix;  
            Rows = rows;
            Cols = rows;
            this.centralElement = Math.Ceiling(Rows / 2.0); //Индекс центрального элемента
        }
        public double FindMinimum()
        {
            if (Rows % 2 != 0)
            {
                for (int i = 0; i < Rows; i++)
                {
                    double currentVal = matrix[i, Cols - 1 - i];
                    if (currentVal < minimum && i != centralElement - 1)
                        minimum = currentVal;

                }
            }
            else
            {
                for (int i = 0; i < Rows; i++)
                {
                    double currentVal = matrix[i, Cols - 1 - i];
                    if (currentVal < minimum)
                        minimum = currentVal;

                }
            }
            return minimum;
        }
        
    }
}
