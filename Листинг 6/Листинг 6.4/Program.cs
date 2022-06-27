using System.Threading;
using static System.Console;
//creating a class
class _class{
    //creating a private string and int field
    string text;
    int time;
    //creating a class that assigns the values of the fields
    public _class(string s, int n){
        text = s;
        time = n;
    }
    //creating a public method
    public void show(){
        //creating a loop
        for(int i = 0; i <= 5; i++){
            WriteLine(text + "\t"+i);
        }
        //pausing for time amount of time
        Thread.Sleep(time);
    }
}
public class Program
{
    //creating a static method with one string and one int parameter
    static void run(string s, int n){
        //creating a loop
        for(int i = 0; i <= 5; i++){
            WriteLine(s + "\t"+i);
            //pausing n amount of time
            Thread.Sleep(n);
        }
    }
    public static void Main(string[] args)
    {
        WriteLine("Main thread is started.");
        //creating 2 _class objects
        _class A = new _class("Object A",1000);
        _class B = new _class("Object B",1500);

        //creating a delegate instance and assigning its value to the method show of A
        ThreadStart ts = A.show;
        //adding to the value of ts the show method from B
        ts+=B.show;
        //creating 2 Thread objects
        Thread first = new Thread(ts);
        //assigning its parameter to a lambda function with 2 methods
        Thread second = new Thread(() =>{
            run("Method A",1200);
            run("Method B",800);    
        });

        //starting the first and second Thread object
        first.Start();
        second.Start();
        //if first is running finish it then continue
        if(first.IsAlive) first.Join();
        //if second is running finish it then continue
        if(second.IsAlive) second.Join();
        WriteLine("Main thread has ended");
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}