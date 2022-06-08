using static System.Console;
//creating a class that inherits from the subclass ApplicationException of class Exception
class _exception : ApplicationException
{
    //creating a private int variable
    private int code;
    //creating a constructor with 2 arguments(int, string) and the constructor of ApplicationException
    public _exception(int n, string txt) : base(txt)
    {
        //assigning the value of the variable
        code = n;
    }
    //overloading a ToString method that displays the error message and the code of the exception
    public override string ToString()
    {
        string res = Message + "\nCode of error: " + code;
        return res;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //defining a try block
        try
        {
            //throwing an exception
            throw new _exception(123, "Big mistake.");
        }
        //defining a catch blocks in case of an exception from Exception
        catch (Exception e)
        {
            //displaying the exception
            WriteLine(e);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}