internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("f(?) : ");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}",Fx(n));
    }
    static double Fx(double n)
    {
        double sum = 0;
        if((n > -1) && (n <= 0)) {
            sum = Math.Sqrt(1 - Math.Pow(n,2));
        } else if ((n > 0) && (n <= 1)) {
            sum = ( - (Math.Sqrt(1 - Math.Pow(n,2)))); 
        } else if (n <= -1) { 
            sum = Fx(n + 2);
        } else if (n > 1) { 
            sum = Fx(n - 2);
        }
        return sum;
    }
}