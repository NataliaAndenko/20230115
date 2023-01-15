/*Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
int InputInt(string massage)
{
    Console.WriteLine(massage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = InputInt("Введите 1 число");
int b = 7;
int c = 23;

if (a % b == 0 && a % c == 0)
    Console.WriteLine("Да");
else Console.WriteLine("Нет");

