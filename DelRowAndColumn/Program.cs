// Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.

Console.Clear();
Random random = new Random();

int[,] array = FillArray(4, 4);
ReadArray(array);
ReadOneDimArray(FindMinElement(array));
ReadArray(DelRowsColumns(array, FindMinElement(array)));

int[,] FillArray(int row, int column)
{
  int[,] array = new int[row, column];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = random.Next(1, 21);
    }
  }
  return array;
}

void ReadOneDimArray(int[] array)
{
  System.Console.WriteLine(string.Join(" ", array));
  System.Console.WriteLine();
}

void ReadArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write($"{array[i, j]:d2} ");
    }
    System.Console.WriteLine();
  }
  System.Console.WriteLine();
}

int[] FindMinElement(int[,] array)
{
  int[] minElementArray = new int[2];
  int minElement = array[0, 0];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < minElement)
      {
        minElement = array[i, j];
        minElementArray[0] = i;
        minElementArray[1] = j;
      }
    }
  }
  return minElementArray;
}

int[,] DelRowsColumns(int[,] array, int[] oneDimArray)
{
  int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
  int rowIndex = 0;
  int columnIndex = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    if (i == oneDimArray[0])
      continue;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (j == oneDimArray[1])
        continue;
      else
      {
        newArray[rowIndex, columnIndex] = array[i, j];
        columnIndex++;
      }
    }
    rowIndex++;
    columnIndex = 0;
  }
  return newArray;
}