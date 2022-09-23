


int height = EnterSizeofArray("Введите количество строк в массиве");
int width = EnterSizeofArray("Введите количество столбцов в массиве");
int[,] numbers =Fill2dArray(height,width);
FindElement(numbers,height,width);
PrintArray(numbers,height,width);

void FindElement(int[,] array, int rows, int columns)
{
    Console.WriteLine("Введите позицию элемента в двумерном массиве");
    int row = int.Parse(Console.ReadLine()!);
    int column = int.Parse(Console.ReadLine()!);

    if (row < rows && column < columns)
    {
        Console.WriteLine($"элемент найден , это {array[row - 1,column - 1]} на позиции {(row,column)}");// отчет у пользователя от 1
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
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

