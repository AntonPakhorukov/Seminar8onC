Console.Clear();
int[,] GetArray()
{
    Console.Write("Введите количество строк для двумерного массива: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов для двумерного массива: ");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[row, column];
    return array;
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] GetRandomArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i, j] = new Random().Next(1, 10);
        }
    }
    return inputArray;
}

int[,] array = GetArray();
array = GetRandomArray(array);

