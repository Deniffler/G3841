// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом. 
// Для задачи со звездочкой использовать заполнение массива целыми числами.

// Вариант №1 (базовое решение задачи)

// Метод генерации 1D массива
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
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

// Метод вывода значения в консоль
void PrintData(int res)
{
    Console.WriteLine(res);
}

// Метод рассчета разницы м/д Max и Min элементами массива
int MaxMinSubtraction(int[] arr)
{
    // переменной max присваиваем значение, минимально возможное для int32 - это константа = -2147483648
    int max = int.MinValue;
    // переменной min присваиваем значение, максимально возможное для int32 - это константа = +2147483648
    int min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

// Основной код программы:

// генерируем 1D массив
int[] testArr = Gen1DArray(10, 1, 10);

// Выводим сгенерируемый массив в консоль
Print1DArr(testArr);

// Считаем разницу м/д max и min элементами массива, результат выводим в консоль
PrintData(MaxMinSubtraction(testArr));

