// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// Метод рекурсии вычисляет сумму чисел от M до N
 int GetSum(int m, int n)
{
    if (n > m)
        return n + GetSum(m, n - 1);
    return m;
}

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод выводит результат пользователю
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

// Основной код программы
// 1  Вводим данные
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

// 2 Считаем сумму
int sum = GetSum(m,n);

// Выводим результат
PrintData("Сумма элементов от М до N равна: ",sum);



