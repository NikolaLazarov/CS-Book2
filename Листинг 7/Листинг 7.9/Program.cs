using static System.Console;
//creating an abstract template class
abstract class base_class<x, y>
{
    //creating 2 protected fields
    protected x first;
    protected y second;
    //creating an abstract method(2 arguments){assigns the values of the fields}
    abstract public void set(x a, y b);
    //creating an abstract method(no arguments){displays the value of the fields}
    abstract public void show();
}
//creating a template class that inherits from base_class
class Alpha<x, y> : base_class<x, y>
{
    //overloading the set method
    public override void set(x a, y b)
    {
        first = a;
        second = b;
    }
    //overloading the show method
    public override void show()
    {
        WriteLine("Fields: {0}|{1}", first, second);
    }
}
//creating a template class that inherits from base_class
class Beta<y> : base_class<int, y>
{
    //overloading the set method
    public override void set(int a, y b)
    {
        first = a;
        second = b;
    }
    //overloading the show method
    public override void show()
    {
        WriteLine("Fields: {0}|{1}", first, second);
    }
}
//creating a class that inherits from base_class
class Gamma : base_class<int, char>
{
    //overloading the set method
    public override void set(int a, char b)
    {
        first = a;
        second = b;
    }
    //overloading the show method
    public override void show()
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
        //creating a abstract class instance and assigning it to the class object
        base_class<string, double> Ra = A;
        //using the methods set and show from the class object
        A.set("Alpha", 100.0);
        Ra.show();
        Ra.set("alpha", 150.0);
        A.show();
        WriteLine("Second Object");
        //creating a class object
        Beta<string> B = new Beta<string>();
        //creating a abstract class instance and assigning it to the class object
        base_class<int, string> Rb = B;
        //using the methods set and show from the class object
        B.set(200, "Beta");
        Rb.show();
        Rb.set(250, "bravo");
        B.show();
        //creating a class object
        Gamma G = new Gamma();
        //creating a abstract class instance and assigning it to the class object
        base_class<int, char> Rg = G;
        //using the methods set and show from the class object
        G.set(300, 'C');
        Rg.show();
        Rg.set(350, 'D');
        G.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}