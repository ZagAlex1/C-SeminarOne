Console.Write("Введите нужное число ");
while(true) {
int number = Convert.ToInt32(Console.ReadLine());
if (number / 10 == 0 || number / 100 > 9)
{
  Console.WriteLine("Введите другое число");
}
else
{
  number = number % 10;
  Console.WriteLine(number);
  break;
}
}