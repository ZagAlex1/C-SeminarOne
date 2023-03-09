// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если
// это невозможно, программа должна вывести сообщение
// для пользователя.

Console.Clear();
Random random = new Random();


int[,] array = FillArray(4, 4);
ReadArray(array);
ExamCondition(array);


void ExamCondition(int[,] array)
{
  if (array.GetLength(0) != array.GetLength(1))
    System.Console.WriteLine("Массив не подходит, подайте другой!!!");
  else
    ChangeRowsAndColumns(array);
}

void ChangeRowsAndColumns(int[,] array)
{
  int rowIndex = array.GetLength(0);
  int columnIndex = array.GetLength(1);
  int[,] newArray = new int[rowIndex, columnIndex];

  for (int i = 0; i < rowIndex; i++)
  {
    for (int j = 0; j < columnIndex; j++)
    {
      newArray[i, j] = array[j, i];
    }
  }
  ReadArray(newArray);
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
