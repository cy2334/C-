namespace BubbleSort.Algorithms;

public class QuickSort :ISortStrategy
{
    public void Sort(int[] array)
    {
        Quick(array, 0, array.Length - 1);
        Console.WriteLine("使用快速排序完成！");
    }
    private void Quick(int[] arr, int left, int right)
    {
        if (left >= right) return;
        int pivot = arr[left];
        int i = left, j = right;
        while (i < j)
        {
            while (i < j && arr[j] >= pivot) j--;
            while (i < j && arr[i] <= pivot) i++;
            if (i < j) (arr[i], arr[j]) = (arr[j], arr[i]);
        }
        (arr[left], arr[i]) = (arr[i], arr[left]);
        Quick(arr, left, i - 1);
        Quick(arr, i + 1, right);
    }
}