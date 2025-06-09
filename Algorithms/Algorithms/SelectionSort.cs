namespace BubbleSort.Algorithms;

public class SelectionSort : ISortStrategy
{
    public void Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                    minIndex = j;
            }
            if (minIndex != i)
                (array[i], array[minIndex]) = (array[minIndex], array[i]);
        }
        Console.WriteLine("使用选择排序完成！");
    }
}