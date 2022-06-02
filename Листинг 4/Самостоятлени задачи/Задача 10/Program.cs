using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        int k = 0;
        int* n = &k;
        char** s = (char**)&n;
        *s[0] = 'A';
        s[1] = s[0];
        *s[2] = 'B';
        s[3] = s[2];
        for (int i = 0; i < sizeof(int); i++)
        {
            Write("Char and int pointer: " + (uint)&s[i] + " " + (uint)n[i] + "\n");
        }
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}