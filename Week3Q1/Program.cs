internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("f(?) : ");
        float n = float.Parse(Console.ReadLine());
        Console.WriteLine("{0}",Fx(n));
    }
    static float Fx(float n)
    {
        float sum = 0;
        if(Math.Pow(n,2) > 4)
        {
            sum = 1 + Fx( n - ( 4 * Math.Abs(n) / n ));
        }
        else 
        {
            sum = 2;
        }
        return sum;
    }
}