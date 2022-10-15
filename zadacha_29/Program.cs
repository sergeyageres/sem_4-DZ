// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

double ValueGet(string text)
{
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}
void Print(double ax, double ay, double az, double bx, double by, double bz, double result)
{
    string output = "|A(" + ax + ", " + ay + ", " + az + "); B(" + bx + ", " + by + ", " + bz + "); =" + result;
    Console.WriteLine(output);
}
double Distance3D(double ax, double ay, double az, double bx, double by, double bz)
{
    double x = Math.Pow(ax - bx, 2);
    double y = Math.Pow(ay - by, 2);
    double z = Math.Pow(az - bz, 2);
    double result = Math.Sqrt(x + y + z);
    return result;
}

double ax = ValueGet("ax");
double ay = ValueGet("ay");
double az = ValueGet("az");
double bx = ValueGet("bx");
double by = ValueGet("by");
double bz = ValueGet("bz");

double dis = Distance3D(ax, ay, az, bx, by, bz);
Print(ax, ay, az, bx, by, bz, dis);

