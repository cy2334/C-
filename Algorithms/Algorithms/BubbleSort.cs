namespace BubbleSort.Algorithms;

public class BubbleSort :ISortStrategy
{
    public void Sort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n-1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }
    }
}