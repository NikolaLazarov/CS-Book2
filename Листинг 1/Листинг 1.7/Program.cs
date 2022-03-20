using static System.Console;
//creating an interface
interface First
{
    //creating a method
    void show();
}
//creating an interface
interface Second
{
    //creating a method
    void show();
}
//creating a class that inherits from two interfaces
class myClass : First, Second
{
    //creating a method
    public void show()
    {
        //displaying text
        WriteLine("Object of the class myClass.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a class object
        myClass obj = new myClass();
        //creating a interface variable and assigning its value to obj
        First A = obj;
        //creating a interface variable and assigning it value to obj
        Second B = obj;

        //using the method show from in 3 different ways 
        obj.show();
        A.show();
        B.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}