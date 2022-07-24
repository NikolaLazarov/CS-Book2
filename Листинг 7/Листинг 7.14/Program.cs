using static System.Console;
//creating a template interface
//restriction of the type: non referance type
interface my_int<T> where T : struct
{
    void show();
}
//creating a template class that inherits from a interface
//restriction of type: non referance type
class my_class<T> : my_int<T> where T : struct
{
    //creating a public field
    public T val;
    //creating a constructor that assigns the value of the field
    public my_class(T v)
    {
        val = v;
    }
    //creating the method show
    public void show()
    {
        //displays the type and value of the class field
        WriteLine("Type {0}: value: {1}", typeof(T).Name, val);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //creating 2 class objects(int type and char type)
        my_class<int> A = new my_class<int>(100);
        my_class<char> B = new my_class<char>('B');
        //using the method show from the objects
        A.show();
        B.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}