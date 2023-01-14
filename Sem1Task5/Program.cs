// Задача №5
// Напишите программу, которая на вход принимает одно число N
// На выходе выдает все целые числа в диапазоне от -N до N

// Вводим данные с консоли -  число
Console.WriteLine("Введите целое число");
string? inputNum = Console.ReadLine();

// if проверка на нулевое значение
if (inputNum != null)
{
    //конвертация строки в число
    int number1 = int.Parse(inputNum);
    // определяем вторую границу диапазона
    int number2 = number1 * (-1);
    // объявляем пустую строковую переменную - outNumLine
    string outNumLine = string.Empty;
    // Цикл пока выполняется условие
    while (number2 < number1 + 1)
    {
        // Записываем при каждой итерации результат в переменную
        outNumLine = outNumLine + number2 + ",";
        // Увеличиваем счетчик на 1
        number2 = number2 + 1;
    }
    // Выводим результат в консоль
    Console.WriteLine(outNumLine);
}