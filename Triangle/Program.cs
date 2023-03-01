// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длинны.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон. 

Console.Clear();

int a = PutNumber("Введите первую длинну : ");
int b = PutNumber("Введите вторую длинну : ");
int c = PutNumber("Введите третью длинну : ");

Triangle(a, b, c);


int PutNumber(string greeting)
{
    System.Console.Write(greeting);
    int numberFromConsole = Convert.ToInt32(Console.ReadLine());
    return numberFromConsole;
}

void Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
        System.Console.WriteLine("Треугольник может существовать!!!");
    else
        System.Console.WriteLine("Треугольник не может существовать!!!");
}

