using static System.Console;
struct _struct
{
    private char[] arrChars;
    public _struct(string str)
    {
        arrChars = str.ToCharArray();
    }
    public _struct(int a, char b)
    {
        arrChars = new char[a];
        for (int i = 0; i < arrChars.Length; i++)
        {
            arrChars[i] = b;
        }
    }
    public char this[int a]
    {
        get
        {
            return arrChars[a];
        }
        set
        {
            arrChars[a] = value;
        }
    }
    public override string ToString()
    {
        string str = "";
        foreach (char s in arrChars)
        {
            str += s + " ";
        }
        return str;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        _struct A = new _struct("Bottle");
        _struct B = new _struct(7, 'J');

        WriteLine(A[3]);
        WriteLine(B[6]);

        A[0] = 'M';
        B[4] = 'P';

        WriteLine(A);
        WriteLine(B);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}