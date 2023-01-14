// Задача №0
// Напишите программу, которая на вход принимает
// число и выдает его квадрат (число умноженное на само себя)
// приглашение ввести число
Console.WriteLine("Введите целое число: ");
// считываем введеные данные
string? inputNum = Console.ReadLine();
// if проверка на нулевое значение
if (inputNum!=null)
{
    // //конвертация строки в число
    // int number = int.Parse(inputNum);
    // // возводим число в квадрат
    // //int result = number * number;
    // // второй вариант решения через встроенный класс функция
    // int result = (int)Math.Pow(number,2);
    // // выводим ответ в консоль
    // Console.Write("Квадрат числа  ");
    // Console.Write(number);
    // Console.Write(" равен: ");
    // Console.WriteLine(result);
    // вариант программы в одну строчку
    Console.WriteLine(Math.Pow(int.Parse(inputNum),2));
}