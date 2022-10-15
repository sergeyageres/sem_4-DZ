//  Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

void ValueNumber()
{
    Console.Write("Введите любое число от 1: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
        Console.WriteLine(" ");
    }
}
ValueNumber();