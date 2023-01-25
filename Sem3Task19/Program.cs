// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// Объявляем переменную FiveNumDig и присваиваем ей значение введенное пользователем (Метод ReadData)
int FiveNumDig = ReadData("Введите 5-ти значное число");

// Вызываем метод PaliTest и скармливаем ему переменную FiveNumDig
PaliTest(FiveNumDig);
//Выводим ответ пользователю на экран
Console.WriteLine(res);

//---------------------------------------------------------------------------------------
// Код ниже это Методы (функции)

// Метод определения палиндрома 12721
bool PaliTest(int num)
{
    bool res = false;
    int d1 = num / 10000;
    int d2 = (num / 1000) % 10;
    int d3 = (num / 10) % 10;
    int d4 = num % 10;
    res = ((d1 == d4) && (d2 == d3)) ? true : false;
    return res;
}


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат пользователю
// void PrintData(string msg )
// {
//     Console.WriteLine(msg);
// }