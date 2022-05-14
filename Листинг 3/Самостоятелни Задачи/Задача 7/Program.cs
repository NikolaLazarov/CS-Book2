using static System.Console;
struct _struct
{
    private char s;
    public _struct(char t)
    {
        s = t;
    }
    public _struct[] ass(string t)
    {
        _struct[] arrStr = new _struct[t.Length];
        for (int i = 0; i < arrStr.Length; i++)
        {
            arrStr[i] = new _struct(t[i]);
        }
        return arrStr;
    }
    public string asss(_struct[] s)
    {
        string str = "";
        for (int i = 0; i < s.Length; i++)
        {
            str += s[i].s;
        }
        return str;
    }
    public override string ToString()
    {
        string str = "";
        str += s;
        return str;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        _struct A = new _struct();
        _struct[] B = A.ass("Moneky");
        for (int i = 0; i < B.Length; i++)
        {
            Write(B[i] + " ");
        }
        WriteLine();
        string s = A.asss(B);
        WriteLine(s);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}
