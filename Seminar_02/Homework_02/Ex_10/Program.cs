// Запрашиваем число от пользователя и преобразуем строку в целое число
Console.Write("Введите целое трехзначное число от 100 до 999 и нажмите enter: ");
int userInput = int.Parse(Console.ReadLine() ?? "");

// Вычисляем разряд десятков
int secondDigit = (userInput % 100) / 10;

// Выводим результат
Console.WriteLine($"{userInput} -> {secondDigit}");
