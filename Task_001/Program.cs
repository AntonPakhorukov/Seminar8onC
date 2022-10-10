/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Исходный:
9 2 3
4 2 4
2 6 7
Ответ:
9 4 2
2 2 6
3 4 7
*/
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
Console.Clear();
int[,] array = GetArray();
// void GetTest (int[,] inputArray){
// if (array.GetLength(0) == array.GetLength(1)) {
//     Console.WriteLine("Ошибка, в массиве количество строк должно быть равно количесвту столбцам");
//     return;
// }
// }
// GetTest(array);
array = GetRandomArray(array);

PrintArray(array);
int[,] GetChangeRowColumn(int[,] inputArray)
{
    int[,] newArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            newArray[i, j] = inputArray[j, i];
        }
    }
    return newArray;
}
int[,] changeArray = GetChangeRowColumn(array);
Console.WriteLine();
PrintArray(changeArray);

// сделать проверку

/*

int UserInput(string input)
{
    Console.Write(input);
    int output = int.Parse(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    Console.WriteLine("\n Массив чисел: \n\t");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(arrayRangeMin, arrayRangeMax);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 5}", array[i, j]);
        }
        Console.WriteLine();
    }
}
*/