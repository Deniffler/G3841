//Подключаем библиотеку
using System.Numerics;

// Метод читает данные от пользователя
string ReadDataStr(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

// Метод выводит результат пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

// Метод определяет знак действия выражения
string MathOperator(string str)
{
    string res = "";
    if (str.Contains("+")) res = "+";
    if (str.Contains("-")) res = "-";
    if (str.Contains("*")) res = "*";
    if (str.Contains("/")) res = "/";
    if (str.Contains("ˆ")) res = "ˆ";
    return res;
}

// Метод получения числа А и числа В
int NumbersAandB(string str, string znak, int indx)
{
    int res = 0;
    string strWoSp = str.Replace(" ", "");   // удаляем все пробелы
    string[] numbers = strWoSp.Split(znak);   // Делим строку сплитом и записываем в массив
    res = int.Parse(numbers[indx]);
    return res;
}

// Метод вычисления суммы
int Summa(int num1, int num2)
{
    int res = 0;
    res = num1 + num2;
    return res;
}

// Метод вычисления  разности
int Subtraction(int num1, int num2)
{
    int res = 0;
    res = num1 - num2;
    return res;
}

// Метод вычисления произведения
long Multiplication(long num1, long num2)
{
    long res = 0;
    res = num1 * num2;
    return res;
}

// Метод вычисления деления
double Divide(double num1, double num2)
{
    double res = 0.0;
    res = num1 / num2;
    return res;
}


// Метод вычисления возведение в степень
long Power(long num1, long num2)
{
    long res = 1;
    // res = Math.Pow(num1, num2);
    for (long i = 1; i <= num2; i++)
        res = res * num1;
    return res;
}

// ___________________________________________________//
// Основной код

// Вводим данные:
string mathExpress = ReadDataStr("Введите пример:");

// Записываем в переменную оператор действий
string mathOperator = MathOperator(mathExpress);

//Если вычисляем сумму:
if (mathOperator == "+")
{
    int numberA = NumbersAandB(mathExpress, MathOperator(mathExpress), 0);
    int numberB = NumbersAandB(mathExpress, MathOperator(mathExpress), 1);
    int result = Summa(numberA, numberB);
    PrintData("Решение равно: ", result);
}

//Если вычисляем разность:
if (mathOperator == "-")
{
    int numberA = NumbersAandB(mathExpress, MathOperator(mathExpress), 0);
    int numberB = NumbersAandB(mathExpress, MathOperator(mathExpress), 1);
    int result = Subtraction(numberA, numberB);
    PrintData("Решение равно: ", result);
}

//Если вычисляем произведение:
if (mathOperator == "*")
{
    long numberA = NumbersAandB(mathExpress, MathOperator(mathExpress), 0);
    long numberB = NumbersAandB(mathExpress, MathOperator(mathExpress), 1);
    long result = Multiplication(numberA, numberB);
    PrintData("Решение равно: ", result);
}

//Если решаем деление:
if (mathOperator == "/")
{
    double numberA = NumbersAandB(mathExpress, MathOperator(mathExpress), 0);
    double numberB = NumbersAandB(mathExpress, MathOperator(mathExpress), 1);
    double result = Divide(numberA, numberB);
    PrintData("Решение равно: ", result);
}


//Если возводим в степень:
if (mathOperator == "ˆ")
{
    long numberA = Convert.ToInt64(NumbersAandB(mathExpress, MathOperator(mathExpress), 0));
    long numberB = Convert.ToInt64(NumbersAandB(mathExpress, MathOperator(mathExpress), 1));
    long result = Power(numberA, numberB);
    PrintData("Решение равно: ", result);
}

