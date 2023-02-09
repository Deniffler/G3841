// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Функция (Метод) ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


// Функция (Метод) для заполнения 2D массива целыми (int) числами
int[,] Gen2DArrayInt(int row, int column)
{
    int i = 0; int j = 0;
    int[,] arr = new int[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = new Random().Next(0, 101);
            j++;
        }
        i++;
    }
    return arr;
}

// Функция (Метод) вывода 2D  массива в консоль
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            Console.Write(arr[i, j] + "\t");
            //Console.ResetColor(); 
        }
        Console.WriteLine("");
    }
}

// Метод печати 1D массива в консоль
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


// Метод подсчета среднего арифметического по столбцам
int[] MeanColum(int[,] arr)
{
    int[] means = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            means[i] = means[i] + arr[j, i];
        }
        means[i] = means[i] / arr.GetLength(0);
    }
    return means;
}

// Метод подсчета среднего арифметического по диагонали
int DiagAverage(int[,] arr)
{
    int res = 0;
    int count = 0;
    int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);

    for (int i = 0; i < min; i = i + 1)
    {
        res = res + arr[i, i];
        count = count + 1;
    }
    res = res / count;
    return res;
}


// 1. Получение данных от пользователя
int row = ReadData("Количество строк матрицы: ");
int column = ReadData("Количество столбцов матрицы: ");

// 2. Генерируем 2D массив
int[,] arr2D = Gen2DArrayInt(row, column);

// 3. Считаем среднее арифметическое по столбцам
int[] average = MeanColum(arr2D);

// 4. Печатаем 2D Массив
Print2DArr(arr2D);

Console.WriteLine();
Console.WriteLine("Среднее арифметическое по столбцам: ");
// 5. Печатаем 1D Массив
Print1DArr(average);

int diagAver = DiagAverage(arr2D);
Console.WriteLine("Среднее арифметическое по диагонали: ");
Console.WriteLine(diagAver);