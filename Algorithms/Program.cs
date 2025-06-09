// See https://aka.ms/new-console-template for more information

using BubbleSort;
using BubbleSort.Algorithms;
using BubbleSort.context;

Console.WriteLine("请输入整数数组，用逗号分隔：");
var input = Console.ReadLine();
var array = input.Split(',').Select(int.Parse).ToArray();

Console.WriteLine("选择排序算法：");
Console.WriteLine("1. 冒泡排序");
Console.WriteLine("2. 快速排序");
Console.WriteLine("3. 选择排序");
Console.Write("请输入选项(1-3)：");

var choice = Console.ReadLine();

ISortStrategy strategy = choice switch
{
    "1" => new BubbleSort.Algorithms.BubbleSort(),
    "2" => new QuickSort(),
    "3" => new SelectionSort(),
    _ => throw new Exception("不支持的算法选项")
};

var sorter = new Sorter();
sorter.SetStrategy(strategy);
sorter.Sort(array);

Console.WriteLine("排序结果：" + string.Join(", ", array));