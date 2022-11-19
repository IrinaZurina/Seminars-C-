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
double cube;   // переменная для результата вычислений

Console.Write($"{userNum} -> ");   // начало строки вывода

// цикл для пошагового вычисления кубов
while (i < userNum)
{
    cube = Math.Pow(i, 3);
    Console.Write($"{cube}, ");
    i ++;
}

cube = Math.Pow(i, 3);
Console.Write(cube);   // Последний куб выводим отдельно без запятой