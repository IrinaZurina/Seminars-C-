// Запрашиваем число от пользователя и генерируем рандомное число
Console.Write("Введите первое целое число и нажмите enter: ");
string userInput1 = Console.ReadLine() ?? "";   //?? "" - проверка на null
Console.Write("Введите второе целое число и нажмите enter: ");
string userInput2 = Console.ReadLine() ?? "";   //?? "" - проверка на null

// преобразование строки в число
int num1 = int.Parse(userInput1);  
int num2 = int.Parse(userInput2);  

if (num1 == num2 * num2)
{
    Console.WriteLine($"{num1}, {num2} -> да");
}

else
{
    Console.WriteLine($"{num1}, {num2} -> нет");
}