// Запрашиваем числа от пользователя и преобразуем строки в целые числа
Console.Write("Введите первое целое число и нажмите enter: ");
int userInput1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе целое число и нажмите enter: ");
int userInput2 = int.Parse(Console.ReadLine() ?? "");

int leftover = userInput2 % userInput1;
string answer;

if (leftover == 0) answer = "кратно";
else answer = $"не кратно, остаток {leftover}";

Console.WriteLine($"{userInput2}, {userInput1} -> {answer}");