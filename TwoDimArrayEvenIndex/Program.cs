// Задайте двумерный массив. Найдите элементы
// у которых оба индекса четные, и замените эти элементы
// на их квадраты.

// 1 4 7 2        1 4 7 2
// 5 9 2 3        5 81 2 9
// 8 4 2 4        8 4 2 4

Console.Clear();

Random random = new Random();

int[,] array = FillArray(5, 5);
ReadArray(array);
System.Console.WriteLine();
int[,] changedArray = ChangeArray(array);
ReadArray(changedArray);

int[,] FillArray(int row, int column)
{
  int[,] array = new int[row, column];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      array[i, j] = random.Next(1, 10);
    }
  }
  return array;
}

int[,] ChangeArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
        array[i, j] *= array[i, j];
    }
  }
  return array;
}

void ReadArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
  }
}