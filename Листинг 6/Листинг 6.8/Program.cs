using static System.Console;
using System.Threading;
public class Program
{
    public static void Main(string[] args)
    {
        int size = 20;
        //creating a new char array(length 20) and assigning all its elements to *
        char[] symbs = new char[size];
        for (int i = 0; i < symbs.Length; i++)
        {
            symbs[i] = '*';
            Write("|" + symbs[i]);
        }
        WriteLine("|");

        int first = 0, second = symbs.Length - 1;
        //creating 2 thread object variables
        Thread A, B;
        //creating A to a new Thread object with a lambda expression as parameter
        A = new Thread(() =>
        {
            char start = 'R';
            //infinite loop
            while (true)
            {
                //if(second is higher the first)
                if (second > first)
                {
                    //assign the value
                    symbs[second] = start;
                    //decrement both by 1
                    start--;
                    second--;
                    //pausing for 0.1 seconds
                    Thread.Sleep(100);
                }
                //else abort(doesn't work)
                else
                {
                    Thread.CurrentThread.Abort();
                }
            }
        });
        //assigning it to a new Thread object with lambda expression as parameter
        B = new Thread(() =>
        {
            char start = 'A';
            //infinite loop
            while (true)
            {
                //if(first is lower then second)
                if (first < second)
                {
                    //assigning the value of start
                    symbs[first] = start;
                    //incrementing both by one
                    start++;
                    first++;
                    //pausing for 0.1 seconds
                    Thread.Sleep(100);
                }
                else
                {
                    //abort(doesn't work)
                    Thread.CurrentThread.Abort();
                }
            }
        });

        //starting both thread
        A.Start();
        B.Start();
        //If A is running finish it
        if (A.IsAlive) A.Join();
        //if B is running finish it
        if (B.IsAlive) B.Join();
        //for loop that displays the values of the chars of symbs
        for (int i = 0; i < symbs.Length; i++)
        {
            Write("|" + symbs);
        }
        WriteLine("|");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}