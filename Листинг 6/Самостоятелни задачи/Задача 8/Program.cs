using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        ConsoleColor[] colors = new ConsoleColor[3];
        colors[0] = ConsoleColor.Blue;
        colors[1] = ConsoleColor.Red;
        colors[2] = ConsoleColor.Green;
        Random rnd = new Random();
        char[,] char_array = new char[10, 10];
        Thread[] row_threads = new Thread[char_array.GetLength(0)];
        for (int n = 0; n < row_threads.Length; n++)
        {
            row_threads[n] = new Thread(() =>
            {
                for (int i = n; i < char_array.GetLength(0); i++)
                {
                    for (int j = 0; j < char_array.GetLength(1); j++)
                    {
                        char_array[i, j] = (char)rnd.Next(65, 91);
                    }
                }
            });
            row_threads[n].Start();
        }

        for (int i = 0; i < char_array.GetLength(0); i++)
        {
            for (int j = 0; j < char_array.GetLength(1); j++)
            {
                Thread.Sleep(20);
                char_array[i, j] = (char)rnd.Next(65, 91);
                Console.ForegroundColor = colors[rnd.Next(0, 3)];
                Write(char_array[i, j] + " ");
            }
            WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.White;
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
