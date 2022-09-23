

int height = EnterSizeofArray("Enter height");
int width = EnterSizeofArray("Enter width");

double[,] array = Fill2dArray(height,width);
PrintArray(array,height,width);


int EnterSizeofArray(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);

}

double[,] Fill2dArray(int rows, int columns)
{
    double[,] array = new double[rows,columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }


    }
    return array;
}

void PrintArray(double[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{Math.Round(array[i,j],1),5} ");
    }
    Console.WriteLine();
}

}
















































