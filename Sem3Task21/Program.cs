// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.


// // ВАРИАНТ 1 Базовый

// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Метод выводит результат пользователю
// void PrintData(string msg, double res)
// {
//     Console.WriteLine(msg + res);
// }

// //Метод вычисляения расстояние между точками в 3D пространстве
// double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     double res = 0;
//     res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));
//     return res;
// }

// //Вводим координаты точек
// int coordX1 = ReadData("Введите координату x1");
// int coordX2 = ReadData("Введите координату x2");
// int coordY1 = ReadData("Введите координату y1");
// int coordY2 = ReadData("Введите координату y2");
// int coordZ1 = ReadData("Введите координату z1");
// int coordZ2 = ReadData("Введите координату z2");

// //Вычисляем длину
// double lenght = CalcLen(coordX1,coordX2,coordY1,coordY1,coordZ1,coordZ2);

// // Выводим результат:
// PrintData("Расстояние между точками равно: ", lenght);


//-------------------------------------------------------------------------------------


//ВАРИАНТ 2 
// ввоод  коррдинат по шаблону A(x,y,z);B(x,y,z)


// Метод читает данные от пользователя
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

//Метод выводит результат пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

//Метод вычисляения расстояние между точками в 3D пространстве
double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));
    return res;
}

// Метод сепаратор на вход принимает строку на выходе выдает int массив

int[] Separator(string coordinates)
{
    // Инициализируем пустой массив длинной 6 
    int[] res = new int[6];
    
    // создаем массив с сепараторами
    char[] separator = new char[] { 'A', 'B', 'a', 'b', ',', '(', ')', ';', ' ', '.' };

    // создаем подстроку subs и вычитаем сепараторы, в строке остануться только значения координат
    string[] subs = coordinates.Split(separator, StringSplitOptions.RemoveEmptyEntries);

    // добавляем в массив res значения координат
    
    res[0] = int.Parse(subs[0]);
    res[1] = int.Parse(subs[1]);
    res[2] = int.Parse(subs[2]);
    res[3] = int.Parse(subs[3]);
    res[4] = int.Parse(subs[4]);
    res[5] = int.Parse(subs[5]);

    return res;
}

//Вводим координаты точек
string coordinates = ReadData("Введите коррдинаты по шаблону A(x,y,z);B(x,y,z):");

// Передаем введенные значения в Метод Separator результат записываем в массив int [] coordinat
 
int[] coordinat = Separator(coordinates);

//Вычисляем длину
double lenght = CalcLen(coordinat[0],coordinat[1], coordinat[2],coordinat[3],coordinat[4],coordinat[5]);

// Выводим результат:
PrintData("Расстояние между точками равно: ", lenght);