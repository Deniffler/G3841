// Задача №1
// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго  

// Вводим данные с консоли первое число
Console.WriteLine("Введите первое число");
string? inputNum1 = Console.ReadLine();

// Вводим данные с консоли второе число
Console.WriteLine("Введите второе число");
string? inputNum2 = Console.ReadLine();

// if проверка на нулевое значение
if (inputNum1 != null && inputNum2 != null)
{
    //конвертация строки в число
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    // Проверка условия
    if (number1 == (int)Math.Pow(number2, 2))
    {
        //Вывод если условие выполняется
        Console.Write("Первое число является - квадратом второго");
    }
    else
    {
        //Вывод если условие не выполняется
        Console.Write("Первое число не является квадратом второго числа");
    }

}