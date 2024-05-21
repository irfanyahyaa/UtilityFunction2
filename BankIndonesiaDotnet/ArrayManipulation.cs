namespace BankIndonesiaDotnet;

public class ArrayManipulation
{
    public void FilterAndSort(int[] m)
    {
        m = m.Where(val => val % 3 != 0).ToArray();
        
        for (var i = 0; i < m.Length; i++)
        {
            for (int j = i + 1; j < m.Length; j++)
            {
                if (m[i] > m[j])
                {
                    (m[i], m[j]) = (m[j], m[i]);
                }
            }
        }

        Console.WriteLine("m = [{0}]", string.Join(", ", m));
    }
}