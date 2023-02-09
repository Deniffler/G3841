// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

// Функция (Метод) ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


// Функция (Метод) генерации 2D массива числами Фиббоначи
int[,] Gen2DArrFibo(int column, int row)
{
    // Генерируем 1D массив из чисел Фибоначи, длинной column * row
    int[] arr1D = new int[column * row];
    arr1D[0] = 0;
    arr1D[1] = 1;
    for (int i = 2; i < arr1D.Length; i++)
    {
        arr1D[i] = arr1D[i - 1] + arr1D[i - 2];
    }
    // Инициализируем  2D массив из 1D массива
    int[,] arr2D = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr2D[i, j] = arr1D[i * column + j];
        }
    }
    return arr2D;
}

// Функция (Метод) поиска существования элемента в массиве и вывод результата в консоль
void SerchElemAndPrint(int[,] arr2D, int serchElem)
{
    bool elemSerch = false;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if (serchElem == arr2D[i, j])
            {
                elemSerch = true;
                Console.ForegroundColor = System.ConsoleColor.Red;
            }
            Console.Write(arr2D[i, j] + " \t");
            Console.ForegroundColor = System.ConsoleColor.White;
        }
        Console.WriteLine();
    }
    if (elemSerch == false)
    {
        Console.ForegroundColor = System.ConsoleColor.Red;
        Console.WriteLine("Элемент " + serchElem + " не найден");
    }
    Console.ForegroundColor = System.ConsoleColor.White;
}

// 1. Получение данных от пользователя
int column = ReadData("Количество столбцов матрицы: ");
int row = ReadData("Количество строк матрицы: ");
int findeNum = ReadData("Введите искомое число ");

// 2. Генерируем 2D  массив
int[,] arr2DFibo = Gen2DArrFibo(column, row);

// 3. Ищем элемент в массиве и выводим результат в консоль
Console.WriteLine();
SerchElemAndPrint(arr2DFibo, findeNum);

