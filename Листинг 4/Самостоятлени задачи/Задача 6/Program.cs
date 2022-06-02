using static System.Console;
class _class
{
    public int num;
}
public class Program
{
    unsafe static void Main(string[] args)
    {
        _class A = new _class();
        fixed (int* n = &A.num)
        {
            n[0] = 'A';
            n[1] = 'A';
            n[2] = 'B';
            n[3] = 'B';
            for (int i = 0; i < sizeof(int); i++)
            {
                Write((char)(uint)n[i] + " ");
            }
            WriteLine();
        }


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}