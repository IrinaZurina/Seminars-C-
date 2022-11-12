// Запрашиваем числа от пользователя
Console.Write("Введите первое целое число и нажмите enter: ");
string userInput1 = Console.ReadLine() ?? "";   
Console.Write("Введите второе целое число и нажмите enter: ");
string userInput2 = Console.ReadLine() ?? "";  
Console.Write("Введите тертье целое число и нажмите enter: ");
string userInput3 = Console.ReadLine() ?? ""; 

// преобразование строки в число
int num1 = int.Parse(userInput1);  
int num2 = int.Parse(userInput2); 
int num3 = int.Parse(userInput3);   

// дополнительная переменная для сохранения максимального числа
int max = num1;

// сравниваем поочередно числа, новое максимальное записываем в переменную max
if (num1 > num2) max = num1;
else max = num2;

if (num3 > max) max = num3;

//выводим максимальное число
Console.WriteLine($"{num1}, {num2}, {num3} -> {max}");