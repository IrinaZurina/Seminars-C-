// Запрашиваем число от пользователя и генерируем рандомное число
Console.Write("Введите целое число и нажмите enter: ");
string userInput = Console.ReadLine() ?? "";   //?? "" - проверка на null
int randomNum = new Random().Next(1, 100);

// преобразование строки в число
int userNum = int.Parse(userInput);  

// Возводим числа в квадрат
int sqr_userNum = userNum * userNum;
int sqr_randomNum = randomNum * randomNum;

// Выводим результаты
Console.WriteLine($"{userNum} -> {sqr_userNum}");
Console.WriteLine($"{randomNum} -> {sqr_randomNum}");