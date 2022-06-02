using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        int[] num = new int[2];
        fixed (int* a = &num[0])
        {
            int u = 1;
            for (int i = 0; i < sizeof(int); i++)
            {
                a[i] = u;
                u++;
            }
        }
        fixed (int* a = &num[1])
        {
            int u = 1;
            for (int i = 0; i < sizeof(int); i++)
            {
                a[i] = u;
                u++;
            }
        }
        for (int i = 0; i < num.Length; i++)
        {
            Write(num[i] + " ");
        }
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}