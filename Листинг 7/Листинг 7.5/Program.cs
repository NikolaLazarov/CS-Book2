using static System.Console;
//creating a class
class my_class
{
    //creating a public string filed
    public string text;
    //creating a constructor that assigns the value of the field
    public my_class(string s)
    {
        text = s;
    }
    //creating a method with 1 argument
    public void show<X>(X arg)
    {
        //displays the text field and the argument of the method
        WriteLine(text + ": " + arg);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //creating 2 class objects
        my_class A = new my_class("Alpha");
        my_class B = new my_class("Beta");
        //using the method show from in various ways
        A.show(100);
        B.show(200);
        A.show('A');
        //using the method show form in various ways
        B.show<char>('B');
        B.show<int>('B');

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}