// Напишите программу, которая будет создавать копию массива
// с помощью поэлементного копирования.

Console.Clear();
Random random = new Random();

int[] array = FillArray(PutNumber("Введите количество элементов массива : "));
ReadArray(array);
int[] array1 = CopyArray(array);
ReadArray(array1);

int[] FillArray(int arrayLength)
{
  int[] array = new int[arrayLength];
  for (int i = 0; i < arrayLength; i++)
  {
    array[i] = random.Next(1, 101);
  }
  return array;
}

int[] CopyArray(int[] arrayToCopy)
{
  int[] newArray = new int[arrayToCopy.Length];
  for (int i = 0; i < arrayToCopy.Length; i++)
  {
    newArray[i] = arrayToCopy[i];
  } 
  return newArray;
}

int PutNumber(string greeting)
{
  System.Console.Write(greeting);
  int numberFromConsole = Convert.ToInt32(Console.ReadLine());
  return numberFromConsole;
}

void ReadArray(int[] array)
{
  string fibonachi = string.Join(" ", array);
  System.Console.WriteLine(fibonachi);
}

