// Запрашиваем число от пользователя и преобразуем строку в целое число
Console.Write("Введите целое число и нажмите enter: ");
int userInput = int.Parse(Console.ReadLine() ?? "");

int userNumber = userInput;   // Переменная для вычисления третьей цифры
int thirdDigit;   // Переменная для самой третьей цифры
string answer;   // Переменная с ответом для итогового вывода

if (userNumber < 100) answer = "третьей цифры нет";
else
{
    while (userNumber > 999) userNumber = userNumber / 10;   // В цикле каждый раз убираем последнюю цифру, чтобы число стало трехзначным
    thirdDigit = userNumber % 10;   // вычисляем последнюю цифру в получившеся трехзначном числе
    answer = Convert.ToString(thirdDigit); // преобразуем цифру в строку для ответа
}

Console.WriteLine($"{userInput} -> {answer}");