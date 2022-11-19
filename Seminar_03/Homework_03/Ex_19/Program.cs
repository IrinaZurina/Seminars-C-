//Программа принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.

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
    if (GetFirstDigit(userNumCopy, digitsNum) == GetLastDigit(userNumCopy)) answer = "да";
    else answer = "нет";

    if (answer == "нет") break;
    else 
    {
        userNumCopy = GetThreeDigitNum(userNumCopy, digitsNum);   // 12345 -> 2345 -> 234
        digitsNum -= 2;  // теперь кол-во разрядов - 3
    }
}

Console.WriteLine($"{userNum} -> {answer}");

//-------Методы-------
// Метод для вычисления первой цифры числа
static int GetFirstDigit(int num, int digits)
{
    return Convert.ToInt32(num / Math.Pow(10, digits - 1));
}

// Метод для вычисления последней цифры числа
static int GetLastDigit(int num)
{
    return num % 10;
}

// Метод для приведения 5-значного числа к 3-значному
static int GetThreeDigitNum(int num, int digits)
{
    return Convert.ToInt32((num % Math.Pow(10, digits - 1)) / 10);
}