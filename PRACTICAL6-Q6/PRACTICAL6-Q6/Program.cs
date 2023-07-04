// See https://aka.ms/new-console-template for more information

Console.WriteLine("ENTER  THE SIZE OF THE ARRAY:");
int size = Convert.ToInt32(Console.ReadLine());

ArrayClass obj1 = new ArrayClass();
int[] array = obj1.arrayMethod(size);

Console.WriteLine("\nDisplay the array:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + " ");
}

Console.ReadLine();

