// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.



int Prompt(string message)
{
    System.Console.Write(message);
    string readVelue = Console.ReadLine();
    int result = int.Parse(readVelue);
    return result;
}

int MathPow(int num1, int num2) 
{
    int mult = 1;
    for (int i = 1; i <= num2; i++)
    {
        mult = mult * num1;
    }
    return mult;
}


int num1 = Prompt("Введите число, которое нужно возвести в степень ->");
int num2 = Prompt("Введите степень ->");

System.Console.WriteLine($"Число {num1} в степени {num2} равно {MathPow(num1,num2)}");
