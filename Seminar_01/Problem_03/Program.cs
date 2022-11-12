Console.Write("Введите целое число от 1 до 7 и нажмите enter: ");
string userInput = Console.ReadLine() ?? "";  

int num = int.Parse(userInput); 

if (num == 1) Console.WriteLine($"{num} -> Понедельник");
else if (num == 2) Console.WriteLine($"{num} -> Вторник");
else if (num == 3) Console.WriteLine($"{num} -> Среда");
else if (num == 4) Console.WriteLine($"{num} -> Четверг");
else if (num == 5) Console.WriteLine($"{num} -> Пятница");
else if (num == 6) Console.WriteLine($"{num} -> Суббота");
else if (num == 7) Console.WriteLine($"{num} -> Воскресенье");
else Console.WriteLine($"{num} -> Введено неверное число");