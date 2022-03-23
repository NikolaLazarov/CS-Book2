using static System.Console;
interface myItf1
{
    string text
    {
        get;
    }
}
interface myItf2
{
    string text
    {
        get;
    }
}
class myClass : myItf1, myItf2
{
    public string text
    {
        get
        {
            string s = "Properties form myClass.";
            return s;
        }
    }
    string myItf1.text
    {
        get
        {
            string s = "Property from myItf1.";
            return s;
        }
    }
    string myItf2.text
    {
        get
        {
            string s = "Property from myItf2.";
            return s;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass obj = new myClass();
        WriteLine(obj.text);

        myItf1 A = obj;
        WriteLine(A.text);

        myItf2 B = obj;
        WriteLine(B.text);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}