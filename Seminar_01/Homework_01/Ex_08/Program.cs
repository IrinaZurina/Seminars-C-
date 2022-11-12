// Запрашиваем число от пользователя
Console.Write("Введите целое число и нажмите enter: ");
string userInput = Console.ReadLine() ?? "";  

// преобразование строки в число
int user_num = int.Parse(userInput);

// вводим переменную с первым четным числом
int even_num = 2;
Console.Write($"{user_num} -> ");

// цикл для перечисление всех четных чисел, кроме последнего
while (even_num < user_num - 1)
{
    Console.Write($"{even_num}, ");
    even_num += 2;
}

// последнее число выводим отдельно, чтобы не было запятой в конце
Console.Write($"{even_num}");