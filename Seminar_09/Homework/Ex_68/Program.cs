// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

int m = GetNumberFromUser("Введите первое целое положительное число:  ","Ошибка ввода!");
int n = GetNumberFromUser("Введите второе целое положительное число:  ","Ошибка ввода!");

int result = AkkermanFunction(m, n);

Console.WriteLine($"M = {m}, N = {n} -> {result}");

// метод для поиска суммы натуральных чисел на промежутке от M до N
int AkkermanFunction(int m, int n)
{
    if(m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    else return(AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
}


//  метод получения числа от пользователя
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

