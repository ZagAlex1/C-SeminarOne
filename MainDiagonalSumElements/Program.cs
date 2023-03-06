// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали(с индексами (0,0); (1,1) и т.д.)

Console.Clear();

Random random = new Random();

int[,] array = FillArray(4, 4);
ReadArray(array);
int sum = SumElementsMainDiagonal(array);
System.Console.WriteLine(sum);

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

int SumElementsMainDiagonal(int[,] array)
{
  int sum = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
     sum += array[i,i]; 
  }
  return sum;
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