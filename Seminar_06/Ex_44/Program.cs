// 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

FiboCount(GetIntNatFromUser("Введите число N: "));

static void FiboCount(int num)
{
    Console.Write($"Если N = {num} -> 0, ");
    if (num >= 2) Console.Write($"1, ");
    int pre = 1;
    int prepre = 0;
    for (int i = 3; i <= num; i++)
    {
        int t = pre + prepre;
        Console.Write($"{t}, ");
        prepre = pre;
        pre = t;
    }
}

static int GetIntNatFromUser(string userMsg)
{
    while(true)
    {
        Console.Write(userMsg);
        if (int.TryParse(Console.ReadLine(), out int num))
            if (num >0)
                return num;
        Console.WriteLine("Ошибка ввода!");
    }
}