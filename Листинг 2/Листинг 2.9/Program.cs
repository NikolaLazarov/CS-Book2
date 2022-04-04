using static System.Console;
//creating a delegate
delegate int myDelegate();
public class Program
{
    //creating a method that returns a delegate
    static myDelegate calculate(int n)
    {
        //creating a variable and assigning its value
        int count = 0;
        //returns an anonymous
        return delegate ()
        {
            //adds the argument to the variable
            count += n;
            //returns the variable
            return count;
        };
    }
    public static void Main(string[] args)
    {   //creating a delegate variable and assigning its value to the method calculate
        myDelegate next = calculate(1);
        //creating a loop that repeats 5 times
        for (int i = 1; i <= 5; i++)
        {
            //displays the d.v's anonymous method
            Write(next() + " ");
        }
        WriteLine();

        //assigning the value of the method calculate
        next = calculate(3);
        //creating a loop that repeats 5 times
        for (int i = 1; i <= 5; i++)
        {
            //displays the d.v's anonymous method
            Write(next() + " ");
        }
        WriteLine();

        WriteLine("Press any key to close...");
    }
}