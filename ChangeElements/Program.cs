Console.Clear();

int[] array = SetArray(5);
ChangeElements(array);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
NeedNumber(array, 4);

int[] SetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-5, 6);
    System.Console.Write(array[i] + " ");
  }
  return array;
}

void ChangeElements(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == 0)
      array[i] = 0;
    else if (array[i] == Math.Abs(array[i]))
      array[i] = -(array[i]);
    else
      array[i] = Math.Abs(array[i]);
  }
}

void PrintArray(int[] array)
{
  Console.WriteLine(String.Join("|", array));
}

void NeedNumber(int[] array, int needNumber)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == needNumber)
    {
      result += array[i];
    }
  }
  if (result > 0)
    System.Console.WriteLine("Yes");
  else
    System.Console.WriteLine("No");
}


