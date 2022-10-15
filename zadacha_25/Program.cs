// Задача 25: опишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в целую степень B.

void Metod(int a, int b)
{
    int sum = a;
    for (int i = 1; i < b; i++)
    {
        sum = sum * a;
    }
    Console.WriteLine(a + " в степени " + b + " равно = " + sum);
}
Console.WriteLine("введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень");
int b = Convert.ToInt32(Console.ReadLine());
Metod(a, b);