using static System.Console;
using System.Threading;
class Program
{
    //creating a static method(arguments: 2d array, int, Random object)
    static void fill(int[,] a, int i, Random rnd)
    {
        //creating a thread object and assigning it null
        Thread t = null;
        if (i < a.GetLength(0) - 1)
        {
            //assigning t to a new thread with parameter lambda expression
            t = new Thread(() =>
            {
                //method fill
                fill(a, i + 1, rnd);
            });
            //starting the thred
            t.Start();
        }
        //creating a loop(a.GetLength(1) times) fills the elements of the array
        for (int k = 0; k < a.GetLength(1); k++)
        {
            a[i, k] = k * 10 + rnd.Next(10);
        }
        //if t isn't null and its running, wait for it to finish then continue
        if (t != null && t.IsAlive) t.Join();
    }
    static void Main(string[] args)
    {
        //creating a 2d array with 6 rows and 9 cols
        int[,] nums = new int[6, 9];
        //creating an rnd object
        Random rnd = new Random();
        //using the method fill
        fill(nums, 0, rnd);
        //displaying the values of the elements of the array via 2 for loops
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