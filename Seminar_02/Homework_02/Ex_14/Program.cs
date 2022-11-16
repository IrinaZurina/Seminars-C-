// Запрашиваем число от пользователя и преобразуем строку в целое число
Console.Write("Введите целое число и нажмите enter: ");
int userInput = int.Parse(Console.ReadLine() ?? "");

string answer;

// условие для проверки кратности числа и 7, и 23 одновременно
if (userInput % 7 == 0 & userInput % 23 == 0) answer = "да";
else answer = "нет";

Console.WriteLine($"{userInput} -> {answer}");