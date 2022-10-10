/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3 
4, 6, 1 
2, 1, 6
1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза

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
int[] GetCathNumber(int[,] inputArray)
{
    int[] value = new int[10];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] == 0)
            {
                value[0]++;
            }
            else if (inputArray[i, j] == 1)
            {
                value[1]++;
            }
            else if (inputArray[i, j] == 2)
            {
                value[2]++;
            } else if (inputArray[i, j] == 3)
            {
                value[3]++;
            } else if (inputArray[i, j] == 4)
            {
                value[4]++;
            } else if (inputArray[i, j] == 5)
            {
                value[5]++;
            } else if (inputArray[i, j] == 6)
            {
                value[6]++;
            } else if (inputArray[i, j] == 7)
            {
                value[7]++;
            } else if (inputArray[i, j] == 8)
            {
                value[8]++;
            } else if (inputArray[i, j] == 9)
            {
                value[9]++;
            } 
        }
    }
    return value;
}
int[] arrayOne = GetCathNumber(array);
Console.WriteLine();
// Console.WriteLine("[" +String.Join(", ", arrayOne) + "]");
void PrintValues(int[] inputArray) {
    for (int i = 0; i < inputArray.Length; i++) {
        if (inputArray[i] > 0) {
            Console.WriteLine($"Цифра {i} встречается {inputArray[i]} раз");
        }
    }
}
PrintValues(arrayOne);

// реализовать иначе, перевести двумерный массив в одномерный и его выводить

int[] GetNewArray (int[,] inputArray) {
    int[] arrayOnes = new int[(inputArray.GetLength(0) * inputArray.GetLength(1)) - 2];
    int index = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++) {
            arrayOne[index] = inputArray[i,j];
            index++;
        }
    }
    return arrayOne;
}
Console.WriteLine();
int[] numbers = GetNewArray(array);
Console.WriteLine("[" +String.Join(", ", numbers) + "]");
// void PrintNewValues(int[] inputArray) {
//     //try
// }

/*
void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            WriteLine($"{el} встречается {count}");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{el} встречается {count}");
}
*/

/*
void SortArray(int[,] arr_l)
{
    int row_l = arr_l.GetLength(0);
    int col_l = arr_l.GetLength(1);
    int[] arr_1d = new int[row_l * col_l];
    int index = 0;
    
    for (int i = 0; i < row_l; i++)
    {
        for (int j = 0; j < col_l; j++)
        {
            arr_1d[index] = arr_l[i, j];
            index++;
        }
    }
    Array.Sort(arr_1d);
    Console.WriteLine(string.Join(", ", arr_1d));
    
    PrintData(arr_1d);
    
}
*/



