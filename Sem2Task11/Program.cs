// Задача 11
// Напишите программу, которая выводит случайное 3-х значное число 
// и удаляет вторую цифру этого числа.

// Вариант 1
// решение через остаток от деления

// генерируем случайное 3-х значное число
System.Random newSintezator = new System.Random();
int num = newSintezator.Next(100,1000);

// присваеваем переменной digitfirst значение первой цифры 3-х значного числа
// делим int число на 100
int digitfirst = num/100;

// присваеваем переменной digitLast значение третьей цифры 3-х значного числа
// остаток от деления на 10
int digitLast = num%10;

// Выводим в консоль сгенерированное 3-х значное число
Console.WriteLine(num);

// Выводим результат в консоль
Console.WriteLine(digitfirst*10 + digitLast);

// Вариант 2
// решение через массив

// генерируем случайное 3-х значное число
System.Random random = new System.Random();
int randomNumber = random.Next(100,1000);

// Выводим в консоль сгенерированное 3-х значное число
Console.WriteLine("число: " + randomNumber);

// конвертируем сгенерированное число в строку и записываем в переменную value
string value = randomNumber.ToString();

// Создаем маасив и записываем в него сгенерированное число
char[] numberArray = value.ToCharArray();

// Выводим по индексу первый и последний члены массива в консоль
Console.WriteLine(numberArray[0] + "" + numberArray[2]);