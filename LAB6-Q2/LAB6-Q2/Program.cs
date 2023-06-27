// See https://aka.ms/new-console-template for more information

int[] numbers = { 5, 6, 3, 7, 9, 8, 4, 2, 1 };

int minimum = FindMinimum(numbers);
int maximum = FindMaximum(numbers);

Console.WriteLine($"MINIMUM VALUE :{minimum}");
Console.WriteLine($"MAXIMUM VALUE :{maximum}");

Console.WriteLine("  PRESS ANY KEY TO EXIT..");
Console.ReadKey();

static int FindMinimum(int[] array)
{
    int min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
    if (array[i] < min)
        {
            min = array[i];

        }
    }
    return min;

}
static int FindMaximum(int[] array)
{
    int max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];

        }
    }
    return max;

}




