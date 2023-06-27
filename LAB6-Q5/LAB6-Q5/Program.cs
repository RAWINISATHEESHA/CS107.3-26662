// See https://aka.ms/new-console-template for more information

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] resultMatrix = new int[2, 2];


int[,] product = new int[2, 2];
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        product[i, j] = 0;

        for (int k = 0; k < 2; k++)
        {
            product[i, j] += matrix1[i, k] * matrix2[k, j];

        }
    }
}

Console.WriteLine("THE PRODUCT MATRIX IS:");

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write("{0}", product[i, j]);

    }
    Console.WriteLine();
    
}









