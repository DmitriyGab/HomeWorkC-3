// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int v1 = number / 10000;
    Console.WriteLine(v1);
    int v2 = (number / 1000) % 10;
    Console.WriteLine(v2);
    int v4 = (number % 100) / 10;
    Console.WriteLine(v4);
    int v5 = number % 10;
    Console.WriteLine(v5);
    
    if (v1 == v5 && v2 == v4)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    
    else 
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}

else 
{
    Console.WriteLine($"Введенное число {number} не является пятизначным");
}












// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
