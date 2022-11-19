//Программа принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.

// проверить, является ли 5-значное число палиндромом
Console.Clear();
int userNum;

// Получаем от пользователя число
try
{
    Console.Write("Введите Пятизначное число: ");
    userNum = Convert.ToInt32(Console.ReadLine() ?? "");
}

catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода даных! {exc.Message}");
    return;
}

// Вводим доп. переменные
int userNumCopy = userNum;   // копия числа, чтобы потом его модифицировать
int digitsNum = 5;   // исходное количество разрядов
string answer = null;   // переменная для ответа, без инициализации почему-то не работала

// цикл для проверки равенства первой и последней цифр
for (int i = 0; i < 2; i++)   // т.к. нужно всего 2 прогона
{
    if (Convert.ToInt32(userNumCopy / Math.Pow(10, digitsNum - 1)) == userNumCopy % 10) answer = "да";
    else answer = "нет";

    if (answer == "нет") break;
    else 
    {
        userNumCopy = Convert.ToInt32((userNumCopy % Math.Pow(10, digitsNum - 1)) / 10);   // 12345 -> 2345 -> 234
        digitsNum -= 2;  // теперь кол-во разрядов - 3
    }
}

Console.WriteLine($"{userNum} -> {answer}");