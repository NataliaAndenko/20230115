/*Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
*/
int a = new Random().Next(10, 100);
int b = a / 10;
int c = a % 10;
Console.WriteLine($"Сравниваем числа в {a}");
if (b > c)
{
    Console.WriteLine($"Больше {b}");
}
else
{
    Console.WriteLine(c);
}