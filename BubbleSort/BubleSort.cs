namespace BubbleSort;

public class BubleSort
{
    public  void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n-i-1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
    }

    public void PrintArray(int[] array)
    {
        foreach (var num in array)
        {
            Console.Write(num+" ");
        }
        Console.WriteLine();
    }
}