namespace BubbleSort.context;

public class Sorter
{
    private ISortStrategy _strategy;

    public void SetStrategy(ISortStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Sort(int[] array)
    {
        _strategy.Sort(array);
    }
}