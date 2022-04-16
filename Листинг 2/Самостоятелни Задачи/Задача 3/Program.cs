using static System.Console;
delegate char myDelegate();
class myClass{
    public string text;
    private bool yoshi;
    private myDelegate md;
    public myClass(string text, bool yoshi){
        this.text = text;
        this.yoshi = yoshi;
    }
    public myDelegate prop{
        get{
            if(yoshi == true){
                return () =>{
                    return text[0];
                };
            }else{
                return delegate(){
                    return text[text.Length - 1];
                };
            }
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        myClass A = new myClass("Cat",true);
        myClass B = new myClass("Dog",false);

        char[] chars = new char[2];
        chars[0] = A.prop();
        chars[1] = B.prop();

        for(int i = 0; i < chars.Length; i++){
            Write(chars[i]+"\n");
        }
        WriteLine("\a");
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}