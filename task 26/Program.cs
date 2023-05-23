// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Len(int n) {
    string s = n.ToString();
    return s.Length;
}
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Количество цифр: {Len(Math.Abs(num))}");
