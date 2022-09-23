
int height = EnterSizeofArray("Введите количество строк в массиве");
int width = EnterSizeofArray("Введите количество столбцов в массиве");
int[,] numbers = Fill2dArray(height,width);
double[] AverageNumbers = FindArithmeticMean(numbers,height,width);
PrintArray(numbers,height,width);

foreach(double number in AverageNumbers)
{
    Console.Write($"{number, 4} ");
}



double[] FindArithmeticMean(int[,] array, int rows, int columns)
{
    
    double[] averageNumbers = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i,j];
        }
        averageNumbers[j] = sum / rows;
    }
    return averageNumbers;
}

int EnterSizeofArray(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);

}

int[,] Fill2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }


    }
    return array;
}

void PrintArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine();
    }

}
