using static System.Console;
//creating a template class
class Alpha<X>
{
    //creating a field 
    public X code;
    //creating a constructor that assigns the value of field
    public Alpha(X a)
    {
        code = a;
    }
    //creating a method that displays the type of template and its value
    public void show()
    {
        WriteLine("Filed of type {0}: {1}", typeof(X).Name, code);
    }
}
//creating a template class
class Beta<X, Y>
{
    //creating 2 fields
    public X first;
    public Y second;
    //creating a constructor that assigns the value of the fields
    public Beta(X a, Y b)
    {
        first = a;
        second = b;
    }
    //creating a method that displays the type of the template and the fields
    public void show()
    {
        WriteLine("First field of type {0}: {1}", typeof(X).Name, first);
        WriteLine("Second field of type {0}: {1}", typeof(Y).Name, second);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //creating 3 Alpha objects with different template types
        Alpha<int> A = new Alpha<int>(123);
        Alpha<char> B = new Alpha<char>('A');
        Alpha<string> C = new Alpha<string>("Alpha");
        //using the method show from A,B,C
        A.show();
        B.show();
        C.show();
        WriteLine();

        //creating 3 Beta objects with different template types
        Beta<int, char> a = new Beta<int, char>(123, 'A');
        Beta<char, char> b = new Beta<char, char>('B', 'C');
        Beta<string, bool> c = new Beta<string, bool>("Beta", true);
        //using the method show form a,b,c
        a.show();
        b.show();
        c.show();
        WriteLine();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}