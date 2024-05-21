namespace BankIndonesiaDotnet;

public class OkYes
{
    public void PrintOkYes(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 4 == 0 && i % 3 == 0)
            {
                Console.Write("OKYES ");
            }
            else if (i % 4 == 0)
            {
                Console.Write("YES ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("OK ");
            }
            else
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine("\n");
    }
}