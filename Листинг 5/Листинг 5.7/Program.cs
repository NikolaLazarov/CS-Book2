using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        //creating 3 byte variables and assigning value to 2 of them
        byte a = 100, b = 200, c;
        //defining a try block
        try
        {
            //assigning the value of c to the checked function
            c = checked((byte)(a + b));
        }
        //defining a catch block incase of an OverflowException
        catch (OverflowException e)
        {
            //displaying what cause the exception and its error message
            WriteLine("There is an error: " + (a + b));
            WriteLine(e.Message);
        }
        //assigning the value of c to the unchecked function
        c = unchecked((byte)(a + b));
        WriteLine("There isn't an error: " + c);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}