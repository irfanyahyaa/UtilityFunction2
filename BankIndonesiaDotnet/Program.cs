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
    }
}