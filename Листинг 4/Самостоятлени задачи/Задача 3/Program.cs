using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        Random rnd1 = new Random();
        Random rnd2 = new Random();
        int a = rnd1.Next(1, 9), b = rnd2.Next(1, 9), c;
        int* add = &c;
        add[1] = b;
        add[0] = b;
        add[2] = a;
        add[3] = a;
        WriteLine(a+" "+b);
        for (int i = 0; i < sizeof(int); i++)
        {
            Write((uint)add[i] + " ");
        }
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}