/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

void PalindromeNumber(int number)
{
    Console.Write($"{number} -> ");
    
    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10) 
        Console.WriteLine("Является палендромом");
    else
        Console.WriteLine("Не является палендромом");
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
PalindromeNumber(num);