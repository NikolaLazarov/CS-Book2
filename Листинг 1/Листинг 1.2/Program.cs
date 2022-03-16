using static System.Console;
//creating an abstract class
abstract class Base{
    //creating an abstract property
    public abstract string text{
        //defining a get and a set accessor
        get;
        set;
    }
    //creating an abstract indexer
    public abstract char this[int k]{
        //defining a get accessor
        get;
    }
    //creating an abstract property
    public abstract int length{
        //defining a get accessor
        get;
    }
}
//creating a class that inherits from Base
class Alpha : Base{
    //creating a private char array field
    private char[] symbs;
    //creating a constructor with a reference to the base class
    public Alpha(string t) : base(){
        //using the property to assign a value
        text = t;
    }
    //overloading a property
    public override string text{
        //defining a get accessor
        get{
            //returns a new string of the elements of the array
            return new string(symbs);
        }
        //defining a set accessor
        set{ 
            //assigning the the value of the elements of the array
            symbs = value.ToCharArray();
        }
    }
    //overloading a property
    public override int length{
        //defining a get accessor
        get{
            //returns the length of the array
            return symbs.Length;
        }
    }
    //overloading an indexer
    public override char this[int k]{
        //defining a get accessor
        get{
            //returns the index of the array
            return symbs[k];
        }
    }
}
//creating a class that inherits from Base
class Bravo : Base{
    //creating a variable field
    private string txt;
    //creating a constructor with a reference to the base class
    public Bravo(string t) : base(){
        //assigning the fields value
        txt = t;
    }
    //overloading a property
    public override string text{
        //defining a get accessor
        get{
            //returns the field
            return txt;
        }
        //defining a set accessor
        set{ 
            //assigns the fields value
            txt = value;
        }
    }
    //overloading a property
    public override int length{
        //defining a get accessor
        get{
            //returns the length of the array
            return txt.Length;
        }
    }
    //overloading an indexer
    public override char this[int k]{
        //defining a get accessor
        get{
            //returns the index of the array
            return txt[k];
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        Base obj = new Alpha("Alpha");
        //displaying the field using a property
        WriteLine(obj.text);

        //assigning the value of the field via  a property
        obj.text = "Base";
        //displaying each of the elements of the field
        for(int i = 0; i < obj.length ;i++){
            Write("|"+obj[i]);
        }
        WriteLine("|");

        //assigning the class variables value
        obj = new Bravo("Bravo");
        //displaying each of the elements of the field
        for(int i = 0; i < obj.length ;i++){
            Write("|"+obj[i]);
        }
        WriteLine("|");

        //assigning the value of the field via  a property
        obj.text = "Base";
        //assigning the value of the field via  a property
        WriteLine(obj.text);
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}