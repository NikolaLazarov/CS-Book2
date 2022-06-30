using static System.Console;
using System.Threading;
//creating a class
class _class
{
    //creating a public int field and assigning its value
    public int state = 0;
}
class Program
{
    //creating a static method with a bool and _class arguments
    static void run(bool type, _class obj)
    {
        //creating 2 variables and assigning a value to the second one
        int val, k = 1;
        //creating a new Random object
        Random rnd = new Random();
        //creating a loop(5 times)
        while (k <= 5)
        {
            //locking obj
            lock (obj)
            {
                //assigning the value of val to the field of obj
                val = obj.state;
                WriteLine("{0,4}: value: {1,2} has been read", Thread.CurrentThread.Name, val);
                //pausing
                Thread.Sleep(rnd.Next(1000, 3001));
                if (type) val++;
                else val--;
                //assigning the value of the filed of obj to val
                obj.state = val;
                WriteLine("{0,4}: value {1,2} has been assigned", Thread.CurrentThread.Name, obj.state);
                k++;
            }
        }
    }
    static void Main(string[] args)
    {
        //creating 1 class objects and 2 thread objects 
        _class obj = new _class();
        Thread up = new Thread(() => run(true, obj));
        //assigning the names of the thread objects
        up.Name = "UP";
        Thread down = new Thread(() => run(false, obj));
        down.Name = "DOWN";

        //starting the threads
        up.Start();
        down.Start();


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
