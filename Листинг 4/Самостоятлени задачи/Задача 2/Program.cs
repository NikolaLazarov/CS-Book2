using static System.Console;
public class Program
{
    unsafe static void Main(string[] args)
    {
        double g;
        double* var1 = &g;
        var1[0] = 1;
        var1[7] = 3;
        var1[1] = 'A';
        var1[2] = 'A';
        for(int i = 3; i < 7; i++){
            var1[i] = 2;
        }
        for(int i = 0; i < sizeof(double); i++){
            Write("|"+(uint)var1[i]);
        }
        WriteLine("|");
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
