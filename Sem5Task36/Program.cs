//Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

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
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод считает сумму элементов массива с нечетными индексами
int SumPos (int [] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        res += arr[i];
    }
    return res;
}

// Основной код программы:

// Генерируем массив по заданным в задачах параметрам
int[] testArr = Gen1DArray(10,1,10);

// Выводим сгенерированный массив в консоль
Print1DArr(testArr);

// Считаем сумму нечетных элементов массива
int oddValueSum = SumPos(testArr);

// Выводим ответ в консоль
PrintData("Сумма нечетных элементов массива равна: " + oddValueSum);