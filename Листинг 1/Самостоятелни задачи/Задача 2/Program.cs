using static System.Console;
abstract class Base{
    protected string text;
    public abstract int length{
        get;
    }
    public abstract char this[int k]{
        get;
    }
    public abstract void ass(string txt);
    public abstract void show();
}
class myClass : Base{
    public myClass(string txt) : base(){
        text = txt;
    }
    public override int length{
        get{
            return text.Length;
        }
    }
    public override char this[int k]{
        get{
            return text[k];
        }
    }
    public override void ass(string txt){ 
        text = txt;
    }
    public override void show(){
        WriteLine("\""+text+"\"");
    }
}
public class Program
{
    public static  void Main(string[] args)
    {
        myClass A = new myClass("Yokenshnine");
        
        A.show();
        WriteLine(A.length);
        WriteLine(A[6]);
        WriteLine(A[9]);
        
        A.ass("Frank Herbert");
        
        A.show();
        WriteLine(A.length);
        WriteLine(A[3]);
        WriteLine(A[8]);
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}