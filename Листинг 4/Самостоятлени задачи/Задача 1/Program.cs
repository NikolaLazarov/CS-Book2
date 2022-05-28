using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        int n;
        int* i = &n;
        int* p = &n + 4;

        i[0] = 1;
        i[1] = 'A';
        i[2] = 'A';
        i[3] = 1;
        for (int k = 0; k < p - i; k++)
        {
            Write("|" + (uint)i[k]);
        }
        WriteLine("|");

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}