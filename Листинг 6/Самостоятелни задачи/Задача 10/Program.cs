using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        double Control_value = 2.0/3.0;
        double sum = 1;
        WriteLine("Control value: {0}",Control_value);
        Thread PI = new Thread(()=>{
            double n = 2;
            while(true){
                sum *= (Math.Pow(3,n)-1)/(Math.Pow(3,n)+1);
                n++;
                Thread.Sleep(10);                
            }
        });
        PI.Start();
        Thread.Sleep(100);
        WriteLine("Our value: {0}",sum);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}