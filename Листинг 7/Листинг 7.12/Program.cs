using static System.Console;
//creating a class Alpha
class Alpha
{
    //creating a public int field
    public int code;
    //overloading a ToString method that displays the value of the field
    public override string ToString()
    {
        return "Alpha: " + code;
    }
}
//creating a class
class Beta
{
    //creating a string field
    public string text;
    //overloading a ToString method that returns the value of the field
    public override string ToString()
    {
        return "Beta: " + text;
    }
}
//creating a template class
class my_class<T> where T : new()
{
    //creating a class object field
    public T obj;
    //creating a constructor that assigns the objec to a class objecy
    public my_class()
    {
        obj = new T();
    }
    //creating a method show that displays the value of the field
    public void show()
    {
        WriteLine(obj);
    }
}
class Program
{
    static void Main(string[] args)
    {

        //creating a template class objet 
        my_class<Alpha> objA = new my_class<Alpha>();
        //assigning the value of the objects field
        objA.obj.code = 123;
        //using the method show
        objA.show();
        //creating a template class object
        my_class<Beta> objB = new my_class<Beta>();
        //assigns the value of the object 
        objB.obj.text = "text";
        //using the method show
        objB.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}