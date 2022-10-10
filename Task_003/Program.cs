/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен 
наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 2 3
4 2 4
2 6 7
*/
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
PrintArray(array);

(int, int) FindNumber(int[,] inputArray)
{
    int min = inputArray[0, 0];
    int indexRow = 0;
    int indexColumn = 0;
    //int[,] newArray = new int[inputArray.GetLength(0) - 1, inputArray.GetLength(1) - 1];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] < min)
            {
                min = inputArray[i,j];
                indexRow = i;
                indexColumn = j;
            }
        }
    }
    return (indexRow, indexColumn);
}

void PrintArrayColor(int[,] inputArray)
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

int[,] TransArray(int[,] inputArray)
{
    int[,] arrayTrans = new int[inputArray.GetLength(0) - 1, inputArray.GetLength(1) - 1];
    int rowCount = 0;
    int colCount = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        if (i == FindNumber(array).Item1)
        {
            continue;
        }
        
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (j == FindNumber(array).Item2)
            {
                continue;
            }
            
            arrayTrans[rowCount,colCount] = inputArray[i,j];
            colCount++;
        }
        rowCount++;
        colCount = 0;
    }
    return arrayTrans;
}
Console.WriteLine();
PrintArray(TransArray(array));