// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Mult(int num) {
    int mult = 1;
    for(int i = 1; i <= num; i++) {
        mult *= i;
    }
    return mult;
}

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = Mult(num);
Console.Write($"Произведение чисел от 1 до {num}: {result}");
