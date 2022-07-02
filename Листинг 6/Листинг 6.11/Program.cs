using static System.Console;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        double s = 0;
        WriteLine("Calculating the sum");
        WriteLine("Control value: " + 2 * Math.E);
        //creating a thread and parameter of a lambda function
        Thread calc = new Thread(() =>
        {
            //calculating Math.E approximately 
            int n = 1;
            double q = 1;
            do
            {
                s += q;
                n++;
                q = n * n;
                for (int i = 1; i <= n; i++)
                {
                    q /= i;
                }
                Thread.Sleep(100);
            } while (true);
        });
        //starting the method
        calc.Start();
        //pausing for 1 second
        Thread.Sleep(1000);
        //making calc a background thread
        calc.IsBackground = true;
        WriteLine("Value of equation: {0}", s);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}