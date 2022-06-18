using static System.Console;
public class Program
{
    //creating a static method that returns an int with two arguments(string and int)
    static int find(string txt, char s)
    {
        //creating a loop that loops txt.Length times
        for (int i = 0; i < txt.Length; i++)
        {
            //if the current element of the index is equal to the char argument then return the current i
            if (txt[i] == s)
            {
                return i;
            }
        }
        //throw a Exception and assign it a text message
        throw new Exception("Symbol \'" + s + "\' in the text \"" + txt + "\" isn't contained.");
    }
    public static void Main(string[] args)
    {
        //creating 3 variable from type int char string 
        string txt;
        char s;
        int index;
        //defining a try block
        try
        {
            //assigning the value of the string and char variables by user inputs
            Write("Enter text: ");
            txt = ReadLine();
            Write("Enter symbol: ");
            s = (char)Read();
            //assigning the value of the int variable to the outcome of find
            index = find(txt, s);
            //displaying the variable int
            WriteLine("Index of symbol: {0}", index);
        }
        //defining a catch in case an exception from class Exception
        catch (Exception e)
        {
            //displaying the error message of the exception
            WriteLine(e.Message);
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}