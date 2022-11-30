// 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double b1 = GetNumberFromUser("Введите Коэффициент b1: ","Ошибка ввода!");
double k1 = GetNumberFromUser("Введите Коэффициент k1: ","Ошибка ввода!");
double b2 = GetNumberFromUser("Введите Коэффициент b2: ","Ошибка ввода!");
double k2 = GetNumberFromUser("Введите Коэффициент k2: ","Ошибка ввода!");

double coordX = FindCoordX(b1, k1, b2, k2);
double coordY = k1 * coordX + b1;

Console.WriteLine($"Координаты точки пересечения двух прямых: X = {coordX}, Y = {coordY}");

double GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

double FindCoordX(double b1, double k1, double b2, double k2)
{
    double result = (b2 - b1)/(k1 - k2);
    return result;
}