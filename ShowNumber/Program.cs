Console.Write(ShowNumber(PutNumber("Введите число : ")));

string ShowNumber(int number)
{
    char[] arr = number.ToString().ToCharArray();
    return ($"First {arr[0]}, Third {arr[2]}");
}

int PutNumber(string greeting)
{
    Console.WriteLine(greeting);
    while (true)
    {
        int numberFromConsole = Convert.ToInt32(Console.ReadLine());

        //if (numberFromConsole >= 0 && numberFromConsole <= 99)
        if (numberFromConsole / 10 == 0 || numberFromConsole / 10 <= 9)
            Console.WriteLine("Введите минимум трехзначное число!!!");
        else
            return numberFromConsole;
    }
}