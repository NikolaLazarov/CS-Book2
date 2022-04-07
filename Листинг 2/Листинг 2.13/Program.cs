using static System.Console;
//creating a delegate
delegate int myDelegate();
public class Program
{
    //creating a static method that returns a delegate
    static myDelegate calculate(int n)
    {
        //creating a variable and assigning its value
        int count = 0;
        //returns a lambda function
        return () =>
        {
            //adds the argument to the value of the variable
            count += n;
            //returns the variable
            return count;
        };
    }
    public static void Main(string[] args)
    {
        /*creating a delegate instance and assigning 
        its value to the method calculate*/
        myDelegate next = calculate(1);
        //creating a loop that repeats 5 times
        for (int i = 1; i <= 5; i++)
        {
            //displaying the d. instance
            Write(next() + " ");
        }
        WriteLine();

        //assigning the value of the d.i to the method calculate
        next = calculate(3);
        //creating a loop that repeats 5 times
        for (int i = 1; i <= 5; i++)
        {
            //displaying the d. instance
            Write(next() + " ");
        }
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}