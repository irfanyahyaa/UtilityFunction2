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

        Console.WriteLine();
    }

    public void TriangleB(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }

    public void TriangleC(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            int k = 1;
            bool isIncrement = true;
            for (int j = 0; j < i; j++)
            {
                Console.Write(k);
                if (k == 5)
                {
                    isIncrement = false;
                }
                else if (k == 1)
                {
                    isIncrement = true;
                }

                if (isIncrement)
                {
                    k++;
                }
                else
                {
                    k--;
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}