namespace BankIndonesiaDotnet;

class Program
{
    static void Main(string[] args)
    {
        // number 1 
        Console.WriteLine("Number 1 ===");
        int n = 15;
        OkYes oy = new OkYes();
        oy.PrintOkYes(n);
        
        // number 2
        Console.WriteLine("Number 2 ===");
        n = 5;
        TriangleAndRectangle tar = new TriangleAndRectangle();
        Console.WriteLine("Point A");
        tar.TriangleA(n);
        
        Console.Write("Point B");
        tar.TriangleB(n);

        Console.Write("Point C");
        tar.TriangleC(n);

        Console.WriteLine("Point D");
        tar.Rectangle(n);
                
        // number 3
        Console.WriteLine("Number 3 ===");
        int[] m = new[] { 12, 9, 13, 6, 10, 4, 7, 2 };
        ArrayManipulation am = new ArrayManipulation();
        am.FilterAndSort(m);
    }
}