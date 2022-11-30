// 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Clear();

int side1 = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int side2 = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int side3 = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");

string answer = "";
if (CheckInequality(side1,side2, side3)) answer = "да";

else answer = "нет";

Console.Write($"{side1}, {side2}, {side3} -> {answer}");


int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

bool CheckInequality(int num1, int num2, int num3)
{
    return (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1);
}


