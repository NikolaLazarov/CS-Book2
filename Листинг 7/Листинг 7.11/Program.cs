using static System.Console;
//creating a class
class Base1
{
    //creating a protected intn field
    protected int code;
    //creating a constructor that assigns the value of the field
    public Base1(int n)
    {
        code = n;
    }
    //creating a virtual method{returns the field of the class}
    public virtual void show()
    {
        WriteLine("Class Base1: " + code);
    }
}
//creating a class that inherits from a base class
class Alpha : Base1
{
    //creating a constructr
    public Alpha(int n) : base(n) { }
    //overloading the method show
    public override void show()
    {
        WriteLine("Class Alpha: " + code);
    }
}
//creating a class that inherits from Alpha
class Beta : Alpha
{
    //creating a constructot
    public Beta(int n) : base(n) { }
    //overloading the method show
    public override void show()
    {
        WriteLine("Class Beta: " + code);
    }
}
//creating a template class
class my_class<T> where T : Base1
{
    //creating a class object field
    public Base1 obj;
    /*creating a constructor that assigns the value of the field
     and usinf the show method from the object*/
    public my_class(T t)
    {
        obj = t;
        obj.show();
    }
}
class Program
{
    static void Main(string[] args)
    {
        //creating 3 class objects
        Base1 B1 = new Base1(100);
        Alpha A = new Alpha(200);
        Beta B = new Beta(300);

        //creating 4 my_class objects(different types and arguments)
        my_class<Base1> objA = new my_class<Base1>(B1);
        my_class<Alpha> objB = new my_class<Alpha>(A);
        my_class<Beta> objC = new my_class<Beta>(B);
        my_class<Base1> objD = new my_class<Base1>(B);


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}