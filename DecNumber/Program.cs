// Задача 42: Напишите программу, которая будет преобразовывать десятичное число 
// в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Clear();

int number = PutNumber();

PrintArray1(Fillarray(Count(number), number));

int PutNumber()
{
  // System.Console.Write(greeting);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int Count(int number)
{
  int count = 0;
  for (int i = 0; number > 0; i++)
  {
    number /= 2;
    count++;
  }
  return count;
}

int[] Fillarray(int count, int number)
{
  int[] array = new int[count];
  for (int i = 0; i < array.Length; i++)
  {
    array[count - 1 - i] = number % 2;
    number /= 2;
  }
  return array;
}

void PrintArray(int[] array)
{
  System.Console.WriteLine(string.Join(" ", array));
}

void PrintArray1(int[] array)
{
  System.Console.WriteLine(string.Join("", array));
}

int[] ReversArray(int[] array)
{
  int[] arrayTwo = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    arrayTwo[i] = array[array.Length - i - 1];
  }
  return arrayTwo;
}