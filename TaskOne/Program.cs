// Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

int[,] TwoRandomArray()
{
  Console.WriteLine("Введите количество строк двумерного массива: ");
  int m = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите количество столбцов двумерного массива: ");
  int n = Convert.ToInt32(Console.ReadLine());
  int[,] array = new int[m, n];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 11);
      Console.Write(array[i, j] + " ");
    }
  }
  return array;
}
int[,] array = TwoRandomArray();
System.Console.WriteLine("\n");
// ReadArray(ChangedRowsArray(array));
// ReadArray(ChangeRowsWithColumns(array));
int[] convertedArray = ConvertedArray(array);
Array.Sort(convertedArray);
System.Console.WriteLine(String.Join(" ",convertedArray));
CountElements(convertedArray);

void CountElements(int [] sortedArray)
{
  int element = sortedArray[0];
  int count = 1;
  for (int i = 1; i < sortedArray.Length; i++)
  {
    if(element == sortedArray[i])
    count++;
    else
    {
    System.Console.WriteLine($"Элемент : {element} встретился {count} раз");
    element = sortedArray[i];
    count = 1;
    }
  }
  System.Console.WriteLine($"Элемент : {element} встретился {count} раз");
}

int[] ConvertedArray(int[,] array)
{
  int m = array.GetLength(0);
  int n = array.GetLength(1);
  int arrayIndex = 0;

  int[] newArray = new int[m * n];
  foreach (int item in array)
  {
    newArray[arrayIndex] = item;
    arrayIndex++;
  }
  return newArray;
}

int[,] ChangeRowsWithColumns(int[,] array)
{
  int m = array.GetLength(0);
  int n = array.GetLength(1);

  int[,] newArray = new int[m, n];

  if (m != n)
    System.Console.WriteLine("Массив не подходит!!!");
  else
  {
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        newArray[i, j] = array[j, i];
      }
    }
  }
  return newArray;
}

int[,] ChangedRowsArray(int[,] array)
{

  int m = array.GetLength(0);
  int n = array.GetLength(1);
  for (int i = 0; i < array.GetLength(1); i++)
  {
    int tmparray = array[0, i];
    array[0, i] = array[m - 1, i];
    array[m - 1, i] = tmparray;
  }
  return array;
}

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
}

