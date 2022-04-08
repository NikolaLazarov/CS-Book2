using static System.Console;
//creating a delegate that returns a double
delegate double Powers(double x);
public class Program
{
    //creating a static class that returns a delegate
    static Powers maker(int n)
    {
        //creating a delegate instance 
        Powers meth;
        //assigning the value of the instance to a lambda function
        meth = x =>
        {
            //creating a variable and assigning its value
            double s = 1;
            //creating a loop that repeats argument number of times
            for (int i = 1; i <= n; i++)
            {
                //multiplying the value of s to the argument of the d.i.
                s *= x;
            }
            //returns s
            return s;
        };
        //returns the d.i.
        return meth;
    }
    public static void Main(string[] args)
    {
        //creating 2 delegates and assigning their values to the method maker
        Powers sqr = maker(2);
        Powers cube = maker(3);
        //creating a loop that repeats 5 times
        for (int i = 1; i <= 5; i++)
        {
            //displaying values
            WriteLine("{0,2}:{1,5}{2,5}{3,5}", i, sqr(i), cube(i), maker(4)(i));
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}