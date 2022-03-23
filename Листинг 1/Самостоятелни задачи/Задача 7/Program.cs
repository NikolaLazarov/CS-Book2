using static System.Console;
interface myItf1
{
    int number
    {
        get;
        set;
    }
    void meth();
}
interface myItf2
{
    string text
    {
        get;
        set;
    }
    void meth();
}
class myClass : myItf1, myItf2
{
    int a;
    string t = "";
    public int number
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
        }
    }
    public string text
    {
        get
        {
            return t;
        }
        set
        {
            t = value;
        }
    }
    public void meth()
    {
        WriteLine(number + "\n" + text);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass obj = new myClass();

        obj.number = 1234;
        obj.text = "Flask";

        WriteLine(obj.number);
        WriteLine(obj.text);

        obj.number = 8342;
        obj.text = "Desk";

        obj.meth();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}