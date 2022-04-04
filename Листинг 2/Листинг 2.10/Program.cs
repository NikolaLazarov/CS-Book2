﻿using static System.Console;
//creating a delegate
delegate double Powers(double x);
public class Program
{
    //creating a method that returns a delegate
    static Powers maker(int n)
    {
        //creating a delegate variable
        Powers meth;
        //assigning the value of the d.v to an anonymous method
        meth = delegate (double x)
       {
            //creating a variable and setting its value
            double s = 1;
            //creating a loop that repeats n times
            for (int i = 1; i <= n; i++)
           {
                //multiplying s by the argument x
                s *= x;
           }
            //returns s
            return s;
       };
        //returns the delegate
        return meth;
    }
    public static void Main(string[] args)
    {
        //creating 3 delegates and setting their values to the method maker
        Powers sqr = maker(2);
        Powers cube = maker(3);
        Powers tesseract = maker(4);

        //creating a loop that repeats 5 times
        for (int i = 1; i <= 5; i++)
        {
            //displays the values of i and the delegates
            WriteLine("{0,2} : {1,5} {2,5} {3,5}", i, sqr(i), cube(i), tesseract(i));
        }

        WriteLine("Press any key to close...");
    }
}