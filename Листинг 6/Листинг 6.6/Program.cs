using static System.Console;
using System.Threading;
class Program
{
    //creating a static field
    static int state = 0;
    //creating a static method with bool parameter
    static void run(bool type)
    {
        //creating a Thread object and assigning its value to the current thread
        Thread t = Thread.CurrentThread;
        WriteLine("Thread " + t.Name + " has started.");
        //creating a loop(infinity)
        while (true)
        {
            //if(type = true)increment by 1
            if (type) state++;
            //else decrement by 1
            else state--;
            //pause for 1 second
            Thread.Sleep(1000);
        }
    }
    static void Main(string[] args)
    {
        //creating a Thread class and assigning it to the current thread
        Thread t = Thread.CurrentThread;
        //assigning the name of the object to Base
        t.Name = "Base";
        WriteLine("Main thread {0} has started.", t.Name);
        WriteLine("Starting value: {0}", state);

        /*creating 2 Thread objects with run as 
        parameters(run has different parameter in the 2 threads)*/
        Thread up = new Thread(() => run(true));
        Thread down = new Thread(() => run(false));

        //assigning the name of up to Alpha
        up.Name = "Alpha";
        //assigning its property to Highest
        up.Priority = ThreadPriority.Highest;
        //assigning the name of down to Beta
        down.Name = "Beta";
        //assigning its property to Lowest
        down.Priority = ThreadPriority.Lowest;

        //making both Threads background Threads
        up.IsBackground = true;
        down.IsBackground = true;
        //starting the Threads
        up.Start();
        down.Start();

        //pausing for 5 seconds
        Thread.Sleep(5000);

        WriteLine("End value: {0}", state);
        WriteLine("Main thread {0} has ended.", t.Name);


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}