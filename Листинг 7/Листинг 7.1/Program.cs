using static System.Console;
//creating a class
class my_class
{
    //creating a public int field
    public int code;
    //creating a constructor that assigns the value of the field
    public my_class(int n)
    {
        code = n;
    }
    //overloading a ToString method
    public override string ToString()
    {
        //returns the value of the field
        return "Field: " + code;
    }
    //creating an implicit operator method
    public static implicit operator int(my_class obj)
    {
        //returns the value of the field of the parameter
        return obj.code;
    }
    //creating an implicit operator method
    public static implicit operator my_class(int n)
    {
        //returns a new object of my_class
        return new my_class(n);
    }
}
class Program
{
    //creating a static template method
    static void show<T>(T arg)
    {
        //returns the type of parameter 
        WriteLine(typeof(T).Name);
        //returns the argument
        WriteLine(arg);
        WriteLine("------------------------------");
    }
    static void Main(string[] args)
    {
        //using the method show in various ways
        show(100);
        show<int>(200);
        show<double>(300);
        show<my_class>(400);
        show('A');
        show<char>('B');
        show<int>('C');
        show("Alpha");
        //creating a class
        my_class obj = new my_class(500);
        //using the method show in various ways
        show(obj);
        show<int>(obj);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}