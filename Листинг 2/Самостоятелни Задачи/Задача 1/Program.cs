using static System.Console;
delegate int myDelegate(char a, string b);
public class Program
{
    public static int meth1(char a, string b)
    {
        int n = 0;
        for (int i = 0; i < b.Length; i++)
        {
            if (b[i] == a)
            {
                n++;
            }
        }
        return n;
    }
    public static int meth2(char a, string b)
    {
        return b.IndexOf(a);
    }
    public static void Main(string[] args)
    {
        myDelegate md = meth1;
        WriteLine(md('e', "The quick brown fox jumped over the lazy dog"));

        md = meth2;
        WriteLine(md('e', "The quick brown fox jumped over the lazy dog"));
`
        WriteLine("Press any key to close...");
    }
}