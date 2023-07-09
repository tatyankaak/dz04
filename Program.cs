using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите третье число:");
        int number3 = int.Parse(Console.ReadLine());

        int maxNumber = GetMaxNumber(number1, number2, number3);
        Console.WriteLine("Максимальное число: " + maxNumber);
    }

    static int GetMaxNumber(int number1, int number2, int number3)
    {
        int maxNumber = number1;

        if (number2 > maxNumber)
        {
            maxNumber = number2;
        }

        if (number3 > maxNumber)
        {
            maxNumber = number3;
        }

        return maxNumber;
    }
}