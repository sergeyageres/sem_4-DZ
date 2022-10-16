//   Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("введите число ");

Console.WriteLine(sum);

static int NewMethod()
{
    int a = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}
int sum = NewMethod();