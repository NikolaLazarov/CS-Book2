using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        Random rnd = new Random();
        int a = rnd.Next(1, 9);
        int* b = &a;
        int f = (int)&b[0], s = (int)&b[1], t = (int)&b[2], fo = (int)&b[3];
        b[0] = fo;
        b[1] = f;
        b[2] = s;
        b[3] = t;
        for (int i = 0; i < sizeof(int); i++)
        {
            Write((uint)b[i] + " ");
        }
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}