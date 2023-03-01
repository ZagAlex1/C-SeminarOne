// Задача 42: Напишите программу, которая будет преобразовывать десятичное число 
// в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Clear();

int numberFromConsole = PutNumber("Введите число для преобразования : ");

PrintArray(Fillarray(ArrayLength(numberFromConsole), numberFromConsole));

int PutNumber(string greeting)
{
  System.Console.Write(greeting);
  int numberFromConsole = Convert.ToInt32(Console.ReadLine());
  return numberFromConsole;
}

int ArrayLength(int numberFromConsole)
{
  int count = 0;
  for (int i = 0; numberFromConsole > 0; i++)
  {
    numberFromConsole /= 2;
    count++;
  }
  return count;
}

int[] Fillarray(int length, int numberFromConsole)
{
  int[] array = new int[length];
  for (int i = 0; i < array.Length; i++)
  {
    array[length - i - 1] = numberFromConsole % 2;
    numberFromConsole /= 2;
  }
  return array;
}

void PrintArray(int[] array)
{
  System.Console.WriteLine(string.Join("", array));
}
