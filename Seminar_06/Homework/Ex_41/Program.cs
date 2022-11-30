// 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

int numM = GetNumberFromUser("Сколько чисел вы хотите ввести? ","Ошибка ввода!");
int numPos = CountPositiveNumbers(numM);
Console.WriteLine($"Количество положительных чисел = {numPos}");
    

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

int CountPositiveNumbers(int num)
{
    int count = 0;
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = GetNumberFromUser("Введите число: ","Ошибка ввода!");
        if (array[i] > 0) count++;
    }
    Console.Write("Введенные числа: ");
    Console.WriteLine(string.Join(" ", array));
    return count;
}