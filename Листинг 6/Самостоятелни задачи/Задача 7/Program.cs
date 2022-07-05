using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        int[,] arr_nums = new int[3, 4];
        Thread doubles = new Thread(() =>
        {
            double s = 0;
            for (int i = 0; i < arr_nums.GetLength(0); i += 2)
            {
                for (int j = 0; j < arr_nums.GetLength(1); j++)
                {
                    arr_nums[i, j] = (int)Math.Pow(2, s);
                    s++;
                }
            }
        });
        Thread triples = new Thread(() =>
        {
            double s = 0;
            for (int i = 1; i < arr_nums.GetLength(0); i += 2)
            {
                for (int j = 0; j < arr_nums.GetLength(1); j++)
                {
                    arr_nums[i, j] = (int)Math.Pow(3, s);
                    s++;
                }
            }
        });

        doubles.Start();
        triples.Start();
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