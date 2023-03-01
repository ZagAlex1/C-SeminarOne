// Задача 42: Напишите программу, которая будет преобразовывать десятичное число 
// в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Clear();


System.Console.WriteLine(BinNumber(PutNumber("Введите число для преобразования : ")));

int PutNumber(string greeting)
{
    System.Console.Write(greeting);
    int numberFromConsole = Convert.ToInt32(Console.ReadLine());
    return numberFromConsole;
}

string BinNumber(int numberFromConsole)
{
    string binNumber = String.Empty;
    for (int i = 0; numberFromConsole > 0; i++)
    {
        binNumber = (numberFromConsole % 2).ToString() + binNumber;
        numberFromConsole /= 2;
    }
    return binNumber;
}