using static System.Console;
//creating a template delegate
delegate x genMeth<x, y>(y arg);
//creating a class
class my_class
{
    //creating public int fields
    public int code;
    /*creating a metod(1 argument){returns 
    the argument + fields converted to char}*/
    public char getChar(char start)
    {
        return (char)(start + code);
    }
}
class Program
{
    //creating a method[returns string](1 int argument){returns the argument}
    static string getStr(int num)
    {
        return "Number " + num;
    }
    //creating a method[retunrs int](1 String argument){returns the argument converted to int}
    static int getInt(String txt)
    {
        return Int32.Parse(txt);
    }
    static void Main(string[] args)
    {
        //creating a class object
        my_class obj = new my_class();
        //assigning the value of the class object field
        obj.code = 5;
        //creating a delegate instance and assigning to getStr
        genMeth<string, int> A = getStr;
        //creating a delegate object(getInt method as argument)
        genMeth<int, string> B = new genMeth<int, string>(getInt);
        //creating a delegate instance to the getChar method of obj
        genMeth<char, char> C = obj.getChar;
        //displaying the results of delegates
        WriteLine(A(123));
        WriteLine(B("100") + 200);
        WriteLine(C('A'));

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}