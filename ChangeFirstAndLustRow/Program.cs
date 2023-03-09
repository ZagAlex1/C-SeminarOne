// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.


Console.Clear();
Random random = new Random();


int[,] array = FillArray(4, 4);
ReadArray(array);
ReadArray(ReplaceRows(array));

void ReadArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write("{0:d2} ", array[i, j]);
    }
    System.Console.WriteLine();
  }
  System.Console.WriteLine();
}

int[,] FillArray(int row, int column)
{
  int[,] array = new int[row, column];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      array[i, j] = random.Next(1, 20);
    }
  }
  return array;
}

int[,] ReplaceRows(int[,] array)
{
  int rowIndex = array.GetLength(0);
  int columnIndex = array.GetLength(1);
  int tmp;

  for (int i = 0; i < columnIndex; i++)
  {
    tmp = array[0, i];
    array[0, i] = array[columnIndex - 1, i];
    array[columnIndex - 1, i] = tmp;

  }
  return array;
}
