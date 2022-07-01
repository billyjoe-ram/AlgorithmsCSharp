// See https://aka.ms/new-console-template for more information
using Algoritmos.Sorts;

Console.WriteLine("Hello, World!\nWelcome to Sorting Algorithms 101!\n");

int[] toSortArray = new int[]
{
    23, 48, 12, 99, 1, 2, 1, 0, 24
};

Console.WriteLine("Array before sorting");

Console.WriteLine(string.Join(", ", toSortArray));

Console.WriteLine("\nArray after sorting");

Console.WriteLine(string.Join(", ", new BubbleSort().Sort(toSortArray)));

Console.WriteLine(string.Join(", ", new SelectionSort().Sort(toSortArray)));

Console.WriteLine(string.Join(", ", new QuickSort().Sort(toSortArray)));

Console.ReadLine();
