using static System.Console;
using System.Threading;
class _class
{
    public int state = 0;
}
class Program
{
    static void run(bool type, _class obj)
    {
        int val, k = 1;
        Random rnd = new Random();
        while (k <= 5)
        {
            lock (obj)
            {
                val = obj.state;
                WriteLine("{0,4}: value: {1,2} has been read", Thread.CurrentThread.Name, val);
                Thread.Sleep(rnd.Next(1000, 3001));
                if (type) val++;
                else val--;
                obj.state = val;
                WriteLine("{0,4}: value {1,2} has been assigned", Thread.CurrentThread.Name, obj.state);
                k++;
            }
        }
    }
    static void Main(string[] args)
    {
        _class obj = new _class();
        Thread up = new Thread(() => run(true, obj));
        up.Name = "UP";
        Thread down = new Thread(() => run(false, obj));
        down.Name = "DOWN";
        up.Start();
        down.Start();


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}