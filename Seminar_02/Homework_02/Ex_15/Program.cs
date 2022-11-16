// Запрашиваем число от пользователя и преобразуем строку в целое число
Console.Write("Введите целое число от 1 до 7 и нажмите enter: ");
int userInput = int.Parse(Console.ReadLine() ?? "");

string answer;

// проверяем, правильно ли пользователь ввел число
if (userInput < 1 | userInput > 7) 
{
    Console.WriteLine("Введено неправильное число");
    Console.Write("Введите целое число от 1 до 7 и нажмите enter: ");
    userInput = int.Parse(Console.ReadLine() ?? "");
}

// Условие для проверки дня недели
if (userInput == 6 | userInput == 7) answer = "да";
else answer = "нет";

Console.WriteLine($"{userInput} -> {answer}");