using static System.Console;
struct A
{
    public string s;
    public A(string s)
    {
        this.s = s;
    }
    public B ass(int n)
    {
        return new B(s[n]);
    }
}
struct B
{
    public char s;
    public B(char s)
    {
        this.s = s;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        A A = new A("Water");
        B B = A.ass(0);
        WriteLine(B.s);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}