Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for (int i = -number; i <= number; i++)
{
  Console.WriteLine(i);
}