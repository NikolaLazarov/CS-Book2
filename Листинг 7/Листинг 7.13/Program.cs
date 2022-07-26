using static System.Console;
//creating a class
class Alpha
{
    //creating a public int field
    public int code;
    //overloading a ToString method
    public override string ToString()
    {
        //returns the class's field
        return "Alpha: " + code;
    }
}
//creating a class that inherits from alpha
class Beta : Alpha
{
    //creating a public string field
    public string text;
    //overloading a ToString method
    public override string ToString()
    {
        //returns the field of the class and the inherited class
        return "Beta: " + code + " and " + text;
    }
}
//creating a template class
class my_class<x, y>
//restriction that excepts class and a class which's constructor has no arguments
where x : class, new()
//restriction that excepts class that derives from a class and a class whichs constructor has no arguments
where y : x, new()
{
    //creating 2 public fileds
    public x first;
    public y second;
    //creating a constructor that assigns the values of the fields
    public my_class()
    {
        first = new x();
        second = new y();
    }
    //overloading a ToString method
    public override string ToString()
    {
        //returns the fields
        return "my_class->|" + first + "|" + second + "|";
    }
}
class Program
{
    static void Main(string[] args)
    {
        //creating a class object
        my_class<Alpha, Beta> obj = new my_class<Alpha, Beta>();
        //assigning values of fields
        obj.first.code = 100;
        obj.second.code = 120;
        obj.second.text = "text";
        //displaying the class object
        WriteLine(obj);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}