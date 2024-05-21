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
        
        Console.WriteLine("Point A");
        TriangleAndRectangle tar = new TriangleAndRectangle();
        tar.TriangleA(n);
    }
}