using static System.Console;
public class Program
{
    //creating a static method that returns a double with 2 double vars as arguments
    static double solve(double A, double B)
    {
        //if the argument A isn't equal to 0, divide B and A
        if (A != 0) return B / A;
        //creating a string variable
        string msg;
        //if the argument B is equal to 0, assign the value of msg to something
        if (B == 0) msg = "Every number is a solution.";
        //else assign it to something else
        else msg = "There is no solution.";
        //throw an ArithmeticException with an error message msg
        throw new ArithmeticException(msg);
    }
    public static void Main(string[] args)
    {
        //creating 3 double variables
        double A, B, x;
        WriteLine("Solution of the equation Ax = B");
        //defining a try block
        try
        {
            //assigning the value of A and B by user inputs
            Write("Number A: ");
            A = double.Parse(ReadLine());
            Write("number B: ");
            B = double.Parse(ReadLine());
            //assigning the value of x to the method solve with arguments A and B
            x = solve(A, B);
            //displaying x
            WriteLine("Solution x = {0}", x);
        }
        //defining a catch block incase of an Exception
        catch (Exception e)
        {
            //displaying the error message of the exception
            WriteLine(e.Message);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}