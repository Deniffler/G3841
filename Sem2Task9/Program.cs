// Задача 9
// Напишите программу, которая выводит случайные числа из отрезка [10...99] 
// и показывает наибольшую цифру этого числа.

// Вариант 1
// решение через нахождение остатка от деления

// создаем объект Random с именем numSintezator
System.Random numSintezator = new System.Random();

// Объявляем переменную rndNum и присваиваем ей случайное число в диапазоне от 10 до 99
int rndNum = numSintezator.Next(10, 100);

// Выводим в консоль сгенерированное random число
Console.WriteLine("Случайное число: " + rndNum);

// объявляем переменную digit1. Присваиваем ей значение результата деления на 10. 
// Это и будет первая цифра 2х значного числа
int digit1 = rndNum / 10;

// объявляем переменную digit1. Присваиваем ей значение результата остатка от деления на 10. 
// Это и будет вторая цифра 2х значного числа
int digit2 = rndNum % 10;


// Сравнивание полученных цифр мд собой
// и вывод результата в консоль
if (digit1 > digit2)
{
    Console.WriteLine("Цифра 1 больше цифры 2: " + digit1 + " " + digit2);
}
else
{
    Console.WriteLine("Цифра 2 больше цифры 1: " + digit1 + " " + digit2);
}

//Вариант 2
// Решение через массив

// Вводим число сразу в массив char. Присваиваем массив char в переменную digits.
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();

// Выводим переменную digits в консоль 
Console.WriteLine(digits);

// Объявляем int переменную digit1 и присваиваем ей значение первого члена массива
// Из за не совпадения типа переменных int->digit1 и string -> digits
// принудительно преобразуем переменную digits в int
int digit1 = (int)digits[0]-48;

// Объявляем int переменную digit2 и присваиваем ей значение второго члена массива
int digit2 = (int)digits[1]-48;

// объявляем переменную resNum  и присваиваем ей значение по условию:
// если digit1>digit2 и условие выполняется, то в переменную resNum записывается значение digit1
// если digit1>digit2 и условие не верно, то в переменную resNum записывается значение digit2
int resNum = digit1>digit2?digit1:digit2;

// Выводим переменную resNum в консоль 
Console.WriteLine(resNum);


//Вариант 3 
// решение записать готовые ответы в массив и потом просто вызвать элемент по индексу

// Объявляем переменную rndNum и присваиваем ей случайное число в диапазоне от 10 до 99
int rndNum = numSintezator.Next(10, 100);

// Выводим переменную rndNum в консоль 
Console.WriteLine(rndNum);

// Создаем массив из 99 элементов
int[] indxAnsw = new int[90];
indxAnsw[0] = 1;indxAnsw[1] = 1;indxAnsw[2] = 2;indxAnsw[3] = 3;indxAnsw[4] = 4;indxAnsw[5] = 5;indxAnsw[6] = 6;indxAnsw[7] = 7;indxAnsw[8] = 8;indxAnsw[9] = 9;
indxAnsw[10] = 2;indxAnsw[11] = 2;indxAnsw[12] = 2;indxAnsw[13] = 3;indxAnsw[14] = 4;indxAnsw[15] = 5;indxAnsw[16] = 6;indxAnsw[17] = 7;indxAnsw[18] = 8;indxAnsw[19] = 9;
indxAnsw[20] = 3;indxAnsw[21] = 3;indxAnsw[22] = 3;indxAnsw[23] = 3;indxAnsw[24] = 4;indxAnsw[25] = 5;indxAnsw[26] = 6;indxAnsw[27] = 7;indxAnsw[28] = 8;indxAnsw[29] = 9;
indxAnsw[30] = 4;indxAnsw[31] = 4;indxAnsw[32] = 4;indxAnsw[33] = 4;indxAnsw[34] = 4;indxAnsw[35] = 5;indxAnsw[36] = 6;indxAnsw[37] = 7;indxAnsw[38] = 8;indxAnsw[39] = 9;
indxAnsw[40] = 5;indxAnsw[41] = 5;indxAnsw[42] = 5;indxAnsw[43] = 5;indxAnsw[44] = 5;indxAnsw[45] = 5;indxAnsw[46] = 6;indxAnsw[47] = 7;indxAnsw[48] = 8;indxAnsw[49] = 9;
indxAnsw[50] = 6;indxAnsw[51] = 6;indxAnsw[52] = 6;indxAnsw[53] = 6;indxAnsw[54] = 6;indxAnsw[55] = 6;indxAnsw[56] = 6;indxAnsw[57] = 7;indxAnsw[58] = 8;indxAnsw[59] = 9;
indxAnsw[60] = 7;indxAnsw[61] = 7;indxAnsw[62] = 7;indxAnsw[63] = 7;indxAnsw[64] = 7;indxAnsw[65] = 7;indxAnsw[66] = 7;indxAnsw[67] = 7;indxAnsw[68] = 8;indxAnsw[69] = 9;
indxAnsw[70] = 8;indxAnsw[71] = 8;indxAnsw[72] = 8;indxAnsw[73] = 8;indxAnsw[74] = 8;indxAnsw[75] = 8;indxAnsw[76] = 8;indxAnsw[77] = 8;indxAnsw[78] = 8;indxAnsw[79] = 9;
indxAnsw[80] = 9;indxAnsw[81] = 9;indxAnsw[82] = 9;indxAnsw[83] = 9;indxAnsw[84] = 9;indxAnsw[85] = 9;indxAnsw[86] = 9;indxAnsw[87] = 9;indxAnsw[88] = 9;indxAnsw[89] = 9;

// Вызываем в консоль элемент с индексом искомого числа
Console.WriteLine(indxAnsw[rndNum-10]);