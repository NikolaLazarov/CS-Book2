using static System.Console;
delegate int myDelegate(int n);
public class Program
{
    
    public int meth0(int n){
        return n*2;
    }
    public static int[] meth(int[] n, myDelegate md){
        int[] numArrs = new int[n.Length];
        for(int i = 0; i < n.Length; i++){
            numArrs[i] = md(n[i]);
        }
        return numArrs;
    }
    public static void Main(string[] args)
    {
        int[] nums = new int[5];
        for(int i = 1; i <= nums.Length; i++){
            nums[i] = i;
            Write(nums[i]);
        }
        WriteLine();

        for(int i = 0; i < nums.Length; i++){
            Write(meth(nums,meth0)[i]+" ");
        }
        WriteLine();
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}