// See https://aka.ms/new-console-template for more information

using BubbleSort;

int[] numbers = {  5, 2, 4, 3, 1  };
Console.WriteLine("原始数组:");
var bubbleSort = new BubleSort();
bubbleSort.PrintArray(numbers);
bubbleSort.BubbleSort(numbers);
Console.WriteLine("排序后数组:");
bubbleSort.PrintArray(numbers);
Console.WriteLine("Hello, World!");