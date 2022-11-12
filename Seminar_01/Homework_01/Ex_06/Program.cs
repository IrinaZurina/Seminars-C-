// Запрашиваем число от пользователя
Console.Write("Введите целое число и нажмите enter: ");
string userInput = Console.ReadLine() ?? "";  

// преобразование строки в число
int num = int.Parse(userInput);

// проверяем число на четность
if (num % 2 == 0) Console.WriteLine($"{num} -> да");
else Console.WriteLine($"{num} -> нет");