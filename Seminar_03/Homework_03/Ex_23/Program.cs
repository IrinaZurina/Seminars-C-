// программа принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
int userNum;

try
{
    Console.Write("Введите целое число: ");
    userNum = int.Parse(Console.ReadLine() ?? "");
}

catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода даных! {exc.Message}");
    return;
}

int i = 1;   // переменная-счетчик

Console.Write($"{userNum} -> ");   // начало строки вывода

// цикл для пошагового вычисления кубов
while (i < userNum)
{
    CubeCalculation(i);
    Console.Write(", ");
    i ++;
}

CubeCalculation(i);   // Последний куб выводим отдельно без запятой

// Метод для вычисления и вывода куба числа
static void CubeCalculation(int num)
{
    double cube = Math.Pow(num, 3);
    Console.Write($"{cube}");
    return;
}