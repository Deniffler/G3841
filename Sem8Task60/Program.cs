// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Основные методы для работы программы

// Функция (Метод) ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Функция (Метод) печати 3D массива
void Print3DArr (int[,,] arr3D)
{
  for (int i = 0; i < arr3D.GetLength(0); i++)
  {
    for (int j = 0; j < arr3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < arr3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={arr3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

//Функция (Метод) генерации 3D массива
void Gen3DArray(int[,,] arr3D)
{
  int[] temp = new int[arr3D.GetLength(0) * arr3D.GetLength(1) * arr3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arr3D.GetLength(0); x++)
  {
    for (int y = 0; y < arr3D.GetLength(1); y++)
    {
      for (int z = 0; z < arr3D.GetLength(2); z++)
      {
        arr3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

// Основной код программы
Console.Clear();

// 1. Получение данных от пользователя
Console.WriteLine("Введите размер 3D массива X-Y-Z");
int x = ReadData("Введите X: ");
int y = ReadData("Введите Y: ");
int z = ReadData("Введите Z: ");
Console.WriteLine();

// 2. Инициализируем пустой 3D массив размером X-Y-Z
int[,,] array3D = new int[x, y, z];

// 3. Заполняем 3D массив
Gen3DArray(array3D);

// 4. Печатаем результат
Print3DArr(array3D);

