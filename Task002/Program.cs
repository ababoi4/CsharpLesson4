// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message);
    string readVelue = Console.ReadLine();
    int result = int.Parse(readVelue);
    return result;
}

int SumNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int D = number % 10;
        number = number / 10;
        sum = sum + D;
    }
    return sum;
}

int number = Prompt("Введите число ->");
System.Console.WriteLine($"Сумма цифр в данном числе равна {SumNumber(number)}");