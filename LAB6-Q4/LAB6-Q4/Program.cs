// See https://aka.ms/new-console-template for more information

int[] numbers = new int[20];

Random random = new Random();

for (int i = 0; i < numbers.Length; i++)

{
    numbers[i] = random.Next(1, 100);
}

int min = numbers[0];
int max = numbers[0];

for ( int i = 1; i < numbers.Length; i++)
{
if (numbers[i] < min)
    {
        min = numbers[i];
    }

    if (numbers[i] > max)
    {
        max = numbers[i];

    }
}


Console.WriteLine("ARRAY : " + string.Join(", ", numbers));
Console.WriteLine("MINIMUM VALUE: " + min);
Console.WriteLine("MAXIMUM VALUE: " + max);

