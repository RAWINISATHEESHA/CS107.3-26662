using System;
namespace PRACTICAL6_Q6
{
	public class ArrayClass
	{
		public int[] arrayMethod(int size)
		{
			int[] array = new int[size];

			for (int i = 0; i < array.Length; i += 2)
			{
				Console.WriteLine("ENTER A VALUE:");
				int value = Convert.ToInt32(Console.ReadLine());
				array[i] = value;
				array[i + 1] = 0;

			}
			return array;
		}

	}
}

