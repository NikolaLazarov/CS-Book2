using static System.Console;

public class Program
{
    unsafe static void Main(string[] args)
    {
        //creating a variable from class String and assigning its value
        String txt = "Programming in C#";
        //displaying the variable
        WriteLine(txt);

        //creating a fixed function
        fixed (char* p = txt)
        {
            /*creating a loop that displays the values 
            of the variable and assigns new ones*/
            for (int i = 0; p[i] != '\0'; i++)
            {
                Write("|" + p[i]);
                p[i] = (char)('A' + i);
            }
            WriteLine("|");
        }
        //displaying the variable
        WriteLine(txt);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
