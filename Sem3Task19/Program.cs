// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.


// //БАЗОВЫЙ ВАРИАНТ


// // Объявляем переменную FiveNumDig и присваиваем ей значение введенное пользователем (Метод ReadData)
// int FiveNumDig = ReadData("Введите 5-ти значное число");

// // Вызываем метод PaliTest и скармливаем ему переменную FiveNumDig
// bool answer = PaliTest(FiveNumDig);
// //Выводим ответ пользователю на экран
// if(answer == true) PrintData("Число: " + FiveNumDig + " является палиндромом :))");
// if(answer == false) PrintData("Число: " + FiveNumDig + " не является палиндромом :((");
// //---------------------------------------------------------------------------------------
// // Код ниже это Методы (функции)

// // Метод определения палиндрома 12721
// bool PaliTest(int num)
// {
//     bool res = false;
//     int d1 = num / 10000;
//     int d2 = (num / 1000) % 10;
//     int d3 = (num / 10) % 10;
//     int d4 = num % 10;
//     res = ((d1 == d4) && (d2 == d3)) ? true : false;
//     return res;
// }


// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Метод выводит результат пользователю
// void PrintData(string msg )
// {
//     Console.WriteLine(msg);
// }

//--------------------------------------------------------------------------------------------
// ВАРИАНТ 2 через словарь

// в этом варианте я может быть не совсем правильно понял условие как необходимо выполнить решение задачи.  
// Мое решение сводится к заполнению словаря всеми возможными комбинациями 5-ти значных цифр.
// Само 5-ти значное число является ключом словаря,  а в его значении лежит метка палиндром или нет. 
// По этому при проверке,  тк словарь уже заполнен всеми возможными комбинациями достаточно вывести значение по ключу.


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод заполнения словаря FillDictionary

string FillDictionary(int num)
{
    //Объявляем переменную res и присваиваем ей значение пnull
    string res = null;

    // Начальное значение счетчика. Левая граница диапазона всех 5-ти значных чисел
    int count = 10000;
    // Иницилизация пустого словаря с именем allPalindr
    Dictionary<int, string> allPalindr = new Dictionary<int, string>();
    
    //Перебор всех 5-ти значных чисел. 99999 - это права граница диапазона всех 5-ти значных чисел
    while (count <= 99999)
    {
        // Парсим первые 2 и последние 2 цифры  числа
        int d1 = count / 10000;
        int d2 = (count / 1000) % 10;
        int d3 = (count / 10) % 10;
        int d4 = count % 10;
        // Проверяем является ли число палиндромом
        if ((d1 == d4) && (d2 == d3))
        {
            // создаем строковую переменную value и записываем в нее число "d1d2d3d4"
            // ToString конвертирует из int в string
            string value = "Число является палиндромом " + d1.ToString() + d2.ToString() + d3.ToString() + d4.ToString();
            // добавляем новый эл-т массива allPalindr с ключом - count и значением - value
            allPalindr.Add(count, value);
        }
        else
        {
            string value = "Число не является палиндромом";
            allPalindr.Add(count, value);
        }
        count = count + 1;

    }


    // // только для проверки вывод в консоль словаря
    // foreach (var item in allPalindr)
    // {
    //     Console.WriteLine($"Ключ: {item.Key}  Значение: {item.Value}");
    // }

    res = allPalindr[num];
    return res;

}


// Объявляем переменную FiveNumDig и присваиваем ей значение введенное пользователем (Метод ReadData)
int FiveNumDig = ReadData("Введите 5-ти значное число");

// Заполняем словарь данными и скармливаем в функцию значение 
string answer = FillDictionary(FiveNumDig);


//Выводим результат по ключу

PrintData("Число: " + FiveNumDig + " " + answer);

//PrintData("Число: " + FiveNumDig + answer);

