using static System.Console;
using System.Threading;
class Program
{
    //creating a static method
    static void run()
    {
        WriteLine("Secondary thread begins.");
        int k = 1;
        //creating a loop(infinity)
        while (true)
        {
            WriteLine("Secondary thread: " + k);
            //increment k by 1
            k++;
            //pausing for 2.1 seconds
            Thread.Sleep(2100);
        }
    }
    static void Main(string[] args)
    {
        WriteLine("Main thread begins.");
        //creating a Thread object with run as parameter
        Thread t = new Thread(run);
        //making t a background thread
        t.IsBackground = true;
        //starting the thread
        t.Start();
        //creating a loop(6 times)
        for (char s = 'A'; s <= 'F'; s++)
        {
            WriteLine("Main thread: " + s);
            //pausing for 1 second
            Thread.Sleep(1000);
        }
        WriteLine("Main thread has ended.");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}