using static System.Console;
public class Program
{
    //creating a static method with one string argument
    static void generator(string num)
    {
        WriteLine("Method with argument \"{0}\" begins work.", num);
        //creating a string variable and assigning its variable
        string msg = "The array isn't created!";
        //defining a try block
        try
        {
            //creating a int variable and assigning its value to num converted to int
            int m = Int32.Parse(num);
            //creating an int array with length m
            int[] array = new int[m];
            //assigning the value of msg
            msg = "An array is created: ";
            //creating an array that repeats 5 times 
            for (int i = 0; i <= 4; i++)
            {
                //assigning the element of the corresponding index to 12 / (4 - i)
                array[i] = 12 / (4 - i);
                //adding to the value of msg the element of the corresponding index of the array
                msg += " " + array[i];
            }
        }
        //defining a catch block (IndexOutOfRangeException)
        catch (IndexOutOfRangeException e)
        {
            //displaying the message of the exception
            WriteLine("" + e.Message);
        }
        //defining a finally block
        finally
        {
            //displaying the variable msg
            WriteLine(msg);
        }
        WriteLine("The method finished its work.");
    }
    public static void Main(string[] args)
    {
        //creating a string array consisting of 4 elements
        string[] juk = { "one", "-2", "5", "2" };
        //creating a char array with length 1
        char[] symbs = new char[1];
        //creating a loop juk.Length time
        for (int i = 0; i < juk.Length; i++)
        {
            //defining a try block
            try
            {
                WriteLine("Executing loop №{0}: ", i + 1);
                //defining an inner try block
                try
                {
                    //using the method generator
                    generator(juk[i]);
                    //assigning the index's 1 value to 'A'
                    symbs[1] = 'A';
                }
                //defining a catch block (DivideByZeroException)
                catch (DivideByZeroException e)
                {
                    //displaying the kind of exception and its error message
                    WriteLine("First catch block: " + e.GetType().Name);
                    WriteLine(e.Message);
                }
                //defining a catch block(IndexOutOfRangeException)
                catch (IndexOutOfRangeException e)
                {
                    //displaying the kind of exception and its error message
                    WriteLine("Second catch block: " + e.GetType().Name);
                    WriteLine(e.Message);
                }
                //defining a finally block
                finally
                {
                    //assigning the first element of symbs to A + 1 converted to char
                    symbs[0] = (char)('A' + 1);
                    //displaying the first element
                    WriteLine("Character \'{0}\'", symbs[0]);
                }
            }
            //defining catch block (class Exception)
            catch (Exception e)
            {
                //displaying the kind of exception and its error message
                WriteLine("Outside catch block: " + e.GetType().Name);
                WriteLine(e.Message);
            }
            WriteLine("Loop №{0} ended...\n", i + 1);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}