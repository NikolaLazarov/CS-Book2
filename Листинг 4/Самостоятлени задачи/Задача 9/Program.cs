using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        String txt = "The quick brown fox jumps over the lazy dog.";
        fixed (char* t = txt)
        {
            for (int i = txt.Length - 1; i > -1; i--)
            {
                WriteLine((uint)&t[i]);
            }
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}