//  Задача 40 - HARD необязательная. 

// На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, 
// значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.


// Основной код программы
// Вводим данные с консоли от пользователя
double a = ReadData("Введите значение a: ");
double b = ReadData("Введите значение b: ");
double c = ReadData("Введите значение c: ");

if (ExistTriangle(a, b, c) == true)
{
    Console.WriteLine("Треугольник имеет следующие характеристики:");
    Console.WriteLine("");

    // Вычисляем площадь и периметр треугольника, функция arrSgrPer:
    double[] arrSgrPer = SqrPerimSolution(a, b, c);

    Console.WriteLine("Площадь треугольника равна: " + arrSgrPer[0]);
    Console.WriteLine("Периметр треугольника равен: " + arrSgrPer[1]);

    // Вычисляем углы треугольника, функция arrAngles
    double[] arrAngles = AngleSolution(a, b, c);

    // Проверка на равносторонность и равнобедренность, функции EquilateralTriangle и IsoscelesTriangle
    if (EquilateralTriangle(a, b, c) == true) Console.WriteLine("Треугольник равносторонний;");
    else if (IsoscelesTriangle(a, b, c) == true) Console.WriteLine("Треугольник равнобедренный;");
    else Console.WriteLine("Треугольник имеет разные стороны;");

    // Проверка на прямоугольность, функция Triangle90
    if (Triangle90(a, b, c) == true) Console.WriteLine("Треугольник прямоугольный;");
    else Console.WriteLine("Треугольник не имеет прямой угол;");

    Console.WriteLine("Углы треугольника равны: ");
    Console.WriteLine("альфа = " + arrAngles[0] + " град;");
    Console.WriteLine("альфа = " + arrAngles[1] + " град;");
    Console.WriteLine("альфа = " + arrAngles[2] + " град.");
}

else
{
    Console.WriteLine("Треугольник с заданными параметрами построить не возможно!!");
}

// Конец основного кода программы
//----------------------------------------------------------------------

// Функции для рассчета всех параметров
// Функция ввода данных с консоли
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}

// Функция проверяет возможность построения треугольника
bool ExistTriangle(double num1, double num2, double num3)
{
    // a = num1, b = num2, c = num3
    bool res = (a + b > c && a + c > b && b + c > a) ? true : false;
    return res;
}

// Функция проверяет равнобедренность треугольника
bool IsoscelesTriangle(double num1, double num2, double num3)
{
    // a = num1, b = num2, c = num3
    bool res = (num1 == num2 || num2 == num3 || num1 == num3) ? true : false;
    return res;
}

// Функция проверяет равносторонность треугольника
bool EquilateralTriangle(double num1, double num2, double num3)
{
    // a = num1, b = num2, c = num3
    bool res = (num1 == num2 && num1 == num3) ? true : false;
    return res;
}

// Функция вычисляет углы треугольника, в выходном массиве: 
// угол  alpha = array[0] угол  betta = array[1] угол  gamma = array[1]

double[] AngleSolution(double num1, double num2, double num3)
{
    // a = num1, b = num2, c = num3
    double[] array = new double[3];
    // Рассчитываем углы треугольника и округляем до 2 знаков
    double alpha = Math.Round((Math.Acos((num2 * num2 + num3 * num3 - num1 * num1) / (2 * num2 * num3)) * 180 / Math.PI), 2);
    double betta = Math.Round((Math.Acos((num1 * num1 + num3 * num3 - num2 * num2) / (2 * num1 * num3)) * 180 / Math.PI), 2);
    double gamma = Math.Round((Math.Acos((num1 * num1 + num2 * num2 - num3 * num3) / (2 * num1 * num2)) * 180 / Math.PI), 2);
    array[0] = alpha;
    array[1] = betta;
    array[2] = gamma;
    return array;
}

// Функция SqrPerimSolution  вычисляет площадь и периметр треугольникаб в выходном массиве:
// значение площади = arrSqrPer[0] , значение периметра = arrSqrPer[1]

double[] SqrPerimSolution(double num1, double num2, double num3)
{
    double[] arrSqrPer = new double[2];
    double perimetr = num1 + num2 + num3;
    double square = Math.Round(Math.Sqrt((perimetr / 2) * ((perimetr / 2) - num1) * ((perimetr / 2) - num2) * ((perimetr / 2) - num3)), 2);
    arrSqrPer[0] = square;
    arrSqrPer[1] = perimetr;
    return arrSqrPer;
}

// Функция проверяет прямоугольность треугольника
bool Triangle90(double num1, double num2, double num3)
{
    // a = num1, b = num2, c = num3
    // Вычисляем углы треугольника
    double[] arrAngles = AngleSolution(num1, num2, num3);
    bool res = (arrAngles[0] == 90 || arrAngles[1] == 90 || arrAngles[2] == 90) ? true : false;
    return res;
}



