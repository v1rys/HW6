// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число М оно будет показывать сколько чисел вам нужно бут ввести");
int M = Convert.ToInt32(Console.ReadLine());
int CounterMZero = CounterForMoreZero(M);
Console.WriteLine($"Чисел больше нуля {CounterMZero}");


int CounterForMoreZero(int num)
{
    int [] arr = new int [M];
    int counter = 0;
    for(int i = 0; i < arr.Length; i++ )
    {
        Console.WriteLine("Введите число X");
        int X = Convert.ToInt32(Console.ReadLine());
        arr[i] = X;
        if ( arr[i] > 0)
        {
           counter++; 
        }
    }
    return counter;
}
