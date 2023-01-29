// Задача №29 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// * Ввести с клавиатуры длину массива и диапазон значений элементов  
// *** Дополнительно: Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал

// ВАРИАНТ 1 Базовое решение задачи:

// //Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// int[] Gen1DArr(int num, int begin, int end)
// {
//     Random rnd = new Random();
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(begin, end);
//     }
//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length-1; i++)
//     {
//         Console.Write(arr[i]+", ");
//     }
//     Console.WriteLine(arr[arr.Length-1]+"]");
// }

// int arrLen = ReadData("Введите длину массива: ");
// int arrFirst = ReadData("Введите левый диапазон эл-тов: ");
// int arrEnd = ReadData("Введите правый диапазон эл-тов: ");

// int[] arr = Gen1DArr(arrLen, arrFirst, arrEnd);

// Print1DArr(arr);

//ВАРИАНТ 2 дополнительное решение задачи

//Метод читает данные от пользователя
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

// Метод выводит результат пользователю
void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}

// Метод получения  случайного имени из списка
string HappyName(string str)
{
    string res = "";
    string strkWoSp = str.Replace(" ", "");         // удаляем все пробелы
    string[] arrNames = strkWoSp.Split(",");        // Делим строку сплитом и записываем в массив
    Random rnd = new Random();                      // Подключаем рандомайзер
    int indx = rnd.Next(0, arrNames.Length);        // записываем в переменную рандомный индекс элемента массива
    res = arrNames[indx];                           // выводим элемент массива с рандомным индексом  
    return res;
}

// Вводим данные
string spisok = ReadData("Введите список имен через запятую");
string KtoIdetZaPivom = HappyName(spisok);

// Выводим результат:
PrintData("За пивом идет - ", KtoIdetZaPivom);
