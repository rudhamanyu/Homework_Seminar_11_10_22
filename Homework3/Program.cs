/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/


string[] GetArray(string message)
{
    Console.WriteLine(message);
    string[] array = Console.ReadLine().Split(new char[] {','});
    Console.WriteLine();
    
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    return array;
}
GetArray("Введите через запятую 8 чисел:");