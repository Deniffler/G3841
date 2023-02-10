// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

Console.Clear();

// Функция (Метод) ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Сортировка методом Пузырьком
void BubleSortLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

// Функция (Метод) для заполнения 2D массива целыми (int) числами
int[,] Gen2DArrayInt(int row, int column, int range)
{
    int i = 0; int j = 0;
    int[,] arr = new int[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = new Random().Next(0, range);
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
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

// Основной код программы

Console.Clear();
// 1. Получение данных от пользователя
int row = ReadData("Количество строк матрицы: ");
int column = ReadData("Количество столбцов матрицы: ");
int range = ReadData("Диапазон элементов массива от 0 до ..... ? : ");

// 2. Генерируем 2D массив
int[,] arr2D = Gen2DArrayInt(row, column, range);

// 3. Печатаем 2D Массив
Console.WriteLine("Исходный 2D массив: ");
Print2DArr(arr2D);

// 4. Сортируем элементы массива по убыванию
BubleSortLines(arr2D);

// 5. Печатаем  отсортированны 2D Массив
Console.WriteLine();
Console.WriteLine("Отсортированный 2D массив: ");
Print2DArr(arr2D);

