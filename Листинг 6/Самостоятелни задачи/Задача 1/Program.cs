using static System.Console;
using System.Threading;
class Program
{
    static void Factorial(int n)
    {
        int t = 1;
        for (int i = 1; i <= n; i++)
        {
            t *= i;
        }
        WriteLine("{0}! = {1}", n, t);
    }
    static void Double_Factorial(int n)
    {
        int t = 1;
        int k;
        if (n % 2 == 0) k = 2;
        else k = 1;
        for (int i = k; i <= n; i += 2)
        {
            t *= i;
        }
        Thread.Sleep(1000);
        WriteLine("{0}!! = {1}", n, t);
    }
    static void Fib_Nums(int n)
    {
        int[] fibnum = new int[n];
        int prev = 0;
        int curr = 1;
        Thread.Sleep(1000);
        Write("First {0} Fibonacci numbers: ", n);
        for (int i = 0; i < fibnum.Length; i++)
        {
            fibnum[i] = curr;
            int h = curr;
            curr = curr + prev;
            prev = h;
            Thread.Sleep(500);
            Write(fibnum[i] + " ");
        }
        WriteLine();
    }
    static void Main(string[] args)
    {
        int i = 6;
        Thread A = new Thread(() => Factorial(i));
        Thread B = new Thread(() => Double_Factorial(i));
        Thread C = new Thread(() => Fib_Nums(i));

        A.Start();
        if (A.IsAlive) A.Join();
        B.Start();
        if (B.IsAlive) B.Join();
        C.Start();
        if (C.IsAlive) C.Join();


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}