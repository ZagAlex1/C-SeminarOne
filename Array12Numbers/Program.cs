Console.Clear();

int negative = 0;
int positive = 0;

int[] SetArray()
{
  int[] array = new int[12];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-9, 10);
    System.Console.Write(array[i] + " ");
  }
  System.Console.WriteLine();
  return array;
}

void NegOrPos(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
      positive += array[i];
    else
      negative += array[i];
  }
  System.Console.WriteLine($"Сумма положительных : {positive} Сумма отрицательных : {negative}");
}

NegOrPos(SetArray());