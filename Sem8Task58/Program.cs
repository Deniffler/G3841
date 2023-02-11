// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Основные методы для работы программы

// Функция (Метод) ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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

// Метод вычисляет произведение двух массивов (матриц)
void Mylti2DArr(int[,] arr1, int[,] arr2, int[,] resArr)
{

    for (int i = 0; i < resArr.GetLength(0); i++)
    {
        for (int j = 0; j < resArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            resArr[i, j] = sum;
        }
    }
}


// Основной код программы
Console.Clear();

// 1. Получение данных от пользователя

Console.WriteLine("Для корректного решения задачи необходимо ввести данные.");
Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй");

// Ввод параметров  первой и второй матриц
int row1 = ReadData("Количество строк первой матрицы: ");
int colFirstRowSec = ReadData("Количество СТРОК первой и СТОЛБЦОВ второй матрицы: ");
int column2 = ReadData("Количество столбцов второй матрицы: ");
int range = ReadData("Диапазон элементов массива от 0 до ..... ? : ");
Console.WriteLine();


// 2. Генерируем первый 2D массив
int[,] arr2DFirst = Gen2DArrayInt(row1, colFirstRowSec, range);

// 3. Генерируем второй 2D массив
int[,] arr2DSecond = Gen2DArrayInt(colFirstRowSec, column2, range);


// 4. Печатаем первый и второй 2D Массивы
Console.WriteLine("Первый 2D массив: ");
Print2DArr(arr2DFirst);
Console.WriteLine();
Console.WriteLine("Второй 2D массив: ");
Print2DArr(arr2DSecond);

// 5. Вычисляем произведение двух матриц
int[,] res2DArr = new int[row1, column2];
Mylti2DArr(arr2DFirst, arr2DSecond, res2DArr);

// 6. Выводим результат
Console.WriteLine();
Console.WriteLine("произведение 2х матриц: ");
Print2DArr(res2DArr);

