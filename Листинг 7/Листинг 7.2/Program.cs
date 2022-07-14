using static System.Console;
class Program
{
    //creating a static template method(2 arguments)
    static void show<T, U>(T a, U b)
    {
        //displaying the arguments
        WriteLine("First argument: {0}", a);
        WriteLine("Second argument: {0}", b);
    }
    static void Main(string[] args)
    {
        //using the method show in various ways
        show(100, 'A');
        show('B', "Bravo");
        show('C', 'D');
        show<int, char>('C', 'D');

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}