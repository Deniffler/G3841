// Задача 14
// Напишите программу, которая будет принимать на вход одно число 
// и выводить является ли это число кратное 7 и 21.

// Вариант 1

// Вводим число с консоли
Console.Write("Введите число:");
int num1 = int.Parse(Console.ReadLine() ?? "0");

// Записываем результат остатока от деления числа на 7 и на 23 в переменные num1 и num2
int res1 = num1 % 7;
int res2 = num1 % 23;

// Проверяем условие: 
// если остаток от деления  == 0 то числа кратные 
// Результат выводим в консоль

if ((res1 == 0) && (res2 ==0 ))
{
    Console.Write("Число кратно 7 и 23");
}
else
{
    Console.Write("Число некратно 7 и 23");
}

// Вариант 2

// в оператор if сразу вставляется выражение,  минуя создание дополнительных переменных

int num = int.Parse(Console.ReadLine() ?? "0");
if ((num%7==0)&&(num%23==0)){
    Console.WriteLine("кратное");
}else{
    Console.WriteLine("не кратное 7и и 23ём");
}
int num1 = int.Parse(Console.ReadLine()??"0");

int res1 = num1%7;
int res2 = num1%23;
if((res1==0)&&(res2==0))
{
Console.WriteLine("Кратное ");
}

else
{
Console.WriteLine("Не кратно " + res1 + " " + res2);
}