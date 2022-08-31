// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1");
int b1 = Convert.ToInt32(Console.ReadLine());
b1 = Math.Abs(b1);
Console.WriteLine("Введите число k1");
int k1 = Convert.ToInt32(Console.ReadLine());
k1 = Math.Abs(k1);
Console.WriteLine("Введите число b2");
int b2 = Convert.ToInt32(Console.ReadLine());
b2 = Math.Abs(b2);
Console.WriteLine("Введите число k2");
int k2 = Convert.ToInt32(Console.ReadLine());
k2 = Math.Abs(k2);


if (k1==k2  &&  b1==b2)
{
    Console.WriteLine("Прямые прямые совпадают");
}
else if ( k1 == k2)
{
    Console.WriteLine("прямые прямые паралелны");
}

double x = 0;
double y = 0;

x = (b2-b1)/(k1-k2);
y = (k1*(b2-b1))/(k1-k2)+b1;
Console.WriteLine($"Кординаты точек {x} , {y}");

// я не понимаю как выводить дробное значение 
//у меня нули выводяться кода значение должно быть -0.5




