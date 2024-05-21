namespace BankIndonesiaDotnet;

public class TriangleAndRectangle
{
    public void TriangleA(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + 1);
            }

            Console.WriteLine(i + 1);
        }
    }
}