using static System.Console;
interface myitf
{
    int show();
}
class Alpha : myitf
{
    private int num;
    public Alpha(int num)
    {
        this.num = num;
    }
    public int show()
    {
        int n = -1;
        int sum = 0;
        for (int i = 0; i < num; i++)
        {
            n += 2;
            sum += n;
        }
        return sum;
    }
}
class Beta : myitf
{
    private int num;
    public Beta(int num)
    {
        this.num = num;
    }
    public int show()
    {
        int n = 0;
        int sum = 0;
        for (int i = 0; i < num; i++)
        {
            n += 2;
            sum += n;
        }
        return sum;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Alpha A = new Alpha(7);
        WriteLine(A.show());

        Beta B = new Beta(9);
        WriteLine(B.show());

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}