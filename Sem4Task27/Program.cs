// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// Метод читает данные от пользователя
int ReadDataStr(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит результат пользователю
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}


//Метод считает сумму цифр числа используя char

int SummaNumDigChar(int num)
{
    int res = 0;
    // Конвертируем int число в строку
    string str = num.ToString();
    for(int i = 0; i < str.Length; i++)
    {   
        // Так как в char хрянятся символы в формате ASCII то мы отнимаем при каждой итерации 
        // значение ASCII - '0' = 48
        res = res + (str[i] - '0');
    }
    return res;
}

//Метод считает сумму цифр числа используя остаток от деления
int SummaNumDigRemOfDiv(int num)
{
    int res = 0;
    while (num >0)
    {
        res = res + num%10;
        num = num /10;
    }
    return res;
}


//Начало основного кода

//Вводим данные с консоли
int number = ReadDataStr("Введите положительное, целое число: ");

// Вычисляем сумму методом char
DateTime d1 = DateTime.Now;
int summaChar = SummaNumDigChar(number);


// Вычисляем сумму методом RemOfDig
DateTime d2 = DateTime.Now;
int summaRemOfDiv = SummaNumDigRemOfDiv(number);


// Печатаем результат: 
PrintData("(Метод char) Сумма цифр числа равна: ", summaChar);
Console.Write("Время решения по методу Char равно: ");
Console.WriteLine(DateTime.Now - d1);
Console.WriteLine(" ");
PrintData("(Метод RemOfDiv) Сумма цифр числа равна: ", summaChar);
Console.Write("Время решения по методу RemOfDig равно: ");
Console.WriteLine(DateTime.Now - d2);


