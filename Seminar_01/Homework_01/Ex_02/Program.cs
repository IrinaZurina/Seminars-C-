// Запрашиваем числа от пользователя
Console.Write("Введите первое целое число и нажмите enter: ");
string userInput1 = Console.ReadLine() ?? "";   
Console.Write("Введите второе целое число и нажмите enter: ");
string userInput2 = Console.ReadLine() ?? "";  

// преобразование строки в число
int num1 = int.Parse(userInput1);  
int num2 = int.Parse(userInput2);  

// сравниваем числа и выводим большее
if (num1 > num2) Console.WriteLine($"a = {num1}, b = {num2} -> max = {num1}");
else if (num1 < num2) Console.WriteLine($"a = {num1}, b = {num2} -> max = {num2}");
else Console.WriteLine($"a = {num1}, b = {num2} -> a = b");
