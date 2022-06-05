using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        WriteLine("Execution of the brogram begins");
        //creating variables and displaying them
        int A = 10, B = 0;
        WriteLine("Variable A=" + A);
        WriteLine("Variable B=" + B);
        //using s try funcion to execute a/b
        try
        {
            WriteLine("Calculating: A/B");
            WriteLine("Outcome: " + A / B);
            WriteLine("The calculations have been concluded");
        }
        //in case of an exception
        catch (Exception e)
        {
            //displaying information about the exeption
            WriteLine("An error appeared!");
            //the type of the exception
            WriteLine("Type of error: " + e.GetType().Name);
            //description of the exception
            WriteLine("Description: " + e.Message);
            //the program in which the exception accured
            WriteLine("Program: " + e.Source);
            //the method in which the exception eccured
            WriteLine("Method: " + e.TargetSite.Name);
            //the place of the error
            WriteLine("Place of error: " + e.TargetSite);
        }
        WriteLine("The program has concluded");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}