using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        //defining a try block
        try
        {
            //defining an inner try block
            try
            {
                WriteLine("There will be an error now.");
                //generating an ArithmeticException and defining its error message
                throw new ArithmeticException("Some error.");
            }
            //defining a catch block for a ArithmeticException
            catch (ArithmeticException e)
            {
                //displaying the error massage of the exception
                WriteLine(e.Message);
                //generating another ArithmeticException
                throw;
            }
        }
        //defining a catch block for a ArithmeticException
        catch (ArithmeticException e)
        {
            //displaying the error massage of the exception
            WriteLine("Once more:\n" + e.Message);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}