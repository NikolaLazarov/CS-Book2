using static System.Console;
class Program
{
    /*creating 4 different versions of the method
    the method displays the version of the method and displays the arguments value/s*/
    static void show<T>(T n)
    {
        WriteLine("Version #1");
        WriteLine("Argument: {0}", n);
    }
    static void show(int n)
    {
        WriteLine("Version #2");
        WriteLine("Argument: {0}", n);
    }
    static void show<T, U>(T a, U b)
    {
        WriteLine("Version #3");
        WriteLine("First argument: {0}", a);
        WriteLine("Second argument: {0}", b);
    }
    static void show<T>(T a, int b)
    {
        WriteLine("Version #4");
        WriteLine("First argument: {0}", a);
        WriteLine("Second argument: {0}", b);
    }
    static void Main(string[] args)
    {
        //using different versions of the method show
        show('A');
        show(123);
        show<int>('A');
        show<int>(123);
        show('B', "Bravo");
        show('C', 321);
        show<char, int>('C', 321);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}