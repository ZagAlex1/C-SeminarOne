Console.Write("Введите номер дня недели: ");
int weekNumber = Convert.ToInt32(Console.ReadLine());
string nameOfTheDay = "Monday";

switch (weekNumber)
{
  case 1:
    nameOfTheDay = "Monday";
    break;
  case 2:
    nameOfTheDay = "Tuesday";
    break;
  case 3:
    nameOfTheDay = "Wednesday";
    break;
  case 4:
    nameOfTheDay = "Thursday";
    break;
  case 5:
    nameOfTheDay = "Friday";
    break;
  case 6:
    nameOfTheDay = "Saturday";
    break;
  case 7:
    nameOfTheDay = "Sunday";
    break;
  default:
    Console.WriteLine("В неделе только семь дней");
    break;
}
    Console.WriteLine(nameOfTheDay);
