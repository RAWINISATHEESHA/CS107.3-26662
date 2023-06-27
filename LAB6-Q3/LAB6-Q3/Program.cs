// See https://aka.ms/new-console-template for more information

int[] numbers = { 6, 7, 8, 9, 4, 5, 3, 2, 1 };

Console.WriteLine("ORIGINAL ARRAY:");
DisplayArray(numbers);

int[] ascendingArray = SortAscending(numbers);
Console.WriteLine("\nArray sorted in ascending order :");
DisplayArray(ascendingArray);


int[] descendingArray = SortDescending(numbers);
Console.WriteLine("\nArray sorted in descending order :");
DisplayArray(descendingArray);


Console.WriteLine("\n PRESS ANY KEY TO EXIT..");
Console.ReadKey();


static int[] SortAscending(int[] array)
{
    int[] sortedArray = new int[array.Length];
    Array.Copy(array, sortedArray, array.Length);
    Array.Sort(sortedArray);
    return sortedArray;

}

static int[] SortDescending(int[] array)
{
    int[] sortedArray = new int[array.Length];
    Array.Copy(array, sortedArray, array.Length);
    Array.Sort(sortedArray);
    Array.Reverse(sortedArray);
    return sortedArray;
}

static void DisplayArray(int[] array)
{
foreach (int num in array)
    {
        Console.WriteLine(num + " ");

    }
    Console.WriteLine();
}




