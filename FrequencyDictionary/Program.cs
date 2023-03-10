// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных.

Console.Clear();
Random random = new Random();

int[,] array = FillArray(3, 3);
ReadArray(array);
int[] oneDimArray = OneDimArray(array);
Array.Sort(oneDimArray);
ReadOneDimArray(oneDimArray);
CountElements(oneDimArray);

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

void ReadOneDimArray(int[] array)
{
  System.Console.WriteLine(String.Join(" ", array));
}

int[] OneDimArray(int[,] array)
{
  int rowIndex = array.GetLength(0);
  int columnIndex = array.GetLength(1);
  int[] oneDimArray = new int[rowIndex * columnIndex];
  int oneDimArrayIndex = 0;

  for (int i = 0; i < rowIndex; i++)
  {
    for (int j = 0; j < columnIndex; j++)
    {
      oneDimArray[oneDimArrayIndex] = array[i, j];
      oneDimArrayIndex++;
    }
  }
  return oneDimArray;
}

void CountElements(int[] array)
{
  int element = array[0];
  int count = 1;

  for (int i = 1; i < array.Length; i++)
  {
    if (element == array[i])
      count++;
    else
    {
      System.Console.WriteLine($"Число : {element} встречается : {count} раз");
      element = array[i];
      count = 1;
    }
  }
  System.Console.WriteLine($"Число : {element} встречается : {count} раз");
}