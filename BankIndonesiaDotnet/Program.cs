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

        // point a
        Console.WriteLine("Point A");
        tar.TriangleA(n);
        
        // point b
        Console.Write("Point B");
        tar.TriangleB(n);
    }
}