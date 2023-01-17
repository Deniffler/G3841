// Задача 2: 
// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

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
    if (number1 > number2)
    {
        //Вывод если условие выполняется
        Console.Write("Первое число: ");
        Console.Write(number1);
        Console.Write(" Больше второго числа: ");
        Console.Write(number2);
        Console.WriteLine(" и является максимальным. ");
    }
    else
    {
        //Вывод если условие выполняется
        Console.Write("Первое число: ");
        Console.Write(number1);
        Console.Write(" Меньше второго числа: ");
        Console.Write(number2);
        Console.WriteLine(" и является минимальным. ");
    }
}