using static System.Console;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        int t = 0;
        int times = 10;
        Random rnd = new Random();
        Thread Check1 = new Thread(() =>
        {
            int k = 0;
            while (k < times)
            {
                Thread.Sleep(750);
                if (t % 2 == 1)
                {
                    WriteLine("t is odd");
                }
                else
                {
                    WriteLine("t isn't odd");
                }
                k++;
            }
        });
        Thread Check2 = new Thread(() =>
        {
            int k = 0;
            while (k < times)
            {
                Thread.Sleep(750);
                if (t % 3 == 0)
                {
                    WriteLine("t can be divided by 3");
                }
                else
                {
                    WriteLine("t can't be divided by 3");
                }
                k++;
            }
        });

        Check1.Start();
        Check2.Start();
        for (int i = 0; i < times; i++)
        {
            t = rnd.Next(10);
            WriteLine("Current value of t: {0}", t);
            Thread.Sleep(750);
        }



        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}