// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1;

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1 
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();

ReadArray(Fibonachi(PutNumber("Введите число : ")));

int PutNumber(string greeting)
{
  System.Console.Write(greeting);
  int numberFromConsole = Convert.ToInt32(Console.ReadLine());
  return numberFromConsole;
}

int[] Fibonachi(int numberFromConsole)
{
  int[] fibArray = new int[numberFromConsole];
  fibArray[0] = 0;
  fibArray[1] = 1;
  for (int i = 2; i < (numberFromConsole); i++)
  {
    fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
  }
  return fibArray;
}

void ReadArray(int[] array)
{
  string fibonachi = string.Join(" ", array);
  System.Console.WriteLine(fibonachi);
}