internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("C0x : ");
        double Cx = double.Parse(Console.ReadLine());
        Console.Write("C0y : ");
        double Cy = double.Parse(Console.ReadLine());
        Console.Write("P0x : ");
        double Px = double.Parse(Console.ReadLine());
        Console.Write("P0y : ");
        double Py = double.Parse(Console.ReadLine());
        Console.Write("Repeat (i) : ");
        int i = int.Parse(Console.ReadLine());

        double radius = Math.Sqrt( Math.Pow(Px - Cx,2) + Math.Pow(Py - Cy,2));
        double area = Math.PI / 4;

        for (int j = 1 ; j <= i;j++) {             
            area += Math.PI / 2; 
            Px = radius * Math.Cos(area) / Math.Pow(2,j - 1) + Cx;
            Py = radius * Math.Sin(area) / Math.Pow(2,j - 1) + Cy;
            Cx = radius * Math.Cos(area) / Math.Pow(2,j) + Cx;
            Cy = radius * Math.Sin(area) / Math.Pow(2,j) + Cy;         
        }

        Console.WriteLine("C{0}x : {1}",i,Cx);
        Console.WriteLine("C{0}y : {1}",i,Cy);
        Console.WriteLine("P{0}x : {1}",i,Px);
        Console.WriteLine("P{0}y : {1}",i,Py);
    }
}