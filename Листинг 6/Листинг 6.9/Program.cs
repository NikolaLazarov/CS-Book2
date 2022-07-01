using static System.Console;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        //creating a 2d array of 6 rows 9 cols
        int[,] nums = new int[6, 9];
        //creating a Thread object array(size nums.GetLength(0) - 6)
        Thread[] t = new Thread[nums.GetLength(0)];
        //creating a loop(t.Length times)
        for (int i = 0; i < t.Length; i++)
        {
            int p = i;
            //assigning each element of the array yo a new thread object with a lambda expression as parameter
            t[i] = new Thread(() =>
            {
                for (int j = 0; j < nums.GetLength(0); j++)
                {
                    //assigning the value of the element
                    nums[p, j] = (p + 1) * (j + 1);
                    //pausing for 0.1 seconds
                    Thread.Sleep(100);
                }
            });
            //starting that thread
            t[i].Start();
        }

        //creating a loop(t.length times)
        for (int i = 0; i < t.Length; i++)
        {
            //if the element thread is running wait for it to finish then continue 
            if (t[i].IsAlive) t[i].Join();
        }

        //displaying the values of the array via 2 for loop
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Write("{0,-4}", nums[i, j]);
            }
            WriteLine();
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}