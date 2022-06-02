using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        double var1;
        double* var2 = &var1;
        byte*[] arr = new byte*[sizeof(double)];
        for (int i = 0; i < sizeof(double); i += 2)
        {
            arr[i] = (byte*)&var2[i];
            if (i == 6)
            {
                i = 1;
            }
        }
        for (int i = 0; i < sizeof(double); i++)
        {
            Write((byte)&arr[i][i] + " ");
        }

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}