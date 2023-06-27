// See https://aka.ms/new-console-template for more information

int[] numbers = new int[10];

Console.WriteLine("ENTER 10 NUMBERS");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"NUMBER {i + 1}:");
    numbers[i] = int.Parse(Console.ReadLine());

}

int sum = GetScalarSum(numbers);
Console.WriteLine($"Scalar Sum :{sum}");

Console.WriteLine(" PRESS ANY KEY TO EXIT..");
Console.ReadLine();

static int GetScalarSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

