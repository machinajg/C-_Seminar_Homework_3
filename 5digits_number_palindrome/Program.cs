// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число:  ");
int numA = Convert.ToInt32(Console.ReadLine());
if ((numA/10000) == numA % 10)
{
    if ((numA/1000) % 10 == (numA/10) % 10)
    Console.WriteLine($"{numA} - Палиндром!");
    else
    Console.WriteLine($"{numA} - НЕ Палиндром");
}
else
    Console.WriteLine($"{numA} - НЕ Палиндром");
