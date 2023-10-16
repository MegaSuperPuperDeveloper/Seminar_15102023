// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumOfNum(int N, int sum = 0) { // Функция считает сумму чисел числа.
    if(N % 10 == 0) return sum;
    else sum += N % 10;
    N /= 10;
    return SumOfNum(N, sum);
}

Console.Write("Введите число, сумма чисел которого вас интересует: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{N} -> {SumOfNum(N)}");