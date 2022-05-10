using static System.Console;
struct NIGHT
{
    private int numF;
    private char charF;
    private string stringF;
    public NIGHT(int a, char b, string c)
    {
        numF = a;
        charF = b;
        stringF = c;
    }
    public NIGHT(int a, string c)
    {
        numF = a;
        charF = '☻';
        stringF = c;
    }
    public NIGHT(int a)
    {
        numF = a;
        charF = '☻';
        stringF = "♣";
    }
    public void show()
    {
        WriteLine(numF);
        WriteLine(charF);
        WriteLine(stringF);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        NIGHT A = new NIGHT(7, 'R', "Knight");
        NIGHT B = new NIGHT(3, "Deltoid");
        NIGHT C = new NIGHT(5);

        A.show();
        B.show();
        C.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
