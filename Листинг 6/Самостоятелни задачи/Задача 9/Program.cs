using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        double Control_Vlaue = 3 * Math.Pow(Math.E, 2) - 1;
        double sum = 0;
        WriteLine("Control value: {0}", Control_Vlaue);
        Thread Sigma = new Thread(() =>
        {
            double n = 1;
            while (true)
            {
                sum += Math.Pow(2, n) * (n + 1) / Factorial(n);
                n++;
                Thread.Sleep(100);
            }

        });
        Sigma.Start();
        Sigma.IsBackground = true;
        Thread.Sleep(1000);
        WriteLine("Our value: {0}", sum);
        double Factorial(double s)
        {
            double sum = 1;
            for (int i = 1; i <= s; i++)
            {
                sum *= i;
            }
            return sum;
        }
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}