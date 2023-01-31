// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Метод читает данные от пользователя
string ReadDataStr(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

//Метод считает кол-во положительных элементов
int CountPositivNumber(string str)
{
    int count = 0;
    // удаляем все пробелы если они есть
    string strWoSp = str.Replace(" ", "");

    // дели строку сплитом и записываем в строковый массив strArr[]
    string[] strArr = strWoSp.Split(",");

    // создаем пустой int[]  массив
    int[] intArr = new int[strArr.Length];

    // конвертируем массив из string в int
    for (int i = 0; i < intArr.Length; i++) intArr[i] = int.Parse(strArr[i]);

    // считаем кол-во положительных элементов массива
    for (int i = 0; i < intArr.Length; i++) if (intArr[i] > 0) count++;

    return count;
}

// Вводим данные:
string sequenceNumbers = ReadDataStr("Введите последовательность чисел: ");

// Считаем кол-во положительных чисел
int countPosNum = CountPositivNumber(sequenceNumbers);

// Выводим результат
Console.WriteLine("Количество положительных чисел равно: " + countPosNum);



