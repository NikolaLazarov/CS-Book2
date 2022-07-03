using static System.Console;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        int array_row_length = 4;
        int array_col_length = 5;
        int[,] arr_nums = new int[array_row_length, array_col_length];
        Thread twos = new Thread(() =>
        {
            double s = 0;
            for (int i = 0; i < arr_nums.GetLength(0); i += 2)
            {
                for (int j = 0; j < array_col_length; j++)
                {
                    arr_nums[i, j] = (int)Math.Pow(2, s);
                    s++;
                }

            }
        });
        Thread threes = new Thread(() =>
        {
            double s = 0;
            for (int i = 1; i < array_row_length; i += 2)
            {
                for (int j = 0; j < arr_nums.GetLength(1); j++)
                {
                    arr_nums[i, j] = (int)Math.Pow(3, s);
                    s++;
                }
            }
        });
        twos.Start();
        threes.Start();

        for (int i = 0; i < arr_nums.GetLength(0); i++)
        {
            for (int j = 0; j < arr_nums.GetLength(1); j++)
            {
                Thread.Sleep(100);
                Write(arr_nums[i, j] + " ");
            }
            WriteLine();
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}