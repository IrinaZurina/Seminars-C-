// Запрашиваем числа от пользователя и преобразуем строки в целые числа
Console.Write("Введите первое целое число и нажмите enter: ");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе целое число и нажмите enter: ");
int num2 = int.Parse(Console.ReadLine() ?? "");

string answer;

// проверяем, является ли одно число равным квадрату другого
if (num1 == num2 * num2 | num2 == num1 * num1) answer = "да";
else answer = "нет";

Console.WriteLine($"{num1}, {num2} -> {answer}");
