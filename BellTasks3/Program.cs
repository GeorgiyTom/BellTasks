namespace BellTasks3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set size (one number): ");
            int size = int.Parse(Console.ReadLine());
            int[,] print = BuildMatrix(size);
            for (int i = 0; i < print.GetLength(0); i++)
            {
                for (int j = 0; j < print.GetLength(1); j++)
                {
                    Console.Write(print[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static int[,] BuildMatrix(int size)
        {
            int[,] answer = new int[size, size];
            int start = 0;
            int end = size;
            int startValue = size / 2 - 1;
            while(startValue != -1)
            {
                for (int i = start; i < end; i++)
                {
                    for (int j = start; j < end; j++)
                    {
                        if (i == start || j == start || i == end - 1 || j == end - 1)
                        {
                            answer[i, j] = startValue;
                        }
                    }
                }
                start++;
                end--;
                startValue--;
            }
            return answer;
        }
    }
}