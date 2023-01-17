// Задача 4: 
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// Вводим данные с консоли первое число
Console.WriteLine("Введите первое число:");
string? inputNum1 = Console.ReadLine();

// Вводим данные с консоли второе число
Console.WriteLine("Введите второе число:");
string? inputNum2 = Console.ReadLine();

// Вводим данные с консоли третье число
Console.WriteLine("Введите третье число:");
string? inputNum3 = Console.ReadLine();

// if проверка на нулевое значение
if (inputNum1 != null && inputNum2 != null && inputNum3 != null)
{
    //конвертация строки в число
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    int number3 = int.Parse(inputNum3);

    // объявляем переменную maximum и присваиваем ей значение первого числа
    int maximum = number1;

    // Сравниваем maximum с остальными числами
    if (number2 > number1)
        maximum = number2;
    if (number3 > maximum)
        maximum = number3;

    // выводим ответ в консоль
    Console.Write("Максимальное число равно: ");
    Console.WriteLine(maximum);

}