// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1;

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1 
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();

Fibonachi(PutNumber("Введите число : "));

int PutNumber(string greeting)
{
    System.Console.Write(greeting);
    int numberFromConsole = Convert.ToInt32(Console.ReadLine());
    return numberFromConsole;
}

void Fibonachi(int numberFromConsole)
{
    int number = 0;
    for (int i = 0; i < numberFromConsole; i++)
    {
        
    }
}