// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом. 
// Для задачи со звездочкой использовать заполнение массива целыми числами.

// // Вариант №1 (базовое решение задачи)

// // Метод генерации 1D массива
// int[] Gen1DArray(int len, int minValue, int maxValue)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return arr;
// }

// // Метод печати 1D массива в консоль
// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// // Метод вывода значения в консоль
// void PrintData(int res)
// {
//     Console.WriteLine(res);
// }

// // Метод рассчета разницы м/д Max и Min элементами массива
// int MaxMinSubtraction(int[] arr)
// {
//     // переменной max присваиваем значение, минимально возможное для int32 - это константа = -2147483648
//     int max = int.MinValue;
//     // переменной min присваиваем значение, максимально возможное для int32 - это константа = +2147483648
//     int min = int.MaxValue;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > max) max = arr[i];
//         if (arr[i] < min) min = arr[i];
//     }
//     return max - min;
// }

// // Основной код программы:

// // генерируем 1D массив
// int[] testArr = Gen1DArray(10, 1, 10);

// // Выводим сгенерируемый массив в консоль
// Print1DArr(testArr);

// // Считаем разницу м/д max и min элементами массива, результат выводим в консоль
// PrintData(MaxMinSubtraction(testArr));

//ВАРИАНТ №2

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

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
void PrintData( int res)
{
    Console.WriteLine(res);
}

// Метод сортировки массива  - "Вставка"
int[] InserMethod(int[] arr)
{
    int [] resArr = new int[arr.Length];
    
    for (int i = 0; i < arr.Length; i++)
    {
        int key = arr[i];
        int j = i - 1;
        // Перемещаем элементы arr[0..i-1], которые больше key, на одну позицию вправо от их текущего положения
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
    // записываем отсортированный массив arr[] в новый созданный массив resArr[]
    for (int i = 0; i < arr.Length; i++) resArr[i] = arr[i];
    return resArr;
}


// Вводим параметры массива с консоли:
// ps!! пишу код тут сверху, что бы объявить необходимые мне переменные
int arrLenght = ReadData("Введите длинну массива:");
int arrMinVol = ReadData("Введите Min значение элемента  массива (число должно быть > или = 0!!!):");
int arrMaxVol = ReadData("Введите Max значение элемента массива:");

// Метод сортировки массива  - "Подсчет"
int[] CountMethod(int[] arr)
{
    int [] resArr = new int[arr.Length];
    // задаем переменную n, равную длинне исходного массива arr[]
    int n = arr.Length;

    // Выходной массив int[], в котором будет отсортирован исходный массив arr[]
    // выходной массив int[] должен иметь длинну равную исходному массиву arr[]
    int[] output = new int[n];

    // Создаем массив count для хранения количества вхождений символов 
    // и инициализируем массив count  с 0-выми значениями. 
    // Длинна масива Lenght должна быть равна максимальному элементу в исходном массиве arr[]
    // ,то есть если максимальный элемент массива = 100, длина массива со счетчиками  count[] должна быть равна 100 + 1
    // (+1, чтобы захватить в диапазон значение =0)
    int[] count = new int[arrMaxVol + 1];

    // заполняем 0 массив счетчиков count[] с помощью цикла:
    for (int i = 0; i < (arrMaxVol + 1); i++) count[i] = 0;
    
    // сохраняем в массив count[] количество вхождений каждого символа массива arr[]
    // в ячейку с индексом равным символу элемента массива arr[]
    for (int i = 0; i < n; ++i) ++count[arr[i]];

    // Изменяем count[i] так, чтобы count[i] теперь содержал фактическую 
    // позицию этого элемента в выходном массиве:
    for (int i = 1; i <= arrMaxVol; ++i) count[i] += count[i - 1];

    // Собираем выходной массив символов
    // Чтобы сделать его стабильным, мы работаем в обратном порядке.
    for (int i = n -1; i  >= 0; i--)
    {
        output[count[arr[i]] - 1] = arr[i];
        --count[arr[i]];
    }
    
    // Копируем массив output[] в  массив arr[], 
    // теперь массив  arr[] будет содержать отсортированные символы
    for (int i = 0; i < n; ++i) arr[i] = output[i];

    // записываем отсортированный массив arr[] в новый созданный массив resArr[]
    for (int i = 0; i < arr.Length; i++) resArr[i] = arr[i];
    return resArr;
}


// Основной код программы:

//Генерируем 1D массив
int[] testArr = Gen1DArray(arrLenght, arrMinVol, arrMaxVol);

// Печатаем сгенерированный массив
Console.WriteLine("Исходный сгенерированный массив: ");
Print1DArr(testArr);
// Печатаем пустую строку
Console.WriteLine("");

// Сортируем массив методом InserMethod (Вставки) и записываем его в переменную insertArr[]:
int[] insertArr = InserMethod(testArr);

// Печатаем отсортированный массив
Console.WriteLine("Отсортированный массив методом Вставки: ");
Print1DArr(insertArr);

//Сортируем массив методом CountMethod (Подсчета) и записываем его в переменную countArr[]:
int[] counttArr = CountMethod(testArr);
// Печатаем пустую строку
Console.WriteLine("");
// Печатаем отсортированный массив методом Подсчета
Console.WriteLine("Отсортированный массив методом Подсчета: ");
Print1DArr(counttArr);

// Печатаем пустую строку
Console.WriteLine("");

Console.Write("Разница м/д Макс и Мин элементами массива: ");
PrintData(counttArr[counttArr.Length - 1] - counttArr[0]);

