using static System.Console;
class Program
{
    static void swapValues<x>(x a, x b)
    {
        WriteLine($"{a}|{b}");
        x temp = a;
        a = b;
        b = temp;
        WriteLine($"{a}|{b}");
    }
    static void Main(string[] args)
    {
        swapValues<int>(7, 9);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}