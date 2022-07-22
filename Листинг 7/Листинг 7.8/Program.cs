using static System.Console;
//creating a template interface
interface my_interface<X, Y>
{
    //method with 2 arguments
    void set(X a, Y b);
    //method
    void show();
}
//creating a template class that inherites from my_interface
class Alpha<X, Y> : my_interface<X, Y>
{
    //creating 2 fields
    X first;
    Y second;
    //creating the method set(assigns the values of the fields)
    public void set(X a, Y b)
    {
        first = a;
        second = b;
    }
    //creating the method show(displays the value of the fields)
    public void show()
    {
        WriteLine("Fields: {0}|{1}", first, second);
    }
}
//creating a template class that inherites from my_interface
class Beta<Y> : my_interface<int, Y>
{
    //creating 2 fields
    int first;
    Y second;
    //creating the method set(assigns the values of the fields)
    public void set(int a, Y b)
    {
        first = a;
        second = b;
    }
    //creating the method show(displays the value of the fields) 
    public void show()
    {
        WriteLine("Fields: {0}|{1}", first, second);
    }
}
//creating a template class that inherites from my_interface
class Gama : my_interface<int, char>
{
    //creating 2 fields
    int first;
    char second;
    //creating the method set(assigns the values of the fields)
    public void set(int a, char b)
    {
        first = a;
        second = b;
    }
    //creating the method show(displays the value of the fields)
    public void show()
    {
        WriteLine("Fields: {0}|{1}", first, second);
    }
}
class Program
{
    static void Main(string[] args)
    {
        WriteLine("First object");
        //creating a class object
        Alpha<string, double> A = new Alpha<string, double>();
        //creating an interface and assigning its value to the class object
        my_interface<string, double> Ra = A;
        //using methods from the class object and interface in different ways
        A.set("Alpha", 100.0);
        Ra.show();
        Ra.set("alpha", 150.0);
        A.show();
        WriteLine("Second object");
        //creating a class object
        Beta<string> B = new Beta<string>();
        //creating an interface and assigning its value to the class object
        my_interface<int, string> Rb = B;
        //using methods from the class object and interface in different ways
        B.set(200, "Bravo");
        Rb.show();
        Rb.set(250, "Bravo");
        B.show();
        WriteLine("Third object");
        //creating a class object
        Gama G = new Gama();
        //creating an interface and assigning its value to the class object
        my_interface<int, char> Rg = G;
        //using methods from the class object and interface in different ways
        G.set(300, 'G');
        Rg.show();
        Rg.set(350, 'D');
        G.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}