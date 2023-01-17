// Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Вводим данные с консоли 
Console.WriteLine("Введите целое положительное число");
string? inputNum = Console.ReadLine();

// if проверка на нулевое значение
if (inputNum != null)
{
    //конвертация строки в число
    int number = int.Parse(inputNum);

    // объявляем пустую строковую переменную - outNumLine
    string outNumLine = string.Empty;

    // задаем счетчик начиная с 2
    int count = 2;
    // если число четное:
    if (number % 2 == 0)
    {
        while (count < number)
        {
            // Записываем при каждой итерации результат в переменную
            outNumLine = outNumLine + count + ",";
            count = count + 2;
        }

        // Выводим результат в консоль
        Console.WriteLine(outNumLine + number);
    }

    //если число не четное:
    else
    {
        // если число равно 1
        if (number == 1)
        {
            Console.WriteLine("Введите число больше 1");
        }
        else
        {
            while (count < number - 1)
            {
                // Записываем при каждой итерации результат в переменную
                outNumLine = outNumLine + count + ",";
                count = count + 2;
            }
            // Выводим результат в консоль
            Console.WriteLine(outNumLine + (number - 1));
        }

    }

}