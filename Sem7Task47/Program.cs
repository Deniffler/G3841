// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

// Инициализируем массив с цветом символов
// ConsoleColor[] col = new ConsoleColor[]
// {ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
// ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
// ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
// ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
// ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
// ConsoleColor.Yellow};

// Функция (Метод) ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Функция (Метод) для заполнения 2D массива вещественными (doubl) числами
double[,] Gen2DArray(int row, int column)
{
    int i = 0; int j = 0;
    double[,] arr = new double[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = Math.Round(new Random().Next(0, 101) + new Random().NextDouble(), 4);
            j++;
        }
        i++;
    }
    return arr;
}

// Функция (Метод) вывода 2D  массива в консоль
void Print2DArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor(); 
        }
        Console.WriteLine("");
    }
}

// 1. Получение данных от пользователя
int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");

// 2. Генерируем 2D  массив
double[,] arr2D = Gen2DArray(n, m);

// 3. Печатаем двумерный массив
Print2DArr(arr2D);