using static System.Console;
using System.Threading;
public class Program
{
    //creating a static method
    static void run(){
        WriteLine("Secondary thread thread");
        //Creating a loop that runs 6 times
        for(int i = 0; i <= 5; i++){
            //displaying i + 'A' converted to char
            WriteLine("Secondary thread: {0}",(char)('A'+i));
            //pausing for 1 second
            Thread.Sleep(1000);
            WriteLine("Secondary thread has ended");
        }
    }
    public static void Main(string[] args)
    {
        WriteLine("Starting main thread");
        //creating a new object of class Thread with the method run as parameter
        Thread md = new Thread(run);
        //starting the secondary thread
        md.Start();
        //creating a loop that runs 5 times
        for(int i = 0; i <= 5; i++){
            //displaying i
            WriteLine("Main thread:     "+i);
            //pausing for 2 seconds
            Thread.Sleep(2000);
        }
        WriteLine("Main thread has ended");
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
} 